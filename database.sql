USE [SpotiniDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 27/10/2023 2:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[accountId] [int] IDENTITY(1,1) NOT NULL,
	[role] [nvarchar](500) NULL,
	[status] [nvarchar](500) NULL,
	[username] [nvarchar](500) NULL,
	[password] [nvarchar](500) NULL,
	[fullName] [nvarchar](500) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[accountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artist]    Script Date: 27/10/2023 2:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artist](
	[artistId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](500) NULL,
	[country] [nvarchar](500) NULL,
 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[artistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FavoriteList]    Script Date: 27/10/2023 2:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FavoriteList](
	[favoriteListId] [int] IDENTITY(1,1) NOT NULL,
	[accountId] [int] NULL,
	[musicId] [int] NULL,
 CONSTRAINT [PK_FavoriteList] PRIMARY KEY CLUSTERED 
(
	[favoriteListId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Music]    Script Date: 27/10/2023 2:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Music](
	[musicId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](500) NULL,
	[artistId] [nvarchar](500) NULL,
	[path] [nvarchar](500) NULL,
	[releaseDate] [date] NULL,
	[image] [nvarchar](500) NULL,
 CONSTRAINT [PK_Music] PRIMARY KEY CLUSTERED 
(
	[musicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([accountId], [role], [status], [username], [password], [fullName]) VALUES (1, N'ADMIN', N'active', N'admin', N'admin', N'Admin')
INSERT [dbo].[Account] ([accountId], [role], [status], [username], [password], [fullName]) VALUES (2, N'USER', N'active', N'user', N'user', N'User')
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
