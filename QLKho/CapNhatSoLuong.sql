USE [QLKho]
GO
/****** Object:  StoredProcedure [dbo].[pr_Kho_VatTu_Update_SoLuong]    Script Date: 03/31/2017 16:28:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[pr_Kho_VatTu_Update_SoLuong]
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

--SELECT *
--FROM Kho_VatTu a
--INNER JOIN dbo.QD_NhapVatTu_ChiTiet b ON b.ID_Kho = a.ID_Kho AND b.ID_VatTu = a.ID_VatTu 
--WHERE b.ID_QuyetDinh = 22