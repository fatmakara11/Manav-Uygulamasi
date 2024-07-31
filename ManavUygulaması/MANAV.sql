USE [Stok_Takip]
GO
/****** Object:  Table [dbo].[müşteri]    Script Date: 8.01.2024 17:39:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[müşteri](
	[adsoyad] [nchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[adres] [nchar](50) NOT NULL,
	[email] [nchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelGirisTablosu]    Script Date: 8.01.2024 17:39:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelGirisTablosu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MailAdress] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_PersonelGirisTablosu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satis]    Script Date: 8.01.2024 17:39:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satis](
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[barkodno] [nvarchar](50) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[miktari] [int] NOT NULL,
	[satisfiyati] [decimal](18, 2) NOT NULL,
	[toplamfiyati] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sepet]    Script Date: 8.01.2024 17:39:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sepet](
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[barkodno] [nvarchar](50) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[miktari] [int] NOT NULL,
	[satisfiyati] [decimal](18, 2) NOT NULL,
	[toplamfiyati] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urun]    Script Date: 8.01.2024 17:39:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urun](
	[barkodno] [nvarchar](50) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[miktari] [nvarchar](50) NOT NULL,
	[satisfiyati] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[müşteri] ([adsoyad], [telefon], [adres], [email]) VALUES (N'                                                  ', N'', N'                                                  ', N'                                                  ')
GO
INSERT [dbo].[müşteri] ([adsoyad], [telefon], [adres], [email]) VALUES (N'enes kaan                                         ', N'654365432', N'jhgfxz                                            ', N'hgfdsa                                            ')
GO
INSERT [dbo].[müşteri] ([adsoyad], [telefon], [adres], [email]) VALUES (N'nisa ekiz                                         ', N'6543276543', N'jhgfds                                            ', N'jhgfdsa                                           ')
GO
INSERT [dbo].[müşteri] ([adsoyad], [telefon], [adres], [email]) VALUES (N'şevin arslan                                      ', N'05508328484', N'İzmir konak                                       ', N'sevınarslan@gmail.com                             ')
GO
INSERT [dbo].[müşteri] ([adsoyad], [telefon], [adres], [email]) VALUES (N'fatmanur bürkük                                   ', N'05324564232', N'bingöl                                            ', N'ftmbrk@gmail.com                                  ')
GO
INSERT [dbo].[müşteri] ([adsoyad], [telefon], [adres], [email]) VALUES (N'fhdkfdsdfs                                        ', N'asdfghjk', N'asdfghj                                           ', N'asdfghjkl                                         ')
GO
INSERT [dbo].[müşteri] ([adsoyad], [telefon], [adres], [email]) VALUES (N'fatma kara                                        ', N'05375111732', N'afşin                                             ', N'fghjklş                                           ')
GO
INSERT [dbo].[müşteri] ([adsoyad], [telefon], [adres], [email]) VALUES (N'Zeynep Kara                                       ', N'029282772', N'Kahramanmaraş                                     ', N'adsff@gmail.com                                   ')
GO
SET IDENTITY_INSERT [dbo].[PersonelGirisTablosu] ON 
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (2, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (3, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (4, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (5, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (6, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (7, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (8, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (9, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (10, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (11, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (12, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (13, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (14, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (15, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (16, N'fatmaka646@hotmail.com', N'9726')
GO
INSERT [dbo].[PersonelGirisTablosu] ([id], [MailAdress], [Password]) VALUES (17, N'fatmaka646@hotmail.com', N'9726')
GO
SET IDENTITY_INSERT [dbo].[PersonelGirisTablosu] OFF
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'fatma kara', N' 05375111732', N'001', N'Çilek', 20, CAST(30.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), N'31.12.2023 13:29:41')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'', N' ', N'001', N'Çilek', 20, CAST(30.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), N'31.12.2023 13:31:37')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'', N' ', N'001', N'Çilek', 20, CAST(30.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), N'31.12.2023 13:34:10')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'', N' ', N'002', N'Muz', 1, CAST(32.00 AS Decimal(18, 2)), CAST(32.00 AS Decimal(18, 2)), N'31.12.2023 13:34:27')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'', N' ', N'003', N'Domates', 20, CAST(8.00 AS Decimal(18, 2)), CAST(160.00 AS Decimal(18, 2)), N'31.12.2023 13:35:45')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'elif kara', N' 34567890*', N'001', N'Çilek', 12, CAST(30.00 AS Decimal(18, 2)), CAST(360.00 AS Decimal(18, 2)), N'3.01.2024 13:35:49')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'elif kara', N' 34567890*', N'002', N'Muz', 5, CAST(32.00 AS Decimal(18, 2)), CAST(160.00 AS Decimal(18, 2)), N'3.01.2024 13:35:49')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'ömer kara', N'05324562323', N'004', N'Biber', 30, CAST(22.00 AS Decimal(18, 2)), CAST(660.00 AS Decimal(18, 2)), N'6.01.2024 15:45:31')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'kerem han ', N' 05325672424', N'002', N'Muz', 10, CAST(32.00 AS Decimal(18, 2)), CAST(320.00 AS Decimal(18, 2)), N'6.01.2024 15:57:53')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'kerem han ', N' 05325672424', N'003', N'Domates', 5, CAST(8.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), N'6.01.2024 15:57:53')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'derya acerce', N' 05242552525', N'006', N'vişne', 10, CAST(14.00 AS Decimal(18, 2)), CAST(140.00 AS Decimal(18, 2)), N'6.01.2024 18:05:19')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'derya acerce', N' 05242552525', N'001', N'Çilek', 5, CAST(30.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), N'6.01.2024 18:05:19')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'burak yeşilkaya', N'05434344343', N'007', N'Dalbastı', 50, CAST(12.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), N'7.01.2024 13:56:56')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'burak yeşilkaya', N'05434344343', N'001', N'Çilek', 3, CAST(30.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), N'7.01.2024 13:56:56')
GO
INSERT [dbo].[satis] ([adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'', N' ', N'001', N'Çilek', 1, CAST(30.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), N'7.01.2024 22:40:30')
GO
INSERT [dbo].[urun] ([barkodno], [urunadi], [miktari], [satisfiyati], [tarih]) VALUES (N'001', N'Çilek', N'68111', CAST(30.00 AS Decimal(18, 2)), N'31.12.2023 13:27:36')
GO
INSERT [dbo].[urun] ([barkodno], [urunadi], [miktari], [satisfiyati], [tarih]) VALUES (N'002', N'Muz', N'184', CAST(32.00 AS Decimal(18, 2)), N'31.12.2023 13:27:49')
GO
INSERT [dbo].[urun] ([barkodno], [urunadi], [miktari], [satisfiyati], [tarih]) VALUES (N'003', N'Domates', N'275', CAST(8.00 AS Decimal(18, 2)), N'31.12.2023 13:28:06')
GO
INSERT [dbo].[urun] ([barkodno], [urunadi], [miktari], [satisfiyati], [tarih]) VALUES (N'004', N'Biber', N'400470', CAST(22.00 AS Decimal(18, 2)), N'31.12.2023 13:28:26')
GO
INSERT [dbo].[urun] ([barkodno], [urunadi], [miktari], [satisfiyati], [tarih]) VALUES (N'006', N'vişne', N'90', CAST(14.00 AS Decimal(18, 2)), N'6.01.2024 18:03:55')
GO
INSERT [dbo].[urun] ([barkodno], [urunadi], [miktari], [satisfiyati], [tarih]) VALUES (N'007', N'Dalbastı', N'150', CAST(12.00 AS Decimal(18, 2)), N'7.01.2024 13:56:22')
GO
