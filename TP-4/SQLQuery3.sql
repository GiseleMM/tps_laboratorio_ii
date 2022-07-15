CREATE DATABASE [TPFinal]
GO
USE [TPFinal]
GO
/****** Object:  Table [dbo].[Adoptante]    Script Date: 19/6/2022 23:50:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adoptante](
	[DNI] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [int] NULL,
 CONSTRAINT [PK_Adoptante] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perros]    Script Date: 19/6/2022 23:50:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perros](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Edad] [int] NULL,
	[Refugio] [varchar](50) NULL,
	[ParaAdopcion] [bit] NULL,
	[IdAdoptante] [int] NULL,
 CONSTRAINT [PK_Perros] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Adoptante] ([DNI], [Nombre], [Direccion], [Telefono]) VALUES (20714983, N'Jonathan Garcia', N'Lanus,Resistencia 1820 ', 1500023344)
INSERT [dbo].[Adoptante] ([DNI], [Nombre], [Direccion], [Telefono]) VALUES (34222565, N'Marta Americo', N'Banfield,Yrigoyen 661', 1566612345)
INSERT [dbo].[Adoptante] ([DNI], [Nombre], [Direccion], [Telefono]) VALUES (44714923, N'Rocio Leal ', N'Lanus,Arturo Melo 1701', 1511223344)
INSERT [dbo].[Adoptante] ([DNI], [Nombre], [Direccion], [Telefono]) VALUES (44722223, N'Nestor Gomez ', N'Lanus,Beracruz 1490', 1511223098)
INSERT [dbo].[Adoptante] ([DNI], [Nombre], [Direccion], [Telefono]) VALUES (45714523, N' Roberto Morales', N'Banfield,Pedernera 1230', 1521223444)
INSERT [dbo].[Adoptante] ([DNI], [Nombre], [Direccion], [Telefono]) VALUES (65578823, N' Rene Pagani ', N' Bnafield,Maipu 974', 1587658899)
GO
SET IDENTITY_INSERT [dbo].[Perros] ON 

INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (0, N'Blue', 2, N'Refugio Sur', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (2, N'Luna', 7, N'San Francisco de Asis ', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (3, N'Lebron ', 3, N'San Francisco de Asis ', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (4, N'Isidoro', 2, N'Refugio Sur', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (5, N'Rocky', 10, N'Refugio Sur', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (6, N'Igor', 5, N'Refugio Sur', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (7, N'Bombona', 5, N'Naricitas frias', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (8, N'Andre', 1, N'Naricitas frias', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (9, N'Bichi', 3, N'Naricitas frias', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (10, N'Lucky', 7, N'San Francisco de Asis ', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (11, N'Osito', 7, N'San Francisco de Asis ', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (12, N'Princesa', 2, N'San Francisco de Asis ', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (13, N'Oreo', 1, N'San Francisco de Asis ', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (14, N'Elvis', 5, N'Refugio Sur', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (15, N'Balto', 5, N'Refugio Sur', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (16, N'Pluto', 3, N'Refugio Sur', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (17, N'Max', 3, N'Refugio Sur', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (18, N'Leo', 9, N'San Francisco de Asis ', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (19, N'Simba', 8, N'San Francisco de Asis ', 1, NULL)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (20, N'Coco', 10, N'San Francisco de Asis ', 0, 45714523)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (21, N'Thor', 10, N'Naricitas frias', 0, 65578823)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (22, N'Nene', 4, N'Naricitas frias', 0, 65578823)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (23, N'Tobi', 4, N'Naricitas frias', 0, 44722223)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (24, N'Beto', 2, N'Naricitas frias', 0, 20714983)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (25, N'Tupac', 1, N'Naricitas frias', 0, 44714923)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (26, N'Rocco', 8, N'Naricitas frias', 0, 44714923)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (27, N'Azucar', 5, N'El Campito', 1, 34222565)
INSERT [dbo].[Perros] ([Id], [Nombre], [Edad], [Refugio], [ParaAdopcion], [IdAdoptante]) VALUES (28, N'Morena', 2, N'El campito', 1, NULL)
SET IDENTITY_INSERT [dbo].[Perros] OFF
GO
USE [master]
GO
ALTER DATABASE [TPFinal] SET  READ_WRITE 
GO
