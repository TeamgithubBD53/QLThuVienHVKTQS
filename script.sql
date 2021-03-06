USE [master]
GO
/****** Object:  Database [QuanLyThuVienHVKTQS]    Script Date: 12/15/2017 11:56:28 AM ******/
CREATE DATABASE [QuanLyThuVienHVKTQS]
 
ALTER DATABASE [QuanLyThuVienHVKTQS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVienHVKTQS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyThuVienHVKTQS]
GO
/****** Object:  Table [dbo].[docgia]    Script Date: 12/15/2017 11:56:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[docgia](
	[sothe] [int] NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[email] [varchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [nchar](10) NULL,
	[diachi] [nvarchar](50) NULL,
	[socmtnd] [varchar](50) NULL,
	[anhthe] [varchar](50) NULL,
	[ngaylamthe] [date] NULL,
	[handungthe] [date] NULL,
 CONSTRAINT [PK_docgia] PRIMARY KEY CLUSTERED 
(
	[sothe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MuonSach]    Script Date: 12/15/2017 11:56:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuonSach](
	[Mamuon] [int] IDENTITY(1,1) NOT NULL,
	[sothe] [int] NOT NULL,
	[masach] [int] NOT NULL,
	[soluong] [int] NULL,
	[ngaymuon] [date] NULL CONSTRAINT [DF_MuonSach_ngaymuon]  DEFAULT (getdate()),
	[hantra] [date] NULL,
	[manv] [int] NOT NULL,
 CONSTRAINT [PK_MuonSach] PRIMARY KEY CLUSTERED 
(
	[Mamuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 12/15/2017 11:56:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manv] [int] IDENTITY(1,1) NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[sdt] [varchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [nchar](10) NULL,
	[diachi] [nvarchar](50) NULL,
	[socmtnd] [varchar](50) NULL,
	[anh] [varchar](50) NULL,
	[quyenhan] [varchar](50) NULL,
	[matkhau] [varchar](50) NULL,
	[note] [nvarchar](250) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhaxuatban]    Script Date: 12/15/2017 11:56:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhaxuatban](
	[manxb] [int] IDENTITY(1,1) NOT NULL,
	[tennxb] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [varchar](50) NULL,
 CONSTRAINT [PK_nhaxuatban] PRIMARY KEY CLUSTERED 
(
	[manxb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sach]    Script Date: 12/15/2017 11:56:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sach](
	[masach] [int] NOT NULL,
	[tensach] [nvarchar](150) NULL,
	[tentacgia] [nvarchar](150) NULL,
	[manxb] [int] NULL,
	[giatien] [decimal](18, 0) NULL,
	[soluong] [int] NULL,
	[ngonngu] [nvarchar](50) NULL,
	[sotrang] [int] NULL,
	[namxb] [int] NULL,
	[theloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_sach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 12/15/2017 11:56:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](32) NOT NULL,
	[IsAdmin] [bit] NULL CONSTRAINT [DF_User_IsAdmin]  DEFAULT ((0)),
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[docgia] ([sothe], [hoten], [email], [ngaysinh], [gioitinh], [diachi], [socmtnd], [anhthe], [ngaylamthe], [handungthe]) VALUES (128156, N'Đỗ Tiến Đạt', N'dodat1@gmail.com', CAST(N'1996-12-02' AS Date), N'Nam       ', N'BN', N'123645489', NULL, CAST(N'2015-03-03' AS Date), CAST(N'2020-03-03' AS Date))
INSERT [dbo].[docgia] ([sothe], [hoten], [email], [ngaysinh], [gioitinh], [diachi], [socmtnd], [anhthe], [ngaylamthe], [handungthe]) VALUES (1212015, N'Nguyễn Hoàng Hải', N'hai167@gmail.com', CAST(N'1996-07-16' AS Date), N'Nam       ', N'TH50', N'163159456', NULL, CAST(N'2015-01-03' AS Date), CAST(N'2020-01-03' AS Date))
INSERT [dbo].[docgia] ([sothe], [hoten], [email], [ngaysinh], [gioitinh], [diachi], [socmtnd], [anhthe], [ngaylamthe], [handungthe]) VALUES (1222015, N'Phạm Ngọc Dũng', N'dung123@gmail.com', CAST(N'1996-12-04' AS Date), N'Nam       ', N'TH50', N'164159436', NULL, CAST(N'2015-01-03' AS Date), CAST(N'2020-01-03' AS Date))
INSERT [dbo].[docgia] ([sothe], [hoten], [email], [ngaysinh], [gioitinh], [diachi], [socmtnd], [anhthe], [ngaylamthe], [handungthe]) VALUES (1282015, N'Vương Thị Lê', N'le123@gmail.com', CAST(N'1996-05-13' AS Date), N'Nữ        ', N'TH50', N'163456128', NULL, CAST(N'2015-02-13' AS Date), CAST(N'2020-02-13' AS Date))
SET IDENTITY_INSERT [dbo].[MuonSach] ON 

INSERT [dbo].[MuonSach] ([Mamuon], [sothe], [masach], [soluong], [ngaymuon], [hantra], [manv]) VALUES (1, 128156, 1, 1, CAST(N'2017-10-02' AS Date), CAST(N'2018-01-02' AS Date), 1)
INSERT [dbo].[MuonSach] ([Mamuon], [sothe], [masach], [soluong], [ngaymuon], [hantra], [manv]) VALUES (2, 128156, 12333, 2, CAST(N'2017-11-15' AS Date), CAST(N'2018-02-03' AS Date), 2)
INSERT [dbo].[MuonSach] ([Mamuon], [sothe], [masach], [soluong], [ngaymuon], [hantra], [manv]) VALUES (4, 1212015, 12336, 1, CAST(N'2017-11-15' AS Date), CAST(N'2018-02-03' AS Date), 2)
INSERT [dbo].[MuonSach] ([Mamuon], [sothe], [masach], [soluong], [ngaymuon], [hantra], [manv]) VALUES (5, 1222015, 12336, 4, CAST(N'2017-12-16' AS Date), CAST(N'2018-03-16' AS Date), 1)
INSERT [dbo].[MuonSach] ([Mamuon], [sothe], [masach], [soluong], [ngaymuon], [hantra], [manv]) VALUES (9, 1222015, 12335, 1, CAST(N'2017-12-16' AS Date), CAST(N'2018-03-16' AS Date), 1)
INSERT [dbo].[MuonSach] ([Mamuon], [sothe], [masach], [soluong], [ngaymuon], [hantra], [manv]) VALUES (11, 1282015, 2, 5, CAST(N'2017-11-15' AS Date), CAST(N'2018-04-15' AS Date), 2)
SET IDENTITY_INSERT [dbo].[MuonSach] OFF
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [ngaysinh], [gioitinh], [diachi], [socmtnd], [anh], [quyenhan], [matkhau], [note]) VALUES (1, N'Nguyễn Văn Nam', N'0325545465', CAST(N'1990-12-02' AS Date), NULL, N'HN', N'116655454', NULL, N'admin', NULL, NULL)
INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [ngaysinh], [gioitinh], [diachi], [socmtnd], [anh], [quyenhan], [matkhau], [note]) VALUES (2, N'Trần Thu Hằng', N'0151561560', CAST(N'1988-02-15' AS Date), N'Nữ        ', N'HN', N'015465445', NULL, N'', NULL, NULL)
INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [ngaysinh], [gioitinh], [diachi], [socmtnd], [anh], [quyenhan], [matkhau], [note]) VALUES (4, N'Nguyễn Văn hòa', N'0325545465', CAST(N'1990-12-02' AS Date), N'Nam       ', N'HN', N'116655454', NULL, N'admin', NULL, NULL)
INSERT [dbo].[nhanvien] ([manv], [tennv], [sdt], [ngaysinh], [gioitinh], [diachi], [socmtnd], [anh], [quyenhan], [matkhau], [note]) VALUES (5, N'Đỗ Thị Thu Hòa', N'016865665', CAST(N'1983-03-16' AS Date), N'Nữ        ', N'HN', N'165163158', NULL, N'admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
SET IDENTITY_INSERT [dbo].[nhaxuatban] ON 

INSERT [dbo].[nhaxuatban] ([manxb], [tennxb], [diachi], [sdt]) VALUES (1, N'Nhà xuất bản Thanh niên', N'HN', N'08645434')
INSERT [dbo].[nhaxuatban] ([manxb], [tennxb], [diachi], [sdt]) VALUES (2, N'Nhà xuất bản ĐHQG Hà Nội', N'HCM', N'06856463')
INSERT [dbo].[nhaxuatban] ([manxb], [tennxb], [diachi], [sdt]) VALUES (4, N'Nhà xuất bản Kim Đồng', N'HCM', N'04436546')
INSERT [dbo].[nhaxuatban] ([manxb], [tennxb], [diachi], [sdt]) VALUES (5, N'Nhà xuất bản Chính trị quốc gia', N'HN', N'06666888')
INSERT [dbo].[nhaxuatban] ([manxb], [tennxb], [diachi], [sdt]) VALUES (7, N'Nhà xuất bản Khoa học và kỹ thuật', N'HH', N'02212156')
INSERT [dbo].[nhaxuatban] ([manxb], [tennxb], [diachi], [sdt]) VALUES (8, N'Nhà xuất bản Thời Đại', N'HN', N'02132132')
SET IDENTITY_INSERT [dbo].[nhaxuatban] OFF
INSERT [dbo].[sach] ([masach], [tensach], [tentacgia], [manxb], [giatien], [soluong], [ngonngu], [sotrang], [namxb], [theloai]) VALUES (1, N'3DS Max-Thủ Thuật Render Phối Cảnh kiến Trúc Ban Ngày Và Đêm Với V-Ray 1.50 RC3', N'abc', 1, CAST(20000 AS Decimal(18, 0)), 12, N'', 120, 2017, N'đồ họa')
INSERT [dbo].[sach] ([masach], [tensach], [tentacgia], [manxb], [giatien], [soluong], [ngonngu], [sotrang], [namxb], [theloai]) VALUES (2, N'Tự Học InDesign CS3', N'ads', 2, CAST(50000 AS Decimal(18, 0)), 12, N'Tiếng Anh', 110, 2016, N'designer')
INSERT [dbo].[sach] ([masach], [tensach], [tentacgia], [manxb], [giatien], [soluong], [ngonngu], [sotrang], [namxb], [theloai]) VALUES (3, N'qwe', N'qwedsvsdf', 2, NULL, NULL, N'', NULL, NULL, N'')
INSERT [dbo].[sach] ([masach], [tensach], [tentacgia], [manxb], [giatien], [soluong], [ngonngu], [sotrang], [namxb], [theloai]) VALUES (4, N'qwe1', N'qwedsvsdf', 1, NULL, NULL, N'', NULL, NULL, N'')
INSERT [dbo].[sach] ([masach], [tensach], [tentacgia], [manxb], [giatien], [soluong], [ngonngu], [sotrang], [namxb], [theloai]) VALUES (12333, N'English File', N'Thu Huyền', 8, CAST(75000 AS Decimal(18, 0)), 20, N'Tiếng Anh', 210, 2014, N'Ngoại ngữ')
INSERT [dbo].[sach] ([masach], [tensach], [tentacgia], [manxb], [giatien], [soluong], [ngonngu], [sotrang], [namxb], [theloai]) VALUES (12335, N'Giáo trình lịch sử Đảng', N'Lê Hậu Mãn', 5, CAST(30000 AS Decimal(18, 0)), 40, N'Tiếng Việt', 300, 2002, N'Lịch sử')
INSERT [dbo].[sach] ([masach], [tensach], [tentacgia], [manxb], [giatien], [soluong], [ngonngu], [sotrang], [namxb], [theloai]) VALUES (12336, N'Công nghệ phần mềm', N'Lê Đức Trung', 7, CAST(80000 AS Decimal(18, 0)), 10, N'Tiếng Việt', 200, 2010, N'Công nghệ thông tin')
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [UserName], [Password], [IsAdmin]) VALUES (1, N'admin', N'admin', 1)
--INSERT [dbo].[User] ([ID], [UserName], [Password], [IsAdmin]) VALUES (2, N'dat', N'1', 1)
--INSERT [dbo].[User] ([ID], [UserName], [Password], [IsAdmin]) VALUES (3, N'bao', N'1', 0)
--INSERT [dbo].[User] ([ID], [UserName], [Password], [IsAdmin]) VALUES (4, N'my', N'1', 1)
--INSERT [dbo].[User] ([ID], [UserName], [Password], [IsAdmin]) VALUES (8, N'hanh', N'1', 0)
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD  CONSTRAINT [FK_MuonSach_docgia] FOREIGN KEY([sothe])
REFERENCES [dbo].[docgia] ([sothe])
GO
ALTER TABLE [dbo].[MuonSach] CHECK CONSTRAINT [FK_MuonSach_docgia]
GO
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD  CONSTRAINT [FK_MuonSach_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[MuonSach] CHECK CONSTRAINT [FK_MuonSach_nhanvien]
GO
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD  CONSTRAINT [FK_MuonSach_sach1] FOREIGN KEY([masach])
REFERENCES [dbo].[sach] ([masach])
GO
ALTER TABLE [dbo].[MuonSach] CHECK CONSTRAINT [FK_MuonSach_sach1]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_nhaxuatban] FOREIGN KEY([manxb])
REFERENCES [dbo].[nhaxuatban] ([manxb])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_nhaxuatban]
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET  READ_WRITE 
GO
