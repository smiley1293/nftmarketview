USE [NFTWebManagement]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 06/03/2024 11:13:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Fullname] [nvarchar](50) NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 06/03/2024 11:13:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](300) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NftPictures]    Script Date: 06/03/2024 11:13:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NftPictures](
	[NftID] [nvarchar](50) NOT NULL,
	[NftName] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[Image] [nvarchar](max) NULL,
	[CategoryID] [int] NOT NULL,
 CONSTRAINT [PK_NftPictures] PRIMARY KEY CLUSTERED 
(
	[NftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Accounts] ([Email], [Password], [Username], [Fullname], [RoleID]) VALUES (N'a@gmail.com', N'1234567', N'admin2', N'admin dep trai', 1)
INSERT [dbo].[Accounts] ([Email], [Password], [Username], [Fullname], [RoleID]) VALUES (N'vantcii@gmail.com', N'88888', N'viet', N'Khách hàng', 2)
INSERT [dbo].[Accounts] ([Email], [Password], [Username], [Fullname], [RoleID]) VALUES (N'viet1209@gmail.com', N'11111', N'viet', N'trong viet', 2)
INSERT [dbo].[Accounts] ([Email], [Password], [Username], [Fullname], [RoleID]) VALUES (N'vietadmin@gmail.com', N'686868', N'vantcii', N'Mai Trọng Việt Thích Design', 1)
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (1, N'Common', N'Common NFT')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (2, N'Magic', N'Magic NFT')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (3, N'Rare', N'Rare NFT')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (4, N'Super Rare', N'Superrare NFT')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (5, N'Legendary', N'Lengendary NFT')
GO
INSERT [dbo].[NftPictures] ([NftID], [NftName], [Description], [Price], [Image], [CategoryID]) VALUES (N'N0001', N'Monkey Prime', N'Gold background with brown hat', CAST(25.00 AS Decimal(10, 2)), NULL, 1)
INSERT [dbo].[NftPictures] ([NftID], [NftName], [Description], [Price], [Image], [CategoryID]) VALUES (N'N0002', N'Cigarette Monkey', N'The monkey with gold cigarette', CAST(10.15 AS Decimal(10, 2)), NULL, 2)
GO
ALTER TABLE [dbo].[NftPictures]  WITH CHECK ADD  CONSTRAINT [FK_NftPictures_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[NftPictures] CHECK CONSTRAINT [FK_NftPictures_Categories]
GO
