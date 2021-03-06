USE [master]
GO
/****** Object:  Database [QLKho]    Script Date: 07/03/2017 10:24:30 ******/
CREATE DATABASE [QLKho] ON  PRIMARY 
( NAME = N'QLKho', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLKho.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLKho_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLKho_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLKho] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKho] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLKho] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLKho] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLKho] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLKho] SET ARITHABORT OFF
GO
ALTER DATABASE [QLKho] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLKho] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLKho] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLKho] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLKho] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLKho] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLKho] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLKho] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLKho] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLKho] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLKho] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLKho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLKho] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLKho] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLKho] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLKho] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLKho] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLKho] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLKho] SET  READ_WRITE
GO
ALTER DATABASE [QLKho] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLKho] SET  MULTI_USER
GO
ALTER DATABASE [QLKho] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLKho] SET DB_CHAINING OFF
GO
USE [QLKho]
GO
/****** Object:  Table [dbo].[QD_NhapVatTu_ChiTiet]    Script Date: 07/03/2017 10:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QD_NhapVatTu_ChiTiet](
	[ID_QuyetDinh] [int] NOT NULL,
	[ID_Kho] [int] NOT NULL,
	[ID_VatTu] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_QD_NhapVatTu_ChiTiet_1] PRIMARY KEY CLUSTERED 
(
	[ID_QuyetDinh] ASC,
	[ID_Kho] ASC,
	[ID_VatTu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (1, 3, 2, 5)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (1, 4, 7, 90)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (2, 1, 5, 40)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (2, 4, 1, 50)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (4, 1, 1, 10)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (4, 3, 5, 20)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (4, 4, 6, 50)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (5, 3, 1, 15)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (5, 4, 5, 30)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (6, 3, 2, 23)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (6, 4, 7, 42)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (10, 3, 3, 15)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (11, 3, 3, 60)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (12, 1, 1, 100)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (12, 4, 6, 150)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (15, 1, 7, 66)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (15, 3, 2, 15)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (16, 1, 2, 50)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (16, 3, 7, 100)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (17, 1, 8, 12)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (17, 3, 3, 50)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (18, 3, 2, 30)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (18, 4, 7, 40)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (19, 4, 1, 123)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (20, 4, 1, 50)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (21, 3, 1, 50)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (21, 4, 5, 50)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (22, 1, 1, 56)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (22, 1, 5, 15)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (22, 1, 6, 20)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (22, 4, 5, 34)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (23, 1, 7, 50)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (23, 4, 7, 50)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (24, 1, 5, 21)
INSERT [dbo].[QD_NhapVatTu_ChiTiet] ([ID_QuyetDinh], [ID_Kho], [ID_VatTu], [SoLuong]) VALUES (24, 1, 6, 23)
/****** Object:  Table [dbo].[QD_NhapVatTu]    Script Date: 07/03/2017 10:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QD_NhapVatTu](
	[ID_QuyetDinh] [int] IDENTITY(1,1) NOT NULL,
	[ID_NhaCungCap] [int] NOT NULL,
	[So_QuyetDinh] [nvarchar](50) NOT NULL,
	[Ngay_QuyetDinh] [smalldatetime] NOT NULL,
	[NgayLap] [smalldatetime] NOT NULL,
	[Ngay_SuaCuoi] [smalldatetime] NOT NULL,
	[TrangThai] [tinyint] NOT NULL,
	[TonTai] [bit] NOT NULL,
 CONSTRAINT [PK_QD_NhapVatTu] PRIMARY KEY CLUSTERED 
(
	[ID_QuyetDinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[QD_NhapVatTu] ON
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (1, 2, N'1', CAST(0xA74402C0 AS SmallDateTime), CAST(0xA74402C0 AS SmallDateTime), CAST(0xA7440412 AS SmallDateTime), 5, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (2, 1, N'2', CAST(0xA7460000 AS SmallDateTime), CAST(0xA7440311 AS SmallDateTime), CAST(0xA7440311 AS SmallDateTime), 3, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (3, 3, N'3', CAST(0xA7440314 AS SmallDateTime), CAST(0xA7440314 AS SmallDateTime), CAST(0xA7440314 AS SmallDateTime), 3, 0)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (4, 1, N'4', CAST(0xA7470000 AS SmallDateTime), CAST(0xA7440412 AS SmallDateTime), CAST(0xA7440412 AS SmallDateTime), 5, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (5, 1, N'5', CAST(0xA744052D AS SmallDateTime), CAST(0xA744052D AS SmallDateTime), CAST(0xA745058E AS SmallDateTime), 5, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (6, 2, N'6', CAST(0xA7480000 AS SmallDateTime), CAST(0xA744052E AS SmallDateTime), CAST(0xA744052E AS SmallDateTime), 3, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (11, 3, N'7', CAST(0xA745059C AS SmallDateTime), CAST(0xA745059D AS SmallDateTime), CAST(0xA745059D AS SmallDateTime), 1, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (12, 1, N'8', CAST(0xA7460005 AS SmallDateTime), CAST(0xA7460006 AS SmallDateTime), CAST(0xA7460006 AS SmallDateTime), 5, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (15, 2, N'9', CAST(0xA7460007 AS SmallDateTime), CAST(0xA7460008 AS SmallDateTime), CAST(0xA7460464 AS SmallDateTime), 0, 0)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (16, 2, N'10', CAST(0xA746000A AS SmallDateTime), CAST(0xA746000B AS SmallDateTime), CAST(0xA746000C AS SmallDateTime), 3, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (18, 2, N'12', CAST(0xA746027B AS SmallDateTime), CAST(0xA746027B AS SmallDateTime), CAST(0xA7460354 AS SmallDateTime), 5, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (20, 1, N'13', CAST(0xA7460536 AS SmallDateTime), CAST(0xA7460537 AS SmallDateTime), CAST(0xA7460537 AS SmallDateTime), 3, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (21, 1, N'15', CAST(0xA74703A1 AS SmallDateTime), CAST(0xA74703A1 AS SmallDateTime), CAST(0xA74703A2 AS SmallDateTime), 5, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (22, 1, N'16', CAST(0xA74703D3 AS SmallDateTime), CAST(0xA74703D5 AS SmallDateTime), CAST(0xA7480238 AS SmallDateTime), 3, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (23, 2, N'17', CAST(0xA7480245 AS SmallDateTime), CAST(0xA7480246 AS SmallDateTime), CAST(0xA7480246 AS SmallDateTime), 5, 1)
INSERT [dbo].[QD_NhapVatTu] ([ID_QuyetDinh], [ID_NhaCungCap], [So_QuyetDinh], [Ngay_QuyetDinh], [NgayLap], [Ngay_SuaCuoi], [TrangThai], [TonTai]) VALUES (24, 1, N'12323', CAST(0xA75A0450 AS SmallDateTime), CAST(0xA75A0451 AS SmallDateTime), CAST(0xA75A0451 AS SmallDateTime), 0, 1)
SET IDENTITY_INSERT [dbo].[QD_NhapVatTu] OFF
/****** Object:  Table [dbo].[DM_VatTu]    Script Date: 07/03/2017 10:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_VatTu](
	[ID_VatTu] [int] IDENTITY(1,1) NOT NULL,
	[Ten_VatTu] [nvarchar](50) NOT NULL,
	[TonTai] [bit] NOT NULL,
	[SuDung] [bit] NOT NULL,
	[ID_NhaCungCap] [int] NULL,
 CONSTRAINT [PK_DM_VatTu] PRIMARY KEY CLUSTERED 
(
	[ID_VatTu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DM_VatTu] ON
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (1, N'Vat Tu 1 NCC 1', 1, 1, 1)
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (2, N'Vat Tu 2 NCC 2', 1, 1, 2)
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (3, N'Vật Tư 3 NCC 3', 1, 1, 3)
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (4, N'Vat Tu 4 NCC 1', 0, 1, 1)
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (5, N'Vat Tu 2 NCC 1 ', 1, 1, 1)
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (6, N'Vat Tu 3 NCC 1', 1, 1, 1)
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (7, N'Vat Tu 1 NCC 2', 1, 1, 2)
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (8, N'Vật Tư 1 NCC 3', 1, 1, 3)
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (9, N'Vật Tư 2 NCC 3', 1, 1, 3)
INSERT [dbo].[DM_VatTu] ([ID_VatTu], [Ten_VatTu], [TonTai], [SuDung], [ID_NhaCungCap]) VALUES (10, N'sađá', 0, 1, 6)
SET IDENTITY_INSERT [dbo].[DM_VatTu] OFF
/****** Object:  Table [dbo].[DM_NhaCungCap]    Script Date: 07/03/2017 10:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_NhaCungCap](
	[ID_NhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[Ten_NhaCungCap] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[SuDung] [bit] NOT NULL,
	[TonTai] [bit] NOT NULL,
 CONSTRAINT [PK_DM_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[ID_NhaCungCap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DM_NhaCungCap] ON
INSERT [dbo].[DM_NhaCungCap] ([ID_NhaCungCap], [Ten_NhaCungCap], [DiaChi], [Email], [SoDienThoai], [SuDung], [TonTai]) VALUES (1, N'Nhacungcap 1', N'49 Gilbert St.', N'1234@gmail.com', N'(171) 555-2222', 1, 1)
INSERT [dbo].[DM_NhaCungCap] ([ID_NhaCungCap], [Ten_NhaCungCap], [DiaChi], [Email], [SoDienThoai], [SuDung], [TonTai]) VALUES (2, N'Nhacungcap 2', N'P.O. Box 78934', N'4567@gmail.com', N'(100) 555-4822', 1, 1)
INSERT [dbo].[DM_NhaCungCap] ([ID_NhaCungCap], [Ten_NhaCungCap], [DiaChi], [Email], [SoDienThoai], [SuDung], [TonTai]) VALUES (3, N'Nhacungcap 3', N'707 Oxford Rd.', N'zzzz@gmail.com', N'(313) 555-5735', 1, 1)
INSERT [dbo].[DM_NhaCungCap] ([ID_NhaCungCap], [Ten_NhaCungCap], [DiaChi], [Email], [SoDienThoai], [SuDung], [TonTai]) VALUES (6, N'Nhacungcap 4', N'adsadadad', N'adasd@gmail.com', N'(313) 777-2321', 1, 1)
INSERT [dbo].[DM_NhaCungCap] ([ID_NhaCungCap], [Ten_NhaCungCap], [DiaChi], [Email], [SoDienThoai], [SuDung], [TonTai]) VALUES (7, N'Nhacungcap 5', N'cvxcvxcvxvx', N'xcz@gmail.com', N'(043) 875-5014', 1, 1)
INSERT [dbo].[DM_NhaCungCap] ([ID_NhaCungCap], [Ten_NhaCungCap], [DiaChi], [Email], [SoDienThoai], [SuDung], [TonTai]) VALUES (8, N'NCC 6', N'asưqewêqưeqưe', N'ádsdzxczcx', N'(054) 123-4123', 1, 0)
INSERT [dbo].[DM_NhaCungCap] ([ID_NhaCungCap], [Ten_NhaCungCap], [DiaChi], [Email], [SoDienThoai], [SuDung], [TonTai]) VALUES (9, N'asdasdasd', N's', N's', N's', 0, 0)
SET IDENTITY_INSERT [dbo].[DM_NhaCungCap] OFF
/****** Object:  Table [dbo].[DM_Kho]    Script Date: 07/03/2017 10:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_Kho](
	[ID_Kho] [int] IDENTITY(1,1) NOT NULL,
	[Ten_Kho] [nvarchar](50) NOT NULL,
	[TonTai] [bit] NOT NULL,
	[SuDung] [bit] NOT NULL,
 CONSTRAINT [PK_DM_Kho] PRIMARY KEY CLUSTERED 
(
	[ID_Kho] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DM_Kho] ON
INSERT [dbo].[DM_Kho] ([ID_Kho], [Ten_Kho], [TonTai], [SuDung]) VALUES (1, N'Kho 1', 1, 1)
INSERT [dbo].[DM_Kho] ([ID_Kho], [Ten_Kho], [TonTai], [SuDung]) VALUES (3, N'Kho Thit.', 1, 1)
INSERT [dbo].[DM_Kho] ([ID_Kho], [Ten_Kho], [TonTai], [SuDung]) VALUES (4, N'Kho Ca''', 1, 1)
INSERT [dbo].[DM_Kho] ([ID_Kho], [Ten_Kho], [TonTai], [SuDung]) VALUES (5, N'Kho Vat Tu', 1, 1)
INSERT [dbo].[DM_Kho] ([ID_Kho], [Ten_Kho], [TonTai], [SuDung]) VALUES (8, N'Kho 2', 0, 1)
INSERT [dbo].[DM_Kho] ([ID_Kho], [Ten_Kho], [TonTai], [SuDung]) VALUES (9, N'Kho 5', 1, 1)
SET IDENTITY_INSERT [dbo].[DM_Kho] OFF
/****** Object:  Table [dbo].[Kho_VatTu]    Script Date: 07/03/2017 10:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho_VatTu](
	[ID_Kho] [int] NOT NULL,
	[ID_VatTu] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_Kho_VatTu] PRIMARY KEY CLUSTERED 
(
	[ID_Kho] ASC,
	[ID_VatTu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (1, 1, 135)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (1, 2, 50)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (1, 5, 40)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (1, 7, 50)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (1, 9, 20)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (3, 1, 100)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (3, 2, 42)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (3, 5, 40)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (3, 7, 100)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (4, 1, 50)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (4, 5, 130)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (4, 6, 250)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (4, 7, 182)
INSERT [dbo].[Kho_VatTu] ([ID_Kho], [ID_VatTu], [SoLuong]) VALUES (9, 9, 80)
/****** Object:  View [dbo].[Kho Vat Tu]    Script Date: 07/03/2017 10:24:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Kho Vat Tu] AS
SELECT Ten_Kho, Kho_VatTu.ID_Kho, Ten_VatTu, Kho_VatTu.ID_VatTu, SoLuong
FROM dbo.DM_Kho INNER JOIN dbo.Kho_VatTu ON Kho_VatTu.ID_Kho = DM_Kho.ID_Kho
INNER JOIN dbo.DM_VatTu ON DM_VatTu.ID_VatTu = Kho_VatTu.ID_VatTu
WHERE DM_Kho.TonTai = 1 AND DM_VatTu.TonTai = 1
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_Update]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_Update]
	@ID_QuyetDinh int,
	@ID_NhaCungCap int,
	@So_QuyetDinh nvarchar(50),
	@Ngay_QuyetDinh smalldatetime,
	@NgayLap smalldatetime,
	@Ngay_SuaCuoi smalldatetime,
	@TrangThai tinyint,
	@TonTai bit
AS
SET NOCOUNT ON
UPDATE [dbo].[QD_NhapVatTu]
SET 
	[ID_NhaCungCap] = @ID_NhaCungCap,
	[So_QuyetDinh] = @So_QuyetDinh,
	[Ngay_QuyetDinh] = @Ngay_QuyetDinh,
	[NgayLap] = @NgayLap,
	[Ngay_SuaCuoi] = @Ngay_SuaCuoi,
	[TrangThai] = @TrangThai,
	[TonTai] = @TonTai
WHERE
	[ID_QuyetDinh] = @ID_QuyetDinh
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_SelectOne]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_SelectOne]
	@ID_QuyetDinh int
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[QD_NhapVatTu]
WHERE
	[ID_QuyetDinh] = @ID_QuyetDinh
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_SelectAll_DayDu]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_SelectAll_DayDu]
AS 
SET NOCOUNT ON 
SELECT a.ID_QuyetDinh, a.So_QuyetDinh, a.Ngay_QuyetDinh, a.NgayLap, a.Ngay_SuaCuoi, a.TrangThai, a.TonTai, b.ID_NhaCungCap, b.Ten_NhaCungCap,
(CASE a.TrangThai
	WHEN 0 THEN N'Đang lập'
	WHEN 1 THEN N'Trình duyệt'
	WHEN 3 THEN N'Hủy duyệt'
	WHEN 5 THEN N'Phê duyệt'
END) AS Ten_TrangThai
FROM dbo.QD_NhapVatTu a JOIN dbo.DM_NhaCungCap b ON b.ID_NhaCungCap = a.ID_NhaCungCap
WHERE b.TonTai = 1
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_SelectAll]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_SelectAll]
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[QD_NhapVatTu]
ORDER BY 
	[ID_QuyetDinh] ASC
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_Insert]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_Insert]
	@ID_NhaCungCap int,
	@So_QuyetDinh nvarchar(50),
	@Ngay_QuyetDinh smalldatetime,
	@NgayLap smalldatetime,
	@Ngay_SuaCuoi smalldatetime,
	@TrangThai tinyint,
	@TonTai bit,
	@ID_QuyetDinh int OUTPUT
AS
SET NOCOUNT ON
INSERT [dbo].[QD_NhapVatTu]
(
	[ID_NhaCungCap],
	[So_QuyetDinh],
	[Ngay_QuyetDinh],
	[NgayLap],
	[Ngay_SuaCuoi],
	[TrangThai],
	[TonTai]
)
VALUES
(
	@ID_NhaCungCap,
	@So_QuyetDinh,
	@Ngay_QuyetDinh,
	@NgayLap,
	@Ngay_SuaCuoi,
	@TrangThai,
	@TonTai
)
SELECT @ID_QuyetDinh=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_Delete]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_Delete]
	@ID_QuyetDinh int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[QD_NhapVatTu]
WHERE
	[ID_QuyetDinh] = @ID_QuyetDinh
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_UpdateKho_VatTu]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_UpdateKho_VatTu]
AS
SET NOCOUNT ON
UPDATE dbo.Kho_VatTu
SET dbo.Kho_VatTu.SoLuong = dbo.Kho_VatTu.SoLuong + dbo.QD_NhapVatTu_ChiTiet.SoLuong
FROM dbo.Kho_VatTu JOIN dbo.QD_NhapVatTu_ChiTiet 
ON dbo.QD_NhapVatTu_ChiTiet .ID_Kho = dbo.Kho_VatTu.ID_Kho AND dbo.QD_NhapVatTu_ChiTiet.ID_VatTu = dbo.Kho_VatTu.ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_Update]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_Update]
	@ID_QuyetDinh int,
	@ID_Kho int,
	@ID_VatTu int,
	@SoLuong int
AS
SET NOCOUNT ON
UPDATE [dbo].[QD_NhapVatTu_ChiTiet]
SET 
	[SoLuong] = @SoLuong
WHERE
	[ID_QuyetDinh] = @ID_QuyetDinh
	AND [ID_Kho] = @ID_Kho
	AND [ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_SelectOne]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_SelectOne]
	@ID_QuyetDinh int,
	@ID_Kho int,
	@ID_VatTu int
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[QD_NhapVatTu_ChiTiet]
WHERE
	[ID_QuyetDinh] = @ID_QuyetDinh
	AND [ID_Kho] = @ID_Kho
	AND [ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_SelectAll_W_ID_QuyetDinh]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_SelectAll_W_ID_QuyetDinh]
	@ID_QuyetDinh INT
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[QD_NhapVatTu_ChiTiet]
WHERE ID_QuyetDinh = @ID_QuyetDinh
ORDER BY 
	[ID_QuyetDinh] ASC
	, [ID_Kho] ASC
	, [ID_VatTu] ASC
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_Select_DS_NhapVatTuVer2]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_Select_DS_NhapVatTuVer2]
	@ID_QuyetDinh INT,
	@ID_NhaCungCap INT,
	@Loai TINYINT -- 0: xem, 1: Cap nhat
AS
SET NOCOUNT ON 
SELECT a.ID_Kho, a.Ten_Kho, b.ID_VatTu, b.Ten_VatTu, c.ID_QuyetDinh, c.SoLuong,
(CASE WHEN ((c.ID_VatTu IS NULL) OR (c.ID_Kho IS NULL)) THEN 0
ELSE 1
END) AS Chon
FROM dbo.DM_Kho a 
CROSS JOIN dbo.DM_VatTu b
LEFT JOIN dbo.QD_NhapVatTu_ChiTiet c ON c.ID_Kho = a.ID_Kho AND c.ID_VatTu = b.ID_VatTu AND (c.ID_QuyetDinh = @ID_QuyetDinh)
LEFT JOIN dbo.QD_NhapVatTu d ON d.ID_QuyetDinh = c.ID_QuyetDinh 
WHERE b.ID_NhaCungCap = @ID_NhaCungCap
AND ((@Loai = 0 AND (c.ID_VatTu IS NOT NULL OR c.ID_Kho IS NOT NULL)) OR (@Loai = 1 AND (a.TonTai = 1 AND b.TonTai = 1)))
ORDER BY Chon DESC, a.ID_Kho ASC, b.ID_VatTu ASC
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_Select_DS_NhapVatTu]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- [dbo].[pr_QD_NhapVatTu_ChiTiet_Select_DS_NhapVatTu] 1,2,1
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_Select_DS_NhapVatTu]
	@ID_QuyetDinh INT,
	@ID_NhaCungCap INT,
	@Loai TINYINT -- 0: xem, 1: Cap nhat
AS
SELECT a.ID_VatTu, a.Ten_VatTu, b.ID_QuyetDinh, b.SoLuong, b.ID_Kho, 
CASE WHEN (b.ID_VatTu IS NULL) OR (b.ID_Kho IS NULL) THEN 0 
ELSE 1 
END AS Chon
FROM dbo.DM_VatTu a
LEFT JOIN dbo.QD_NhapVatTu_ChiTiet b ON b.ID_VatTu = a.ID_VatTu AND (b.ID_QuyetDinh = @ID_QuyetDinh)
LEFT JOIN dbo.QD_NhapVatTu c ON c.ID_QuyetDinh = b.ID_QuyetDinh
LEFT JOIN dbo.DM_Kho d ON d.ID_Kho = b.ID_Kho AND d.TonTai = 1
WHERE a.ID_NhaCungCap = @ID_NhaCungCap 
AND ((@Loai = 0 AND b.ID_VatTu IS NOT NULL) OR (@Loai = 1 AND a.TonTai = 1))
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_Insert]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_Insert]
	@ID_QuyetDinh int,
	@ID_Kho int,
	@ID_VatTu int,
	@SoLuong int
AS
SET NOCOUNT ON
INSERT [dbo].[QD_NhapVatTu_ChiTiet]
(
	[ID_QuyetDinh],
	[ID_Kho],
	[ID_VatTu],
	[SoLuong]
)
VALUES
(
	@ID_QuyetDinh,
	@ID_Kho,
	@ID_VatTu,
	@SoLuong
)
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_DeleteWID_VatTuLogic]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_DeleteWID_VatTuLogic]
	@ID_VatTu int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[QD_NhapVatTu_ChiTiet]
WHERE
	[ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_DeleteWID_QuyetDinhLogic]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_DeleteWID_QuyetDinhLogic]
	@ID_QuyetDinh int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[QD_NhapVatTu_ChiTiet]
WHERE
	[ID_QuyetDinh] = @ID_QuyetDinh
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_DeleteWID_KhoLogic]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_DeleteWID_KhoLogic]
	@ID_Kho int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[QD_NhapVatTu_ChiTiet]
WHERE
	[ID_Kho] = @ID_Kho
GO
/****** Object:  StoredProcedure [dbo].[pr_QD_NhapVatTu_ChiTiet_Delete]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_QD_NhapVatTu_ChiTiet_Delete]
	@ID_QuyetDinh int,
	@ID_Kho int,
	@ID_VatTu int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[QD_NhapVatTu_ChiTiet]
WHERE
	[ID_QuyetDinh] = @ID_QuyetDinh
	AND [ID_Kho] = @ID_Kho
	AND [ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_XuatKho]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_XuatKho]
	@ID_KhoNguon INT,
	@ID_VatTu INT,
	@SoLuongXuat INT,
	@ID_KhoDich INT
AS
SET NOCOUNT ON 

IF EXISTS(SELECT * FROM dbo.Kho_VatTu WHERE ID_Kho = @ID_KhoNguon AND ID_VatTu = @ID_VatTu)
UPDATE a
SET a.SoLuong = a.SoLuong - @SoLuongXuat
FROM dbo.Kho_VatTu a
WHERE a.ID_Kho = @ID_KhoNguon AND a.ID_VatTu = @ID_VatTu

IF EXISTS(SELECT * FROM dbo.Kho_VatTu WHERE ID_Kho = @ID_KhoDich AND ID_VatTu = @ID_VatTu)
UPDATE b
SET b.SoLuong = b.SoLuong + @SoLuongXuat
FROM dbo.Kho_VatTu b
WHERE b.ID_Kho = @ID_KhoDich AND b.ID_VatTu = @ID_VatTu

IF NOT EXISTS(SELECT * FROM dbo.Kho_VatTu WHERE ID_Kho = @ID_KhoDich AND ID_VatTu = @ID_VatTu)
INSERT INTO dbo.Kho_VatTu
        ( ID_Kho, ID_VatTu, SoLuong )
VALUES  ( @ID_KhoDich, -- ID_Kho - int
          @ID_VatTu, -- ID_VatTu - int
          @SoLuongXuat  -- SoLuong - int
          )
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_Update_SoLuongVer3]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_Update_SoLuongVer3]
	@ID_Kho INT,
	@ID_VatTu INT,
	@SoLuong INT
AS
DECLARE @dem INT = 0
SET @dem = (SELECT COUNT(*) FROM Kho_VatTu
WHERE ID_Kho = @ID_Kho AND ID_VatTu = @ID_VatTu) 
IF(@dem = 0)
BEGIN
	INSERT INTO Kho_VatTu(ID_Kho,ID_VatTu,SoLuong)
	VALUES(@ID_Kho, @ID_VatTu, @SoLuong)
END
ELSE
BEGIN
	UPDATE Kho_VatTu SET SoLuong = ISNULL(SoLuong,0) + @SoLuong
	WHERE ID_Kho = @ID_Kho AND ID_VatTu = @ID_VatTu
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_Update_SoLuong]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_Update_SoLuong]
	@ID_QuyetDinh INT,
	@TrangThai TINYINT 
AS 
SET NOCOUNT ON 
UPDATE a
SET SoLuong = (CASE @TrangThai
							 WHEN 5 THEN ISNULL(a.SoLuong,0) + b.SoLuong
							 WHEN 3 THEN ISNULL(a.SoLuong,0) - b.SoLuong
						     END)
FROM Kho_VatTu a
INNER JOIN dbo.QD_NhapVatTu_ChiTiet b ON b.ID_Kho = a.ID_Kho AND b.ID_VatTu = a.ID_VatTu 
WHERE b.ID_QuyetDinh = @ID_QuyetDinh
--FROM 
--(SELECT ID_Kho, ID_VatTu, SoLuong
--FROM dbo.QD_NhapVatTu_ChiTiet ct WHERE ct.ID_QuyetDinh = @ID_QuyetDinh 
--AND EXISTS(SELECT * FROM dbo.Kho_VatTu WHERE ID_Kho = ct.ID_Kho AND ID_VatTu = ct.ID_VatTu)) AS tbl
--WHERE Kho_VatTu.ID_Kho = tbl.ID_Kho AND Kho_VatTu.ID_VatTu = tbl.ID_VatTu

INSERT INTO dbo.Kho_VatTu(ID_Kho, ID_VatTu, SoLuong)
SELECT ID_Kho, ID_VatTu, SoLuong
FROM dbo.QD_NhapVatTu_ChiTiet ct
WHERE ID_QuyetDinh = @ID_QuyetDinh
AND NOT EXISTS(SELECT * FROM dbo.Kho_VatTu WHERE ID_Kho = ct.ID_Kho AND ID_VatTu = ct.ID_VatTu)
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_Update]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_Update]
	@ID_Kho int,
	@ID_VatTu int,
	@SoLuong int
AS
SET NOCOUNT ON
UPDATE [dbo].[Kho_VatTu]
SET 
	[SoLuong] = @SoLuong
WHERE
	[ID_Kho] = @ID_Kho
	AND [ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_SelectOne]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_SelectOne]
	@ID_Kho int,
	@ID_VatTu int
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[Kho_VatTu]
WHERE
	[ID_Kho] = @ID_Kho
	AND [ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_SelectDS_VatTu]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- [dbo].[pr_Kho_VatTu_SelectDS_VatTu] 1,1
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_SelectDS_VatTu]
	@ID_Kho INT, 
	@Loai TINYINT --0: xem, 1 :cap nhat
AS
SET NOCOUNT ON
SELECT a.ID_VatTu, a.Ten_VatTu, b.ID_Kho, c.Ten_Kho, b.SoLuong,
CASE WHEN b.ID_VatTu IS NULL THEN 0 
ELSE 1 
END AS Chon
FROM dbo.DM_VatTu a
LEFT JOIN dbo.Kho_VatTu b ON b.ID_VatTu = a.ID_VatTu AND (b.ID_Kho = @ID_Kho OR @ID_Kho = 0)
LEFT JOIN dbo.DM_Kho c ON c.ID_Kho = b.ID_Kho AND c.TonTai = 1
WHERE (@Loai = 0 AND b.ID_VatTu IS NOT NULL)
OR (@Loai = 1 AND a.TonTai = 1)
ORDER BY Chon DESC, b.ID_Kho ASC
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_SelectAll]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_SelectAll]
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[Kho_VatTu]
ORDER BY 
	[ID_Kho] ASC
	, [ID_VatTu] ASC
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_Insert]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_Insert]
	@ID_Kho int,
	@ID_VatTu int,
	@SoLuong int
AS
SET NOCOUNT ON
INSERT [dbo].[Kho_VatTu]
(
	[ID_Kho],
	[ID_VatTu],
	[SoLuong]
)
VALUES
(
	@ID_Kho,
	@ID_VatTu,
	@SoLuong
)
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_DeleteWID_VatTuLogic]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_DeleteWID_VatTuLogic]
	@ID_VatTu int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[Kho_VatTu]
WHERE
	[ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_DeleteWID_KhoLogic]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_DeleteWID_KhoLogic]
	@ID_Kho int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[Kho_VatTu]
WHERE
	[ID_Kho] = @ID_Kho
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_Delete]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Kho_VatTu_Delete]
	@ID_Kho int,
	@ID_VatTu int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[Kho_VatTu]
WHERE
	[ID_Kho] = @ID_Kho
	AND [ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_VatTu_Update]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_VatTu_Update]
	@ID_VatTu int,
	@Ten_VatTu nvarchar(50),
	@TonTai bit,
	@SuDung bit,
	@ID_NhaCungCap int
AS
SET NOCOUNT ON
UPDATE [dbo].[DM_VatTu]
SET 
	[Ten_VatTu] = @Ten_VatTu,
	[TonTai] = @TonTai,
	[SuDung] = @SuDung,
	[ID_NhaCungCap] = @ID_NhaCungCap
WHERE
	[ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_VatTu_SelectOne]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_VatTu_SelectOne]
	@ID_VatTu int
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[DM_VatTu]
WHERE
	[ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_VatTu_SelectAll]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_VatTu_SelectAll]
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[DM_VatTu]
ORDER BY 
	[ID_VatTu] ASC
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_VatTu_Select_VatTu_W_ID_NhaCungCap]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_VatTu_Select_VatTu_W_ID_NhaCungCap]
	@ID_NhaCungCap INT 
AS
SET NOCOUNT ON
SELECT a.ID_VatTu, a.Ten_VatTu, b.ID_Kho, b.Ten_Kho
FROM dbo.DM_VatTu a
CROSS JOIN dbo.DM_Kho b 
WHERE a.TonTai = 1 AND b.TonTai = 1 AND a.ID_NhaCungCap = @ID_NhaCungCap
ORDER BY b.ID_Kho ASC, a.ID_VatTu ASC
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_VatTu_Insert]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_VatTu_Insert]
	@Ten_VatTu nvarchar(50),
	@TonTai bit,
	@SuDung bit,
	@ID_NhaCungCap int,
	@ID_VatTu int OUTPUT
AS
SET NOCOUNT ON
INSERT [dbo].[DM_VatTu]
(
	[Ten_VatTu],
	[TonTai],
	[SuDung],
	[ID_NhaCungCap]
)
VALUES
(
	@Ten_VatTu,
	@TonTai,
	@SuDung,
	@ID_NhaCungCap
)
SELECT @ID_VatTu=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_VatTu_Delete]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_VatTu_Delete]
	@ID_VatTu int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[DM_VatTu]
WHERE
	[ID_VatTu] = @ID_VatTu
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_NhaCungCap_Update]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_NhaCungCap_Update]
	@ID_NhaCungCap int,
	@Ten_NhaCungCap nvarchar(50),
	@DiaChi nvarchar(50),
	@Email nvarchar(50),
	@SoDienThoai nvarchar(50),
	@SuDung bit,
	@TonTai bit
AS
SET NOCOUNT ON
UPDATE [dbo].[DM_NhaCungCap]
SET 
	[Ten_NhaCungCap] = @Ten_NhaCungCap,
	[DiaChi] = @DiaChi,
	[Email] = @Email,
	[SoDienThoai] = @SoDienThoai,
	[SuDung] = @SuDung,
	[TonTai] = @TonTai
WHERE
	[ID_NhaCungCap] = @ID_NhaCungCap
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_NhaCungCap_SelectOne]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_NhaCungCap_SelectOne]
	@ID_NhaCungCap int
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[DM_NhaCungCap]
WHERE
	[ID_NhaCungCap] = @ID_NhaCungCap
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_NhaCungCap_SelectAll]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_NhaCungCap_SelectAll]
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[DM_NhaCungCap]
ORDER BY 
	[ID_NhaCungCap] ASC
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_NhaCungCap_Insert]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_NhaCungCap_Insert]
	@Ten_NhaCungCap nvarchar(50),
	@DiaChi nvarchar(50),
	@Email nvarchar(50),
	@SoDienThoai nvarchar(50),
	@SuDung bit,
	@TonTai bit,
	@ID_NhaCungCap int OUTPUT
AS
SET NOCOUNT ON
INSERT [dbo].[DM_NhaCungCap]
(
	[Ten_NhaCungCap],
	[DiaChi],
	[Email],
	[SoDienThoai],
	[SuDung],
	[TonTai]
)
VALUES
(
	@Ten_NhaCungCap,
	@DiaChi,
	@Email,
	@SoDienThoai,
	@SuDung,
	@TonTai
)
SELECT @ID_NhaCungCap=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_NhaCungCap_Delete]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_NhaCungCap_Delete]
	@ID_NhaCungCap int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[DM_NhaCungCap]
WHERE
	[ID_NhaCungCap] = @ID_NhaCungCap
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_Kho_Update]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_Kho_Update]
	@ID_Kho int,
	@Ten_Kho nvarchar(50),
	@TonTai bit,
	@SuDung bit
AS
SET NOCOUNT ON
UPDATE [dbo].[DM_Kho]
SET 
	[Ten_Kho] = @Ten_Kho,
	[TonTai] = @TonTai,
	[SuDung] = @SuDung
WHERE
	[ID_Kho] = @ID_Kho
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_Kho_SelectOne]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_Kho_SelectOne]
	@ID_Kho int
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[DM_Kho]
WHERE
	[ID_Kho] = @ID_Kho
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_Kho_SelectAll]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_Kho_SelectAll]
AS
SET NOCOUNT ON
SELECT * FROM [dbo].[DM_Kho]
ORDER BY 
	[ID_Kho] ASC
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_Kho_Insert]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_Kho_Insert]
	@Ten_Kho nvarchar(50),
	@TonTai bit,
	@SuDung bit,
	@ID_Kho int OUTPUT
AS
SET NOCOUNT ON
INSERT [dbo].[DM_Kho]
(
	[Ten_Kho],
	[TonTai],
	[SuDung]
)
VALUES
(
	@Ten_Kho,
	@TonTai,
	@SuDung
)
SELECT @ID_Kho=SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_Kho_Delete]    Script Date: 07/03/2017 10:24:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_Kho_Delete]
	@ID_Kho int
AS
SET NOCOUNT ON
DELETE FROM [dbo].[DM_Kho]
WHERE
	[ID_Kho] = @ID_Kho
GO
