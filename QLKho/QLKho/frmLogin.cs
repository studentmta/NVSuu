using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using System.Management;
using System.Data.SqlClient;

namespace Garco10.Login
{
    public partial class frmLogin : Form
    {
        string[] ListFileUpdate;
        string FederoKey = "3987";        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdMoRong_Click(object sender, EventArgs e)
        {
            this.Height = 347;
            cmdThuNho.Visible = true;
            cmdMoRong.Visible = false;
        }

        private void cmdThuNho_Click(object sender, EventArgs e)
        {
            this.Height = 210;
            cmdThuNho.Visible = false;
            cmdMoRong.Visible = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (bIsFileOpening("Garco10.Presenter.Main"))
            {
                MessageBox.Show("Đã có phân hệ nghiệp vụ đang chạy trên máy, không cần đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();

                //foreach (Process p in Process.GetProcessesByName("Garco10.Presenter.Main"))
                //{
                //    p.Kill();
                //}
            }

            cmdThuNho_Click(null, null);
            txtNgayLV.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");

            FileInfo fFileInfo = new FileInfo((Application.StartupPath + "\\Login.ini"));
            if (!fFileInfo.Exists)
            {
                fFileInfo.Create();                
            }
            else
            {
                StreamReader m_FileStream = fFileInfo.OpenText();
                txtND_TenDangNhap.Text = m_FileStream.ReadLine();
                txtMC_TenServer.Text = m_FileStream.ReadLine();
                txtMC_TenDangNhap.Text = m_FileStream.ReadLine();
                txtMC_MatKhau.Text = m_FileStream.ReadLine();
                string internet = m_FileStream.ReadLine();
                if (internet == "Y") chkInternet.Checked = true;

                string sActiveReports = m_FileStream.ReadLine();

                if ("" + sActiveReports != "1") Delete_ActiveReportsFiles();

                m_FileStream.Close();                
            }

            if (txtND_TenDangNhap.Text.Trim() != "") txtND_MatKhau.Select();
        }

        private bool bIsFileOpening(string ProcessName)
        {
            return !(Process.GetProcessesByName(ProcessName).Length == 0);
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {            
            if (txtMC_TenServer.Text == "" || txtMC_TenDangNhap.Text == "" || txtMC_MatKhau.Text == "")
            {
                if (this.Height == 210) cmdMoRong_Click(null, null);

                if (txtMC_TenServer.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập Tên máy chủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMC_TenServer.Focus();
                    return;
                }

                if (txtMC_TenDangNhap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập Tên đăng nhập máy chủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMC_TenDangNhap.Focus();
                    return;
                }

                if (txtMC_MatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu máy chủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMC_MatKhau.Focus();
                    return;
                }               
            }

            //Kiểm tra mật khẩu người dùng            
            Cryptography.clsCryptography cry = new Cryptography.clsCryptography();
            string sPassword = cry.FederoDecrypt(txtMC_MatKhau.Text.Trim(), FederoKey);

            string sConnectionString = string.Format("Data Source={0};Initial Catalog={1}; User ID={2}; Password={3}",
                                                      txtMC_TenServer.Text, "M10_System", txtMC_TenDangNhap.Text, sPassword);
            SqlConnection oConn = new SqlConnection();
            SqlCommand cmd;
            string uTenDangNhap = txtND_TenDangNhap.Text.Trim().ToLower();
            string uMatKhau = txtND_MatKhau.Text.Trim();
            string uMatKhau_DB = "";

            try
            {
                oConn.ConnectionString = sConnectionString;
                oConn.Open();

                cmd = new SqlCommand();
                cmd.Connection = oConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = string.Format("SELECT MatKhau FROM dbo.TaiKhoanDangNhap WHERE TonTai = 1 AND SuDung = 1 AND TenDangNhap = '{0}'", uTenDangNhap);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Kiểm tra mật khẩu   
                uMatKhau_DB = dt.Rows[0]["MatKhau"].ToString();
                if (cry.getMd5Hash(uMatKhau) != uMatKhau_DB)
                {
                    MessageBox.Show("Mật khẩu đăng nhập không đúng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
             
                //Thực hiện tải file
                int NumOfFiles = 0;
                Array.Resize(ref ListFileUpdate, 0);
                cmd = new SqlCommand();
                cmd.Connection = oConn;
                cmd.CommandTimeout = 9000;
                cmd.CommandText = string.Format("Select FileName FROM Application_Files WHERE Upper(Filename) <> 'Garco10.Login.EXE'");

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    NumOfFiles++;
                    Array.Resize(ref ListFileUpdate, NumOfFiles);
                    ListFileUpdate[NumOfFiles - 1] = dr["FileName"].ToString();
                }

                for (int i = 0; i <= ListFileUpdate.GetUpperBound(0); i++)
                {
                    Download_File(ListFileUpdate[i].ToUpper(), oConn);
                }

                FileInfo fFileInfo = new FileInfo((Application.StartupPath + "\\Login.ini"));

                StreamWriter m_FileWrite = fFileInfo.CreateText();
                m_FileWrite.WriteLine(txtND_TenDangNhap.Text);
                m_FileWrite.WriteLine(txtMC_TenServer.Text);
                m_FileWrite.WriteLine(txtMC_TenDangNhap.Text);
                m_FileWrite.WriteLine(txtMC_MatKhau.Text);
                if (chkInternet.Checked) m_FileWrite.WriteLine("Y");
                else m_FileWrite.WriteLine("N");
                m_FileWrite.WriteLine("1");
                m_FileWrite.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            finally
            {
                oConn.Close();
                oConn.Dispose();
            }
           
            if (!Exec_Application()) return;
            Application.Exit();
        }

        private bool Exec_Application()
        {
            bool bReturn = true;
            string ExeFileName = "Garco10.Presenter.Main.EXE";

            System.Diagnostics.ProcessStartInfo psi_ctl = new System.Diagnostics.ProcessStartInfo();
            if (!System.IO.File.Exists(Application.StartupPath + "\\" + ExeFileName))
            {
                MessageBox.Show("Không tìm thấy file " + ExeFileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bReturn = false;
            }

            if (bReturn)
            {
                Cryptography.clsCryptography cry = new Cryptography.clsCryptography();
                psi_ctl.FileName = ExeFileName;
                psi_ctl.Arguments = string.Format("/TenND {0}/MatKhauND {1}/TenMC {2}/TenDangNhapMC {3}/MatKhauMC {4}/Internet {5}",
                                                  txtND_TenDangNhap.Text,
                                                  txtND_MatKhau.Text,
                                                  txtMC_TenServer.Text,
                                                  txtMC_TenDangNhap.Text,
                                                  cry.FederoDecrypt(txtMC_MatKhau.Text.Trim(), FederoKey),
                                                  chkInternet.Checked ? "Y" : "N");
                System.Diagnostics.Process.Start(psi_ctl);
            }

            return bReturn;
        }

        private bool Download_File(string FileName, System.Data.SqlClient.SqlConnection ConnectSQL)
        {            
            bool FileExists = true;
            string DBFileVersion = "";
            System.Data.SqlClient.SqlCommand cmd = null;
            try
            {
                if (!File.Exists(Application.StartupPath + "\\" + FileName)) FileExists = false;

                string FileVersion = "";

                if (FileExists)
                {
                    if (FileName.Substring((FileName.Length - 3)).ToUpper() != "DLL" &&
                        FileName.Substring((FileName.Length - 3)).ToUpper() != "EXE")
                    {
                        FileVersion = string.Format("{0:yyyy.MM.dd.HH.mm}", File.GetLastWriteTime(Application.StartupPath + @"\" + FileName));
                    }

                    else
                    {
                        FileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.StartupPath + @"\" + FileName).FileVersion;
                    }
                }

                System.Data.SqlClient.SqlDataReader dr;
                cmd = new System.Data.SqlClient.SqlCommand();
                cmd.Connection = ConnectSQL;
                cmd.CommandText = string.Format("SELECT FileVersion FROM Application_Files WHERE UPPER(FileName)= '{0}'", FileName);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DBFileVersion = dr["FileVersion"].ToString();
                }

                dr.Close();

                if ((string.Compare(FileVersion, DBFileVersion) < 0))
                {
                    cmd.CommandTimeout = 9000;
                    cmd.CommandText = string.Format("SELECT FileData FROM Application_Files WHERE UPPER(FileName)= '{0}'", FileName);
                    byte[] buffer = (byte[])cmd.ExecuteScalar();
                    if (buffer != null)
                    {
                        Stream OutputStream = File.OpenWrite((Application.StartupPath + "\\tmpFileUpdate"));
                        OutputStream.Write(buffer, 0, buffer.Length);
                        OutputStream.Close();

                        if (FileExists)
                        {
                            File.SetAttributes(Application.StartupPath + @"\" + FileName, FileAttributes.Normal);
                            File.Delete(Application.StartupPath + @"\" + FileName);
                            //File.Copy(Application.StartupPath + @"\" + FileName, Application.StartupPath + @"\BackupOf" + FileName, true);
                        }

                        File.Copy(Application.StartupPath + @"\tmpFileUpdate", Application.StartupPath + @"\" + FileName, true);

                        if ((FileName.Substring((FileName.Length - 3)).ToUpper() == "XLS"))
                        {
                            string tmpDate = (((DBFileVersion.Substring(0, 4) + "-" + DBFileVersion.Substring(5, 2) + "-") + DBFileVersion.Substring(8, 2) + " ") + DBFileVersion.Substring(11, 2) + ":") + DBFileVersion.Substring(14, 2) + ":00";
                            File.SetLastWriteTime(Application.StartupPath + @"\" + FileName, DateTime.Parse(tmpDate));
                        }

                        File.Delete((Application.StartupPath + "\\tmpFileUpdate"));
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            finally
            {
                if (cmd != null) cmd.Dispose();
            }

            return true;
        }

        private void PicPassword_Click(object sender, EventArgs e)
        {
            //Cryptography.clsCryptography cry = new Cryptography.clsCryptography();
            //string sPass = Interaction.InputBox("Nhập mật khẩu đăng nhập máy chủ", "Thông báo", "");
            //Interaction.InputBox("Mật khẩu đăng nhập sau khi mã hóa", "Thông báo", cry.Federo(sPass, FederoKey));
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {

        }

        private void Delete_ActiveReportsFiles()
        {
            if (File.Exists(Application.StartupPath + "\\" + "ActiveReports6.dll"))
            {
                File.SetAttributes("ActiveReports6.dll", FileAttributes.Normal);
                File.Delete(Application.StartupPath + "\\" + "ActiveReports6.dll");
            }

            if (File.Exists(Application.StartupPath + "\\" + "ACTIVEREPORTS.PDFEXPORT.DLL"))
            {
                File.SetAttributes("ACTIVEREPORTS.PDFEXPORT.DLL", FileAttributes.Normal);
                File.Delete(Application.StartupPath + "\\" + "ACTIVEREPORTS.PDFEXPORT.DLL");
            }

            if (File.Exists(Application.StartupPath + "\\" + "ACTIVEREPORTS.DESIGN6.DLL"))
            {
                File.SetAttributes("ACTIVEREPORTS.DESIGN6.DLL", FileAttributes.Normal);
                File.Delete(Application.StartupPath + "\\" + "ACTIVEREPORTS.DESIGN6.DLL");
            }
        }    
    }
}
