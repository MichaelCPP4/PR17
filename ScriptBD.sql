USE [master]
GO
/****** Object:  Database [Sport]    Script Date: 30.03.2023 15:50:17 ******/
CREATE DATABASE [Sport]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sport', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sport.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Sport_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sport_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sport] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sport].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sport] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sport] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sport] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sport] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sport] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sport] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sport] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sport] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sport] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sport] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sport] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sport] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sport] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sport] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sport] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sport] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sport] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sport] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sport] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sport] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sport] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sport] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sport] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sport] SET  MULTI_USER 
GO
ALTER DATABASE [Sport] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sport] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sport] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sport] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Sport] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sport] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sport] SET QUERY_STORE = OFF
GO
USE [Sport]
GO
/****** Object:  Table [dbo].[TennisPlayer]    Script Date: 30.03.2023 15:50:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TennisPlayer](
	[FIOSportsman] [nvarchar](25) NOT NULL,
	[NameSportsman] [nvarchar](50) NOT NULL,
	[OtchSportsman] [nvarchar](50) NULL,
	[Gender] [nvarchar](7) NOT NULL,
	[Birthday] [int] NOT NULL,
	[FIOTrener] [nvarchar](50) NOT NULL,
	[NameTrener] [nvarchar](50) NOT NULL,
	[OtchTrener] [nvarchar](50) NULL,
	[Country] [nvarchar](56) NOT NULL,
	[Rating2018] [int] NULL,
	[Rating2019] [int] NULL,
	[Rating2020] [int] NULL,
	[Rating2021] [int] NULL,
	[Rating2022] [int] NULL,
 CONSTRAINT [PK_TennisPlayer] PRIMARY KEY CLUSTERED 
(
	[FIOSportsman] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Андре', N'Кирк', N'Агасси', N'Мужской', 1970, N'Hill', N'John', NULL, N'США', 10, 17, 15, 23, 16)
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Артёмова', N'Вера', N'Семёнова', N'Женский', 1997, N'Ларин', N'Михаил', N'Кириллович', N'Российская Федерация', 101, 98, 64, 32, 15)
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Давыденко', N'Николай', N'Владимирович', N'Мужской', 1981, N'Давыденко', N'Эдуард', N'Александрович', N'Российская Федерация', 356, 285, 112, 34, 256)
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Егорова', N'София', N'Петровна', N'Женский', 1999, N'Борисова', N'Виктория', N'Марковна', N'Российская Федерация', 65, 66, 35, 44, 12)
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Карацев', N'Аслан', N'Казбекович', N'Мужской', 1993, N'Куприн', N'Александр', N'Юрьевич', N'Российская Федерация', 747, 323, 112, 114, 14)
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Медведев', N'Даниил', N'Сергеевич', N'Мужской', 1996, N'Иванова', N'Екатерина', N'Андреевна', N'Российская Федерация', 16, 5, 8, 2, 7)
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Сафин', N'Марат', N'Мубинович', N'Мужской', 1980, N'Волков', N'Александр', N'Владимирович', N'Российская Федерация', 44, 26, 29, 31, 20)
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Хингис', N'Мартина', NULL, N'Женский', 1980, N'Молитор', N'Мелани', NULL, N'Швейцария', 2, 1, 1, 10, 7)
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Чесноков', N'Андрей', N'Эдуардович', N'Мужской', 1966, N'Наумко', N'Татьяна', N'Фёдоровна', N'Российская Федерация', 126, 92, 111, 23, 9)
INSERT [dbo].[TennisPlayer] ([FIOSportsman], [NameSportsman], [OtchSportsman], [Gender], [Birthday], [FIOTrener], [NameTrener], [OtchTrener], [Country], [Rating2018], [Rating2019], [Rating2020], [Rating2021], [Rating2022]) VALUES (N'Южный', N'Михаил', N'Михайлович', N'Мужской', 1982, N'Собкин', N'Борис', N'Львович', N'Российская Федерация', 325, 163, 75, 32, 8)
GO
USE [master]
GO
ALTER DATABASE [Sport] SET  READ_WRITE 
GO
