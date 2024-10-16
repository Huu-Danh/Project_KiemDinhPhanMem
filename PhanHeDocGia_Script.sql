create database DoAndotNet
USE [DoAndotNet]
GO
/****** Object:  Table [dbo].[CanBo]    Script Date: 07/12/2023 2:28:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanBo](
	[MaCB] [int] IDENTITY(1,1) NOT NULL,
	[MaDG] [int] NULL,
	[BoPhan] [nvarchar](255) NULL,
 CONSTRAINT [PK_CanBo] PRIMARY KEY CLUSTERED 
(
	[MaCB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 07/12/2023 2:28:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDG] [int] IDENTITY(1,1) NOT NULL,
	[MaLDG] [int] NULL,
	[HoTen] [nvarchar](255) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SDT] [varchar](10) NULL,
	[Email] [varchar](255) NULL,
	[SoDu] [float] NULL,
	[Fax] [varchar](10) NULL,
 CONSTRAINT [PK_DocGia_1] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 07/12/2023 2:28:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGV] [int] IDENTITY(1,1) NOT NULL,
	[MADG] [int] NULL,
	[ChuyenMon] [nvarchar](255) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoDich]    Script Date: 07/12/2023 2:28:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDich](
	[MaGD] [int] IDENTITY(1,1) NOT NULL,
	[MaDG] [int] NULL,
	[LoaiGD] [nvarchar](50) NULL,
	[SoTien] [float] NULL,
	[NgayGD] [date] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_GiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuDung]    Script Date: 07/12/2023 2:28:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuDung](
	[MaThe] [int] NOT NULL,
	[HoatDong] [nvarchar](255) NOT NULL,
	[LyDo] [nvarchar](255) NOT NULL,
	[ThoiGian] [date] NOT NULL,
	[MaLSD] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_LichSuDung] PRIMARY KEY CLUSTERED 
(
	[MaLSD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDocGia]    Script Date: 07/12/2023 2:28:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDocGia](
	[MaLDG] [int] IDENTITY(1,1) NOT NULL,
	[TenLDG] [nvarchar](255) NULL,
 CONSTRAINT [PK_LoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[MaLDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 07/12/2023 2:28:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [int] IDENTITY(1,1) NOT NULL,
	[MaDG] [int] NULL,
	[Lop] [nvarchar](50) NULL,
	[NamHoc] [varchar](10) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheDocGia]    Script Date: 07/12/2023 2:28:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheDocGia](
	[MaThe] [int] IDENTITY(1,1) NOT NULL,
	[MaDG] [int] NOT NULL,
	[TrangThai] [nvarchar](255) NOT NULL,
	[NgayDangKy] [date] NOT NULL,
	[NgayHetHan] [date] NOT NULL,
 CONSTRAINT [PK_TheDocGia] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DocGia] ADD  CONSTRAINT [df_SoDu]  DEFAULT ((0)) FOR [SoDu]
GO
ALTER TABLE [dbo].[CanBo]  WITH CHECK ADD  CONSTRAINT [FK_CanBo_DocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[CanBo] CHECK CONSTRAINT [FK_CanBo_DocGia]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_DocGia_LoaiDocGia] FOREIGN KEY([MaLDG])
REFERENCES [dbo].[LoaiDocGia] ([MaLDG])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [FK_DocGia_LoaiDocGia]
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK_GiangVien_DocGia] FOREIGN KEY([MADG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK_GiangVien_DocGia]
GO
ALTER TABLE [dbo].[GiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDich_DocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[GiaoDich] CHECK CONSTRAINT [FK_GiaoDich_DocGia]
GO
ALTER TABLE [dbo].[LichSuDung]  WITH CHECK ADD  CONSTRAINT [FK_LichSuDung_TheDocGia] FOREIGN KEY([MaThe])
REFERENCES [dbo].[TheDocGia] ([MaThe])
GO
ALTER TABLE [dbo].[LichSuDung] CHECK CONSTRAINT [FK_LichSuDung_TheDocGia]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_DocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_DocGia]
GO
ALTER TABLE [dbo].[TheDocGia]  WITH CHECK ADD  CONSTRAINT [FK_TheDocGia_DocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[TheDocGia] CHECK CONSTRAINT [FK_TheDocGia_DocGia]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [check_email] CHECK  (([Email] like '%_@_%._%'))
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [check_email]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [check_SDT] CHECK  (([SDT] like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [check_SDT]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [DocGiaCoGioiTinh] CHECK  (([GioiTinh]=(1) OR [GioiTinh]=(0)))
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [DocGiaCoGioiTinh]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [DocGiaThuocLoaiDG] CHECK  (([MaLDG]=(3) OR [MaLDG]=(2) OR [MaLDG]=(1)))
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [DocGiaThuocLoaiDG]
GO
--TRIGGER 
--Trigger kiểm tra bảng Loại độc giả chỉ có 3 loại: 1-Sinh viên, 2-Giảng viên, 3-Cán bộ
CREATE TRIGGER trg_check_loaidocgia
ON LoaiDocGia
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE 
            NOT (MaLDG = 1 AND TenLDG = 'Sinh viên') AND
            NOT (MaLDG = 2 AND TenLDG = 'Giảng viên') AND
            NOT (MaLDG = 3 AND TenLDG = 'Cán bộ')
    )
    BEGIN
        RAISERROR ('Mã loại độc giả và tên loại độc giả không hợp lệ.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
Go
--trigger kiểm tra Loại giao dịch chỉ gồm 6 loại: Nạp tiền, rút tiền, bị phạt, mở khóa thẻ, đền bù, thu phí.
CREATE TRIGGER trg_check_loaigiaodich
ON GiaoDich
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE 
            LoaiGD NOT IN ('Nạp tiền', 'Rút tiền', 'Bị phạt', 'Mở khóa thẻ', 'Đền bù', 'Thu phí')
    )
    BEGIN
        RAISERROR ('Loại giao dịch không hợp lệ.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
--Trigger kiểm tra trạng thái thẻ chỉ gồm 2 trạng thái: sẵn sàng, bị khóa
CREATE TRIGGER trg_check_TrangThaiThe
ON TheDocGia
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE 
            TrangThai NOT IN ('Sẵn sàng', 'Khóa')
    )
    BEGIN
        RAISERROR ('Trạng thái thẻ không hợp lệ.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
--Trigger kiểm tra 2 trường NgayDangKy và NgayHetHan trên TheDocGia sao cho NgayDangKy không lớn hơn NgayHetHan.
CREATE TRIGGER trg_check_ngay
ON TheDocGia
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE 
            NgayDangKy > NgayHetHan
    )
    BEGIN
        RAISERROR ('Ngày đăng ký không được lớn hơn ngày hết hạn.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
-- Tạo trigger để thêm thông tin cụ thể cho từng loại độc giả
CREATE TRIGGER AddReaderDetails
ON DocGia
AFTER INSERT 
AS
BEGIN 
    DECLARE @ReaderType NVARCHAR(20)
    DECLARE @ReaderID INT

    SELECT @ReaderType = MaLDG, @ReaderID = MaDG FROM inserted

    IF @ReaderType = 'Sinh viên'
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM SinhVien WHERE MaDG = @ReaderID)
        BEGIN
            -- Tạo ra lỗi nếu không tìm thấy thông tin sinh viên tương ứng
            RAISERROR ('Vui lòng nhập thêm thông tin cho sinh viên.', 16, 1)
        END
    END
    ELSE IF @ReaderType = 'Giảng viên'
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM GiangVien WHERE MaDG = @ReaderID)
        BEGIN
            -- Tạo ra lỗi nếu không tìm thấy thông tin giảng viên tương ứng
            RAISERROR ('Vui lòng nhập thêm thông tin cho giảng viên.', 16, 1)
        END
    END
    ELSE IF @ReaderType = 'Cán bộ'
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM CanBo WHERE MaDG = @ReaderID)
        BEGIN
            -- Tạo ra lỗi nếu không tìm thấy thông tin cán bộ tương ứng
            RAISERROR ('Vui lòng nhập thêm thông tin cho cán bộ.', 16, 1)
        END
    END
END
-- Tạo trigger để cập nhật ngày mở và hạn sử dụng khi thêm một thẻ độc giả mới
CREATE TRIGGER UpdateCardDate
ON TheDocGia
AFTER INSERT
AS 
BEGIN
    UPDATE TheDocGia
    SET NgayDangKy = GETDATE(),
        NgayHetHan = DATEADD(YEAR, 3, GETDATE())
    WHERE MaThe IN (SELECT MaThe FROM inserted);
END
GO

-- Cập nhật lịch sử thay đổi thông tin độc giả
--CREATE TRIGGER UpdateReaderLastModified
--ON DocGia
--AFTER UPDATE
--AS
--BEGIN
--    IF UPDATE(HoTen) OR UPDATE(NgaySinh) OR UPDATE(GioiTinh) OR UPDATE(DiaChi) OR UPDATE(SDT) OR UPDATE(Email)
--    BEGIN
--        UPDATE DocGia
--        SET DocGia.NgayCapNhat = GETDATE()
--        WHERE MaDG IN (SELECT MaDG FROM inserted);
--    END
--END
-- Đảm bảo toàn vẹn dữ liệu
-- trong tình huống xoá một row tại bảng DocGia
-- đồng thời sẽ xoá những record tương ứng trong bảng TheDocGia
CREATE TRIGGER DeleteReaderCascade
ON DocGia
AFTER DELETE
AS
BEGIN
    DELETE FROM TheDocGia
    WHERE MaDG IN (SELECT MaDG FROM deleted);
END

-- Đảm bảo toàn vẹn phân quyền
-- trong trường hợp người dùng có khả năng thay đổi
-- loại độc giả thành những loại cấm (CB, GV)
-- thì sẽ tự động thay đổi về "DG"
go
CREATE TRIGGER UpdateReaderTypeRestriction
ON DocGia
AFTER UPDATE
AS
BEGIN
    IF UPDATE(MaLDG)
    BEGIN
        DECLARE @RestrictedTypes TABLE (MaLDG NVARCHAR(2))
        INSERT INTO @RestrictedTypes (MaLDG) VALUES ('CB'), ('GV')

        UPDATE DG
        SET MaLDG = CASE
                        WHEN i.MaLDG IN (SELECT MaLDG FROM @RestrictedTypes) THEN d.MaLDG
                        ELSE i.MaLDG
                    END
        FROM DocGia DG
        INNER JOIN inserted i ON DG.MaDG = i.MaDG
        LEFT JOIN deleted d ON DG.MaDG = d.MaDG
    END
END
Go
--Stored procedure
-- 1.Lấy danh sách thông tin độc giả
create proc [dbo].[GetAllDocGia]
as
begin
			SELECT DG.MaDG, DG.MaLDG, DG.HoTen, DG.NgaySinh, DG.GioiTinh, DG.DiaChi, DG.SDT, DG.Email, DG.Fax, CB.BoPhan,
		GV.ChuyenMon, SV.Lop, SV.NamHoc 
		FROM DocGia as DG
		left join CanBo CB on DG.MaDG = CB.MaDG
		left join GiangVien GV on DG.MaDG = GV.MADG
		left join SinhVien SV on DG.MaDG = SV.MaDG

end

-- Lấy tất cả thông tin loại độc giả
GO
create proc GetLoaiDocGia
as
begin
	select *from LoaiDocGia
end
-- 2.Thêm độc giả	
Go
CREATE PROCEDURE AddReader
    @FullName NVARCHAR(50),
    @BirthDate DATE,
    @Gender NVARCHAR(10),
    @Address NVARCHAR(100),
    @Email NVARCHAR(50),
    @PhoneNumber NVARCHAR(15),
    @Fax NVARCHAR(15),
    @ReaderType NVARCHAR(20)
AS
BEGIN
	DECLARE @MALDG VARCHAR(5)
    IF @ReaderType = N'Sinh viên'
	BEGIN
		SET @MALDG = '1'
	END
	ELSE IF @ReaderType = N'Giảng viên'
	BEGIN
		SET @MALDG = '2'
	END
	ELSE IF @ReaderType = N'Cán bộ'
	BEGIN
		SET @MALDG = '3'
	END
   INSERT INTO DocGia(HoTen, NgaySinh,GioiTinh, DiaChi, Email, SDT, Fax, MaLDG)
    VALUES (@FullName, @BirthDate, @Gender, @Address, @Email, @PhoneNumber, @Fax, @MALDG)
    -- Trả về ID vừa được sinh ra
    SELECT SCOPE_IDENTITY() AS NewReaderID
END
-- Gọi stored procedure AddReader
EXEC AddReader @FullName = N'Nguyễn Văn A', 
				   @BirthDate = '1990-01-01', 
				   @Gender = '1', 
				   @Address = N'123 Đường ABC, Quận 1, TP.HCM', 
				   @Email = 'nguyenvana@gmail.com', 
				   @PhoneNumber = '0123456789',
				   @Fax = '0329923932',
				   @ReaderType = N'Cán bộ'
-- 3.Tạo stored procedure để thêm một thẻ độc giả mới
go
CREATE PROC AddCard(@MaDG INT)
AS
BEGIN
	--luôn luôn đặt trạng thái khi tạo thẻ là 'sẵn sàng'
	DECLARE @TrangThai NVARCHAR(10)
	SET @TrangThai = N'Sẵn sàng'
    -- Ngày mở thẻ là ngày hiện tại
    DECLARE @NgayMo DATE = GETDATE();
    -- Hạn sử dụng là 3 năm sau ngày mở thẻ
    DECLARE @HSD DATE = DATEADD(YEAR, 3, @NgayMo);
    INSERT INTO TheDocGia( MaDG, TrangThai, NgayDangKy, NgayHetHan)
    VALUES ( @MaDG, @TrangThai, @NgayMo, @HSD);
END
GO
EXEC AddCard 2
--4.Khóa thẻ
Go
CREATE PROC SetBlockedCard(@MaDG int, @LyDo NVARCHAR(255))
AS
BEGIN
	UPDATE TheDocGia
	SET TrangThai = N'Khóa'
	WHERE MaDG = @MaDG AND TrangThai = N'Sẵn sàng';
	    -- Lấy mã thẻ tương ứng với độc giả
    DECLARE @MaThe int;
    SELECT @MaThe = MaThe FROM TheDocGia WHERE MaDG = @MaDG;
    -- Thêm một dòng dữ liệu mới vào bảng LichSuDung
    INSERT INTO LichSuDung(MaThe, ThoiGian, HoatDong, LyDo)
    VALUES (@MaThe, GETDATE(), N'Khóa thẻ', @LyDo);
END
EXEC SetBlockedCard 2, N'Quá hạn'	
--5.Mở khóa thẻ
Go
CREATE PROC SetUnBlockedCard(@MaDG int, @LyDo NVARCHAR(255))
AS
BEGIN
	UPDATE TheDocGia
	SET TrangThai = N'Sẵn sàng', NgayDangKy = GETDATE(),  NgayHetHan = DATEADD(YEAR, 3, GETDATE())
	WHERE MaDG = @MaDG AND TrangThai = N'Khóa';
	-- Lấy mã thẻ tương ứng với độc giả
    DECLARE @MaThe int;
    SELECT @MaThe = MaThe FROM TheDocGia WHERE MaDG = @MaDG;
    -- Thêm một dòng dữ liệu mới vào bảng LichSuDung
    INSERT INTO LichSuDung(MaThe, ThoiGian, HoatDong, LyDo)
    VALUES (@MaThe, GETDATE(), N'Mở khóa thẻ', @LyDo);
END
EXEC SetUnBlockedCard 1, N'Đã đóng phạt'
--Tạo giao dịch tài chính
--6.Trừ tiền
Go
CREATE PROC CreateGiaoDichTru(@MaDG int, @LoaiGD NVARCHAR(50),@SoTien Money, @GhiChu NVARCHAR(255))
AS 
BEGIN
    DECLARE @SoDu MONEY
    SELECT @SoDu = SoDu FROM DocGia WHERE MaDG = @MaDG;
    IF @SoDu >= @SoTien
    BEGIN
        --Tạo giao dịch
        INSERT INTO GiaoDich(MaDG, LoaiGD, SoTien, GhiChu, NgayGD)
        VALUES(@MaDG, @LoaiGD,@SoTien, @GhiChu, GETDATE());
        --Trừ tiền trong tài khoản
        UPDATE DocGia
        SET SoDu = SoDu - @SoTien
        WHERE MaDG = @MaDG;
    END
    ELSE 
    BEGIN
        -- Trả về lỗi
        RAISERROR('Số dư tài khoản không đủ cho giao dịch', 16, 1);
    END
END

EXEC CreateGiaoDichTru 3, N'Thanh toán', 15000, N'Thanh toán hóa đơn'
--7.Thêm tiền
Go
CREATE PROC CreateGiaoDichThem(@MaDG int, @LoaiGD NVARCHAR(50),@SoTien Money, @GhiChu NVARCHAR(255))
AS 
BEGIN
	DECLARE @SoDu MONEY
	SELECT @SoDu = SoDu FROM DocGia WHERE MaDG = @MaDG;
	--Kiểm tra nếu người dùng NULL trường số dư thì gán trường thành @SoTien
	IF @SoDu IS NULL
	BEGIN
	--thêm tiền trong tài khoản
	UPDATE DocGia
		SET SoDu = @SoTien
		WHERE MaDG = @MaDG;
		--Tạo giao dịch
		INSERT INTO GiaoDich(MaDG, LoaiGD,NgayGD, SoTien, GhiChu)
		VALUES(@MaDG, @LoaiGD,GETDATE(), @SoTien, @GhiChu);
	END
	ELSE 
	BEGIN
		UPDATE DocGia
		SET SoDu = @SoDu + @SoTien
		WHERE MaDG = @MaDG;
		--Tạo giao dịch
		INSERT INTO GiaoDich(MaDG, LoaiGD,NgayGD, SoTien, GhiChu)
		VALUES(@MaDG, @LoaiGD,GETDATE(),@SoTien, @GhiChu);
	END
END
EXEC CreateGiaoDichThem 1, N'Nạp tiền', 35000, N'Nạp tiền'
--Tự động khóa thẻ khi hết hạn MỖI KHI LOAD FORM
--8.kiểm tra và khóa các thẻ hết hạn

GO
CREATE PROCEDURE CheckAndLockExpiredCards
AS
BEGIN
    -- Cập nhật trạng thái của các thẻ hết hạn
    UPDATE TheDocGia
    SET TrangThai = N'Khóa'
    WHERE NgayHetHan < GETDATE();
    -- Thêm một dòng vào bảng LichSuDung cho mỗi thẻ vừa được khóa
    INSERT INTO LichSuDung(MaThe, HoatDong, LyDo, ThoiGian)
    SELECT MaThe, N'Khóa thẻ', N'Hết hạn', GETDATE()
    FROM TheDocGia
    WHERE TrangThai = N'Khóa';
END
exec CheckAndLockExpiredCards
--Xóa hoàn toàn một độc giả
-- 9.Tạo stored procedure để xóa một độc giả
GO
CREATE PROC DeleteReader(@MaDG INT)
AS
BEGIN
    -- Xóa thông tin độc giả từ bảng SinhVien, GiangVien, CanBo nếu có
    DELETE FROM SinhVien WHERE MaDG = @MaDG;
    DELETE FROM GiangVien WHERE MaDG = @MaDG;
    DELETE FROM CanBo WHERE MaDG = @MaDG;
	DELETE FROM GiaoDich WHERE MaDG = @MaDG;
    -- Xóa thẻ độc giả từ bảng TheDocGia
    DELETE FROM TheDocGia WHERE MaDG = @MaDG;

    -- Cuối cùng, xóa thông tin độc giả từ bảng DocGia
    DELETE FROM DocGia WHERE MaDG = @MaDG;
END
exec DeleteReader 7
--tìm kiếm tên loại độc giả dựa trên mã loại độc giả:
GO
CREATE PROC FindNameLDG(@loaiDG int)
AS
BEGIN
	SELECT TenLDG
	FROM LoaiDocGia
	WHERE MaLDG = @loaiDG;
END
EXEC FindNameLDG 2
--10.Lấy danh sách giao dịch tài chính của độc giả 
GO
CREATE PROC GetListGiaoDich(@MaDG int)
AS
BEGIN
	SELECT MaGD, LoaiGD,SoTien,GhiChu, NgayGD
	FROM GiaoDich
	WHERE MaDG = @MaDG;
END
EXEC GetListGiaoDich 3
--
GO
CREATE PROC GetDocGiaByDK(@DK NVARCHAR(255), @DuLieuDauVao NVARCHAR(255))
AS
BEGIN
	IF(@DK = N'Mã độc giả')
	BEGIN
		SELECT *FROM DocGia as DG
		left join CanBo CB on DG.MaDG = CB.MaDG
		left join GiangVien GV on DG.MaDG = GV.MADG
		left join SinhVien SV on DG.MaDG = SV.MaDG
		Where DG.MaDG = CAST(@DuLieuDauVao AS INT);
	END
	ELSE IF(@DK = N'Loại độc giả')
	BEGIN 
		SELECT *FROM DocGia  as DG
		left join CanBo CB on DG.MaDG = CB.MaDG
		left join GiangVien GV on DG.MaDG = GV.MADG
		left join SinhVien SV on DG.MaDG = SV.MaDG
		Where MaLDG = CAST(@DuLieuDauVao AS INT);
	END
	ELSE IF (@DK = N'Họ tên')
	BEGIN 
		SELECT *FROM DocGia as DG
		left join CanBo CB on DG.MaDG = CB.MaDG
		left join GiangVien GV on DG.MaDG = GV.MADG
		left join SinhVien SV on DG.MaDG = SV.MaDG
		WHERE HoTen = @DuLieuDauVao;
	END
	ELSE IF(@DK= N'Giới tính')
	BEGIN
		IF(@DuLieuDauVao =N'Nam')
		BEGIN 
			SELECT *FROM DocGia  as DG
			left join CanBo CB on DG.MaDG = CB.MaDG
			left join GiangVien GV on DG.MaDG = GV.MADG
			left join SinhVien SV on DG.MaDG = SV.MaDG
			WHERE GioiTinh = 1;
		END
		ELSE 
		BEGIN 
			SELECT *FROM DocGia  as DG
			left join CanBo CB on DG.MaDG = CB.MaDG
			left join GiangVien GV on DG.MaDG = GV.MADG
			left join SinhVien SV on DG.MaDG = SV.MaDG
			WHERE GioiTinh = 0;
		END
	END
	ELSE IF(@DK =N'Địa chỉ')
	BEGIN
		SELECT *FROM DocGia as DG
		left join CanBo CB on DG.MaDG = CB.MaDG
		left join GiangVien GV on DG.MaDG = GV.MADG
		left join SinhVien SV on DG.MaDG = SV.MaDG
		WHERE DiaChi = @DuLieuDauVao;
	END
	ELSE IF(@DK =N'Ngày sinh')
	BEGIN	
		SELECT *FROM DocGia as DG
		left join CanBo CB on DG.MaDG = CB.MaDG
		left join GiangVien GV on DG.MaDG = GV.MADG
		left join SinhVien SV on DG.MaDG = SV.MaDG
		WHERE NgaySinh = CAST(@DuLieuDauVao AS DATE);
	END
	ELSE IF(@DK = N'Số điện thoại')
	BEGIN
		SELECT *FROM DocGia as DG
		left join CanBo CB on DG.MaDG = CB.MaDG
		left join GiangVien GV on DG.MaDG = GV.MADG
		left join SinhVien SV on DG.MaDG = SV.MaDG
		WHERE SDT = CAST(@DuLieuDauVao AS varchar);
	END
	ELSE IF(@DK = N'Email')
	BEGIN
		SELECT *FROM DocGia as DG
		left join CanBo CB on DG.MaDG = CB.MaDG
		left join GiangVien GV on DG.MaDG = GV.MADG
		left join SinhVien SV on DG.MaDG = SV.MaDG
		WHERE Email = CAST(@DuLieuDauVao AS varchar);
	END
END

exec GetDocGiaByDK N'Ngày sinh', '1999-12-25'
--13.Lọc danh sách độc giả có thẻ và thẻ của họ
Go
CREATE PROCEDURE GetAllTheDG
AS
BEGIN
    SELECT
        T.maThe,
        T.maDG,
        T.trangThai,
        T.ngayDangKy,
        T.ngayHetHan,
        D.HoTen,
        D.NgaySinh,
        D.GioiTinh,
        D.DiaChi,
        D.Email,
        D.SDT,
        D.MaLDG
    FROM
        TheDocGia T
    INNER JOIN
        DocGia D ON T.maDG = D.maDG
    WHERE
        T.maDG IS NOT NULL; 
END
EXEC GetAllTheDG
--14.Tìm kiếm độc giả có thẻ
Go
CREATE PROC GetDocGiaByDKAndThe(@DK NVARCHAR(255), @DuLieuDauVao NVARCHAR(255))
AS
BEGIN
    CREATE TABLE #TempTable
    (
        maThe INT,
        maDG INT,
        trangThai NVARCHAR(255),
        ngayDangKy DATE,
        ngayHetHan DATE,
        HoTen NVARCHAR(255),
        NgaySinh DATE,
        GioiTinh BIT,
        DiaChi NVARCHAR(255),
        Email NVARCHAR(255),
        SDT NVARCHAR(255),
        MaLDG INT
    )

    INSERT INTO #TempTable
    EXEC GetAllTheDG

    IF(@DK = N'Mã độc giả')
    BEGIN
        SELECT * FROM #TempTable WHERE maDG = CAST(@DuLieuDauVao AS INT);
    END
    ELSE IF(@DK = N'Loại độc giả')
    BEGIN 
        SELECT * FROM #TempTable WHERE MaLDG = CAST(@DuLieuDauVao AS INT);
    END
    ELSE IF (@DK = N'Họ tên')
    BEGIN 
        SELECT * FROM #TempTable WHERE HoTen = @DuLieuDauVao;
    END
    ELSE IF(@DK= N'Giới tính')
    BEGIN
        IF(@DuLieuDauVao =N'Nam')
        BEGIN 
            SELECT * FROM #TempTable WHERE GioiTinh = 1;
        END
        ELSE 
        BEGIN 
            SELECT * FROM #TempTable WHERE GioiTinh = 0;
        END
    END
    ELSE IF(@DK =N'Địa chỉ')
    BEGIN
        SELECT * FROM #TempTable WHERE DiaChi = @DuLieuDauVao;
    END
    ELSE IF(@DK =N'Ngày sinh')
    BEGIN  
        SELECT * FROM #TempTable WHERE NgaySinh = CAST(@DuLieuDauVao AS DATE);
    END
    ELSE IF(@DK = N'Số điện thoại')
    BEGIN
        SELECT * FROM #TempTable WHERE SDT = CAST(@DuLieuDauVao AS varchar);
    END
    ELSE IF(@DK = N'Email')
    BEGIN
        SELECT * FROM #TempTable WHERE Email = CAST(@DuLieuDauVao AS varchar);
    END

    DROP TABLE #TempTable
END
EXEC GetDocGiaByDKAndThe N'Loại độc giả', 2
--15.Lấy lịch sử dùng thẻ
GO
CREATE PROC GetLichSuThe(@MaThe int)
AS
BEGIN
	SELECT *FROM LichSuDung WHERE MaThe = @MaThe;
END
exec GetLichSuThe 3
-- 16.Đăng ký độc giả là cán bộ
GO
create proc Insert_CanBo
@MaLDG int,
@Hoten nvarchar(255),
@NgaySinh date,
@GioiTinh bit, 
@DiaChi nvarchar(255),
@SDT varchar(10), 
@Email nvarchar(255),
@SoDu float,
@Fax nvarchar(50),
@BoPhan nvarchar(255)
as
begin
	declare @MaDG int
	insert into DocGia (MaLDG, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, Email, SoDu, Fax)
	values (@MaLDG, @Hoten, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email, @SoDu, @Fax)
	SET @MaDG = SCOPE_IDENTITY()

	insert into CanBo (MaDG, BoPhan)
	values (@MaDG, @BoPhan)
end
exec Insert_CanBo '1', 'Danh', '2003-11-2', '1', 'tp', '0123213', 'dsadas', '1231','123123','taichinh'

-- 17.Đăng ký độc giả là giảng viên
Go
create proc Insert_GiangVien
@MaLDG int,
@Hoten nvarchar(255),
@NgaySinh date,
@GioiTinh bit, 
@DiaChi nvarchar(255),
@SDT varchar(10), 
@Email nvarchar(255),
@SoDu float,
@Fax nvarchar(50),
@ChuyenMon nvarchar(255)
as
begin
	declare @MaDG int
	insert into DocGia (MaLDG, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, Email, SoDu, Fax)
	values (@MaLDG, @Hoten, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email, @SoDu, @Fax)
	SET @MaDG = SCOPE_IDENTITY()

	insert into GiangVien (MaDG, ChuyenMon)
	values (@MaDG, @ChuyenMon)
end
exec Insert_GiangVien '1', 'Danh', '2003-11-2', '1', 'tp', '0123213', 'dsadas', '1231','123123','taichinh'
-- 18.Thêm độc giả là sinh viên
GO
create proc Insert_SinhVien
@MaLDG int,
@Hoten nvarchar(255),
@NgaySinh date,
@GioiTinh bit, 
@DiaChi nvarchar(255),
@SDT varchar(10), 
@Email nvarchar(255),
@SoDu float,
@Fax nvarchar(50),
@Lop nvarchar(50), 
@NamHoc varchar(10)
as
begin
	declare @MaDG int
	insert into DocGia (MaLDG, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, Email, SoDu, Fax)
	values (@MaLDG, @Hoten, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email, @SoDu, @Fax)
	SET @MaDG = SCOPE_IDENTITY()

	insert into SinhVien(MaDG, Lop, NamHoc)
	values (@MaDG, @Lop, @NamHoc)
end
exec Insert_SinhVien'1', 'Danh', '2003-11-2', '1', 'tp', '0123213', 'dsadas', '1231','123123','taichinh', '2021'
--Thêm thẻ độc giả
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddDocGia]
    @TenDocGia NVARCHAR(255),
    @DiaChi NVARCHAR(255),
    @GioiTinh BIT,
    @NgaySinh DATE,
    @Email NVARCHAR(255),
    @SoDT NVARCHAR(10),
    @LoaiDocGia INT,
	@Fax NVARCHAR(10) = NULL,
    @Lop NVARCHAR(255) = NULL,
    @NamHoc INT = NULL,
    @BoPhan NVARCHAR(255) = NULL,
    @ChuyenMon NVARCHAR(255) = NULL
AS
BEGIN
    DECLARE @MaDocGia INT

    -- Thêm độc giả mới
    INSERT INTO DocGia(HoTen,MaLDG, DiaChi, GioiTinh, NgaySinh, Email, SDT,Fax)
    VALUES (@TenDocGia,@LoaiDocGia, @DiaChi, @GioiTinh, @NgaySinh, @Email, @SoDT, @Fax)

    -- Lấy mã độc giả vừa được tạo
    SET @MaDocGia = SCOPE_IDENTITY()

    -- Thêm thông tin chi tiết cho độc giả dựa trên loại độc giả
    IF @LoaiDocGia = 1
    BEGIN
        INSERT INTO SinhVien(MaDG,  Lop, NamHoc)
        VALUES (@MaDocGia, @Lop, @NamHoc)
    END
    ELSE IF @LoaiDocGia = 2
    BEGIN
        INSERT INTO CanBo(MaDG, BoPhan)
        VALUES (@MaDocGia, @BoPhan)
    END
    ELSE IF @LoaiDocGia = 3
    BEGIN
        INSERT INTO GiangVien(MaDG, ChuyenMon)
        VALUES (@MaDocGia, @ChuyenMon)
    END

    -- Gọi stored procedure AddCard để tạo thẻ độc giả
    EXEC AddCard @MaDocGia
END
GO
--Tung insert docgia
go
CREATE PROCEDURE pc_insert_docgia
(
	@MaLDG int,
	@HoTen nvarchar(255),
	@NgaySinh date,
	@GioiTinh bit,
	@DiaChi nvarchar(255),
	@SDT varchar(10),
	@Email varchar(255),
	@SoDu float
)
AS 
BEGIN
	INSERT INTO DocGia (MaLDG, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, Email, SoDu)
	VALUES (@MaLDG, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email, @SoDu)
END
--Tong Giao dich
go
create procedure pc_Tongtien_GD
as
select sum(SoTien) as TongTienGD
from GiaoDich
--Tong Soluong GD
go 
create procedure pc_Soluong_GD
as
select count(MaDG) as TongLuongGD
from GiaoDich
--Lay toan bo loai Giao Dich
go
create procedure pc_LoaiGiaoDich
as
select distinct LoaiGD
from GiaoDich
--Lay Ngay GD
go
create proc pc_NgayGD
as
select distinct NgayGD from GiaoDich
--Tim Theo NgayGD
go
create procedure pc_Find_NgayGD
(
	@NgayGD date
)
as
begin
select *
from GiaoDich
where NgayGD = @NgayGD
end
--Tim theo loai GD
go
create procedure pc_Find_LoaiGD
(
	@LoaiGD nvarchar(50)
)
as
begin
select *
from GiaoDich
where LoaiGD = @LoaiGD
end
exec pc_Find_LoaiGD N'Đền bù'
SET IDENTITY_INSERT [dbo].[CanBo] ON 

INSERT [dbo].[CanBo] ([MaCB], [MaDG], [BoPhan]) VALUES (1, 7, N'Quản lý tài nguyên nhân lực')
INSERT [dbo].[CanBo] ([MaCB], [MaDG], [BoPhan]) VALUES (2, 8, N'Trợ lý hành chính')
INSERT [dbo].[CanBo] ([MaCB], [MaDG], [BoPhan]) VALUES (3, 3, N'Thư ký ban giám đốc')
INSERT [dbo].[CanBo] ([MaCB], [MaDG], [BoPhan]) VALUES (4, 11, N'Quản lý tài chính')
INSERT [dbo].[CanBo] ([MaCB], [MaDG], [BoPhan]) VALUES (5, 17, N'Trợ lý hành chính')
INSERT [dbo].[CanBo] ([MaCB], [MaDG], [BoPhan]) VALUES (6, 20, N'Trợ lý điều hành')
SET IDENTITY_INSERT [dbo].[CanBo] OFF
GO


SET IDENTITY_INSERT [dbo].[DocGia] ON 

INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (1, 1, N'Nguyễn Tấn Hữu Danh', CAST(N'2003-11-02' AS Date), 1, N'Hẻm 48, Đường số 1, Gò Vấp', N'0987421413', N'nguyentanhuudanh@gmail.com', 1200000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (2, 2, N'Trần Thị Hương Giang', CAST(N'2000-05-15' AS Date), 0, N'123 Điện Biên Phủ, Quận 1, TP.HCM', N'0909123456', N'gianght@gmail.com', 500000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (3, 1, N'Lê Văn Nam', CAST(N'1998-08-20' AS Date), 1, N'15 Lê Lợi, Quận 3, TP.HCM', N'0123456789', N'namlv@gmail.com', 700000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (4, 2, N'Phạm Thị Thu Hà', CAST(N'2001-03-10' AS Date), 0, N'37 Nguyễn Du, Quận 5, TP.HCM', N'0978123456', N'haptt@gmail.com', 900000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (5, 1, N'Nguyễn Văn Bình', CAST(N'1999-12-25' AS Date), 1, N'100 Trần Hưng Đạo, Quận 10, TP.HCM', N'0988888888', N'binhnv@gmail.com', 600000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (6, 2, N'Trần Văn Tuấn', CAST(N'2002-06-30' AS Date), 1, N'50 Lê Thánh Tôn, Quận 1, TP.HCM', N'0909777777', N'tuanvt@gmail.com', 800000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (7, 3, N'Nguyễn Thị Mai', CAST(N'1997-04-05' AS Date), 0, N'28 Phan Kế Bính, Quận 1, TP.HCM', N'0910111222', N'maint@gmail.com', 1100000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (8, 3, N'Lê Thị Thảo', CAST(N'2004-02-18' AS Date), 0, N'75 Nguyễn Bỉnh Khiêm, Quận 2, TP.HCM', N'0987654321', N'thaolt@gmail.com', 300000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (9, 1, N'Trần Văn An', CAST(N'1995-09-12' AS Date), 1, N'29 Trường Sơn, Quận Tân Bình, TP.HCM', N'0903456789', N'antran@gmail.com', 950000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (10, 2, N'Nguyễn Thị Bích Phượng', CAST(N'2000-11-03' AS Date), 0, N'14 Lê Duẩn, Quận 1, TP.HCM', N'0905555555', N'phuongntb@gmail.com', 720000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (11, 3, N'Lê Thị Hà', CAST(N'1999-07-14' AS Date), 0, N'45 Nguyễn Văn Cừ, Quận 4, TP.HCM', N'0977777777', N'hale@gmail.com', 600000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (12, 1, N'Nguyễn Văn Nam', CAST(N'1998-04-09' AS Date), 1, N'22 Phan Văn Trị, Gò Vấp, TP.HCM', N'0912345678', N'namnvn@gmail.com', 850000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (13, 2, N'Lê Văn Phúc', CAST(N'2005-01-20' AS Date), 1, N'123 Trường Chinh, Tân Phú, TP.HCM', N'0901234567', N'phuclv@gmail.com', 1050000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (14, 3, N'Nguyễn Thị Thùy Linh', CAST(N'2001-08-12' AS Date), 0, N'56 Bình Thạnh, Quận Bình Thạnh, TP.HCM', N'0988888888', N'linhntt@gmail.com', 480000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (15, 1, N'Trần Văn Long', CAST(N'2003-03-25' AS Date), 1, N'37 Nguyễn Hữu Cảnh, Quận Bình Thạnh, TP.HCM', N'0905678901', N'longtv@gmail.com', 750000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (16, 2, N'Phạm Thị Thúy', CAST(N'1996-06-29' AS Date), 0, N'88 Hoàng Sa, Quận 3, TP.HCM', N'0978888888', N'thuypt@gmail.com', 650000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (17, 3, N'Lê Văn Đức', CAST(N'2002-09-15' AS Date), 1, N'10 Võ Văn Tần, Quận 3, TP.HCM', N'0915678901', N'duclv@gmail.com', 820000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (18, 1, N'Nguyễn Thị Kim Anh', CAST(N'2000-11-21' AS Date), 0, N'30 Lê Quý Đôn, Quận 3, TP.HCM', N'0903333333', N'kimanhnt@gmail.com', 900000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (19, 2, N'Trần Văn Đông', CAST(N'1997-12-10' AS Date), 1, N'44 Đinh Công Tráng, Quận 1, TP.HCM', N'0977777777', N'dongtv@gmail.com', 700000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (20, 3, N'Lê Thị Hồng', CAST(N'1998-02-03' AS Date), 0, N'5 Lê Bình, Quận Bình Thạnh, TP.HCM', N'0911111111', N'honglt@gmail.com', 580000)
INSERT [dbo].[DocGia] ([MaDG], [MaLDG], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Email], [SoDu]) VALUES (21, 1, N'Danh', CAST(N'2003-11-02' AS Date), 1, N'tp', N'0123213', N'dsadas', 1231)
SET IDENTITY_INSERT [dbo].[DocGia] OFF
GO
SET IDENTITY_INSERT [dbo].[GiangVien] ON 

INSERT [dbo].[GiangVien] ([MaGV], [MADG], [ChuyenMon]) VALUES (1, 2, N'Khoa học máy tính')
INSERT [dbo].[GiangVien] ([MaGV], [MADG], [ChuyenMon]) VALUES (2, 4, N'Khoa học kinh doanh')
INSERT [dbo].[GiangVien] ([MaGV], [MADG], [ChuyenMon]) VALUES (3, 6, N'Sinh học')
INSERT [dbo].[GiangVien] ([MaGV], [MADG], [ChuyenMon]) VALUES (4, 10, N'Kỹ thuật điện tử')
INSERT [dbo].[GiangVien] ([MaGV], [MADG], [ChuyenMon]) VALUES (5, 13, N'Ngôn ngữ học')
INSERT [dbo].[GiangVien] ([MaGV], [MADG], [ChuyenMon]) VALUES (6, 16, N'Hóa học')
INSERT [dbo].[GiangVien] ([MaGV], [MADG], [ChuyenMon]) VALUES (7, 19, N'Toán học')
SET IDENTITY_INSERT [dbo].[GiangVien] OFF
GO
SET IDENTITY_INSERT [dbo].[GiaoDich] ON 

INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (1, 1, N'Mở thẻ', CAST(1000000 AS Decimal(18, 0)), NULL, N'Mở thẻ cho thành viên mới')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (2, 2, N'Nộp phạt', CAST(50000 AS Decimal(18, 0)), NULL, N'Nộp phạt vi phạm quy định')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (3, 1, N'Rút tiền', CAST(200000 AS Decimal(18, 0)), NULL, N'Rút tiền từ tài khoản')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (4, 5, N'Đền bù', CAST(30000 AS Decimal(18, 0)), NULL, N'Đền bù sách mất')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (5, 3, N'Nạp Tiền', CAST(1500000 AS Decimal(18, 0)), NULL, N'Nạp tiền vào tài khoản')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (6, 4, N'Mở thẻ', CAST(800000 AS Decimal(18, 0)), NULL, N'Mở thẻ cho thành viên mới')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (7, 6, N'Nộp phạt', CAST(100000 AS Decimal(18, 0)), NULL, N'Nộp phạt vi phạm quy định')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (8, 8, N'Rút tiền', CAST(300000 AS Decimal(18, 0)), NULL, N'Rút tiền từ tài khoản')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (9, 7, N'Đền bù', CAST(50000 AS Decimal(18, 0)), NULL, N'Đền bù sách mất')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (10, 9, N'Nạp tiền', CAST(2000000 AS Decimal(18, 0)), NULL, N'Nạp tiền vào tài khoản')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (11, 10, N'Mở thẻ', CAST(700000 AS Decimal(18, 0)), NULL, N'Mở thẻ cho thành viên mới')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (12, 11, N'Nộp phạt', CAST(80000 AS Decimal(18, 0)), NULL, N'Nộp phạt vi phạm quy định')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (13, 12, N'Rút tiền', CAST(400000 AS Decimal(18, 0)), NULL, N'Rút tiền từ tài khoản')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (14, 13, N'Đền Bù', CAST(60000 AS Decimal(18, 0)), NULL, N'Đền bù sách mất')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (15, 14, N'Nạp Tiền', CAST(2500000 AS Decimal(18, 0)), NULL, N'Nạp tiền vào tài khoản')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (16, 15, N'Mở thẻ', CAST(900000 AS Decimal(18, 0)), NULL, N'Mở thẻ cho thành viên mới')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (17, 15, N'Nộp phạt', CAST(70000 AS Decimal(18, 0)), NULL, N'Nộp phạt vi phạm quy định')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (18, 16, N'Rút tiền', CAST(500000 AS Decimal(18, 0)), NULL, N'Rút tiền từ tài khoản')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (19, 17, N'Đền Bù', CAST(70000 AS Decimal(18, 0)), NULL, N'Đền bù sách mất')
INSERT [dbo].[GiaoDich] ([MaGD], [MaDG], [LoaiGD], [SoTien], [NgayGD], [GhiChu]) VALUES (20, 20, N'Nạp Tiền', CAST(3000000 AS Decimal(18, 0)), NULL, N'Nạp tiền vào tài khoản')
SET IDENTITY_INSERT [dbo].[GiaoDich] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiDocGia] ON 

INSERT [dbo].[LoaiDocGia] ([MaLDG], [TenLDG]) VALUES (1, N'Sinh viên')
INSERT [dbo].[LoaiDocGia] ([MaLDG], [TenLDG]) VALUES (2, N'Giảng viên')
INSERT [dbo].[LoaiDocGia] ([MaLDG], [TenLDG]) VALUES (3, N'Cán bộ')
SET IDENTITY_INSERT [dbo].[LoaiDocGia] OFF
GO
SET IDENTITY_INSERT [dbo].[SinhVien] ON 

INSERT [dbo].[SinhVien] ([MaSV], [MaDG], [Lop], [NamHoc]) VALUES (1, 1, N'12DHTH_TD', N'2021-2025')
INSERT [dbo].[SinhVien] ([MaSV], [MaDG], [Lop], [NamHoc]) VALUES (2, 3, N'12DHTH_TD', N'2021-2025')
INSERT [dbo].[SinhVien] ([MaSV], [MaDG], [Lop], [NamHoc]) VALUES (3, 5, N'12DHTH1', N'2021-2025')
INSERT [dbo].[SinhVien] ([MaSV], [MaDG], [Lop], [NamHoc]) VALUES (4, 9, N'12DHTH2', N'2021-2025')
INSERT [dbo].[SinhVien] ([MaSV], [MaDG], [Lop], [NamHoc]) VALUES (5, 12, N'12DHTH2', N'2021-2025')
INSERT [dbo].[SinhVien] ([MaSV], [MaDG], [Lop], [NamHoc]) VALUES (6, 15, N'12DHTH_14', N'2021-2025')
INSERT [dbo].[SinhVien] ([MaSV], [MaDG], [Lop], [NamHoc]) VALUES (7, 18, N'12DHTH_15', N'2021-2025')
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
GO
-- Tan
-- Tim ma doc gia
create proc FindMaDG @MaDG int
as
begin
	select *from DocGia where MaDG = @MaDG;
end
--Danh DB
-- Update SV
Go
create proc UpdateSinhVien
@MaDG  int,
@Hoten nvarchar(255),
@NgaySinh date,
@GioiTinh bit, 
@DiaChi nvarchar(255),
@SDT varchar(10), 
@Email nvarchar(255),
@Fax nvarchar(50),
@Lop nvarchar(50), 
@NamHoc varchar(10)
as
begin
	update SinhVien set Lop = @Lop, NamHoc = @NamHoc where MaDG = @MaDG
	update DocGia set HoTen = @Hoten, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, 
	DiaChi = @DiaChi, SDT = @SDT, Email = @Email, Fax = @Fax where MaDG = @MaDG
end
Go
CREATE PROC GetListGiaoDich(@MaDG int)
AS
BEGIN
	SELECT MaGD, LoaiGD,SoTien,GhiChu, NgayGD
	FROM GiaoDich
	WHERE MaDG = @MaDG;
END
select * from TheDocGia
go
CREATE PROC GetMaDocGiaFromTheDocGia
AS
BEGIN
    SELECT DISTINCT MaDG
    FROM TheDocGia
END
