USE [ProductCategorydb]
GO
/****** Object:  Table [dbo].[TBlP_C]    Script Date: 11-11-2021 11:50:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBlP_C](
	[CatId] [int] IDENTITY(1,1) NOT NULL,
	[CatName] [varchar](50) NOT NULL,
	[ProId] [varchar](50) NOT NULL,
	[ProName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TBlP_C] PRIMARY KEY CLUSTERED 
(
	[CatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBlP_C] ON 

INSERT [dbo].[TBlP_C] ([CatId], [CatName], [ProId], [ProName]) VALUES (5, N'shampoo', N'1', N'hairshoulder')
INSERT [dbo].[TBlP_C] ([CatId], [CatName], [ProId], [ProName]) VALUES (1006, N'medicine', N'2', N'crosin')
INSERT [dbo].[TBlP_C] ([CatId], [CatName], [ProId], [ProName]) VALUES (1023, N'sweets', N'3', N'chocklate')
INSERT [dbo].[TBlP_C] ([CatId], [CatName], [ProId], [ProName]) VALUES (1026, N'brands', N'4', N'laptop')
INSERT [dbo].[TBlP_C] ([CatId], [CatName], [ProId], [ProName]) VALUES (1027, N'facewash', N'5', N'pears')
SET IDENTITY_INSERT [dbo].[TBlP_C] OFF
