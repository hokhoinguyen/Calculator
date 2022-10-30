
use master
GO

Create database BookStore
GO

use BookStore
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

INSERT [dbo].[Author] ([Id], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (1, N'Thành', N'Dương', N'Hậu Giang', N'0984461466', N'dhthanhqa@gmail.com')
GO

INSERT [dbo].[Author] ([Id], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (2, N'Lê', N'Nguyễn', N'Tp.HCM', N'0984461467', N'lenguyen@gmail.com')
GO

INSERT [dbo].[Author] ([Id], [FirstName], [LastName], [Address], [Phone], [Email]) VALUES (3, N'Nam', N'Võ', N'Long An', N'0984461468', N'namvo@gmail.com')
GO

/****** Object:  Table [dbo].[Category]    Script Date: 04/08/2021 08:10:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Tin học')
GO

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Ngoại ngữ')
GO

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Chính trị')
GO

/****** Object:  StoredProcedure [dbo].[Top3Authors]    Script Date: 04/08/2021 08:10:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[CountAuthors]    Script Date: 04/08/2021 08:10:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Book]    Script Date: 04/08/2021 08:10:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

INSERT [dbo].[Book] ([BookID], [BookName], [CategoryID]) VALUES (1, N'CSDL', 1)
GO

INSERT [dbo].[Book] ([BookID], [BookName], [CategoryID]) VALUES (2, N'LTCSDL', 1)
GO

INSERT [dbo].[Book] ([BookID], [BookName], [CategoryID]) VALUES (3, N'LTGD', 1)
GO

INSERT [dbo].[Book] ([BookID], [BookName], [CategoryID]) VALUES (4, N'Anh văn 1', 2)
GO

/****** Object:  Table [dbo].[BookAuthor]    Script Date: 04/08/2021 08:10:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

INSERT [dbo].[BookAuthor] ([BookID], [AuthorID], [PublishDate]) VALUES (1, 1, CAST(0x843F0B00 AS Date))
GO

INSERT [dbo].[BookAuthor] ([BookID], [AuthorID], [PublishDate]) VALUES (1, 2, CAST(0x843F0B00 AS Date))
GO

INSERT [dbo].[BookAuthor] ([BookID], [AuthorID], [PublishDate]) VALUES (2, 1, CAST(0x6C410B00 AS Date))
GO
