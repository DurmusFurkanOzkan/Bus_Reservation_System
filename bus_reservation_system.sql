USE [master]
GO
/****** Object:  Database [Bus Reservation System]    Script Date: 22.10.2022 14:14:46 ******/
CREATE DATABASE [Bus Reservation System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bus Reservation System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Bus Reservation System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bus Reservation System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Bus Reservation System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bus Reservation System] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bus Reservation System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bus Reservation System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bus Reservation System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bus Reservation System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bus Reservation System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bus Reservation System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bus Reservation System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bus Reservation System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bus Reservation System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bus Reservation System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bus Reservation System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bus Reservation System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bus Reservation System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bus Reservation System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bus Reservation System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bus Reservation System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bus Reservation System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bus Reservation System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bus Reservation System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bus Reservation System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bus Reservation System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bus Reservation System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bus Reservation System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bus Reservation System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Bus Reservation System] SET  MULTI_USER 
GO
ALTER DATABASE [Bus Reservation System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bus Reservation System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bus Reservation System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bus Reservation System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bus Reservation System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bus Reservation System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Bus Reservation System] SET QUERY_STORE = OFF
GO
USE [Bus Reservation System]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 22.10.2022 14:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[ID] [tinyint] NULL,
	[Account_number] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Driver]    Script Date: 22.10.2022 14:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Driver](
	[ID] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Surname] [varchar](20) NULL,
	[Mail_address] [varchar](50) NULL,
	[Telephone_number] [varchar](20) NULL,
	[National_Identity_Number] [varchar](11) NULL,
 CONSTRAINT [PK_Driver] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 22.10.2022 14:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Surname] [varchar](20) NULL,
	[National_Identity_Number] [varchar](20) NULL,
	[Telephone_Number] [varchar](20) NULL,
	[Gender] [varchar](5) NULL,
	[Mail_Address] [varchar](50) NULL,
 CONSTRAINT [PK_Passenger] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 22.10.2022 14:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Voyage_Number] [int] NULL,
	[Seat_Number] [int] NULL,
	[National_Identity_Number] [varchar](20) NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voyage]    Script Date: 22.10.2022 14:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voyage](
	[ID] [int] IDENTITY(1000,1) NOT NULL,
	[Departure_point] [varchar](20) NULL,
	[Destination] [varchar](20) NULL,
	[Date] [varchar](20) NULL,
	[Time] [varchar](10) NULL,
	[Driver] [int] NULL,
	[Price] [int] NULL,
	[seat1] [bit] NULL,
	[seat2] [bit] NULL,
	[seat3] [bit] NULL,
	[seat4] [bit] NULL,
	[seat5] [bit] NULL,
	[seat6] [bit] NULL,
	[seat7] [bit] NULL,
	[seat8] [bit] NULL,
	[seat9] [bit] NULL,
	[seat10] [bit] NULL,
	[seat11] [bit] NULL,
 CONSTRAINT [PK_Voyage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat1]  DEFAULT ((0)) FOR [seat1]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat2]  DEFAULT ((0)) FOR [seat2]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat3]  DEFAULT ((0)) FOR [seat3]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat4]  DEFAULT ((0)) FOR [seat4]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat5]  DEFAULT ((0)) FOR [seat5]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat6]  DEFAULT ((0)) FOR [seat6]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat7]  DEFAULT ((0)) FOR [seat7]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat8]  DEFAULT ((0)) FOR [seat8]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat9]  DEFAULT ((0)) FOR [seat9]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat10]  DEFAULT ((0)) FOR [seat10]
GO
ALTER TABLE [dbo].[Voyage] ADD  CONSTRAINT [DF_Voyage_seat11]  DEFAULT ((0)) FOR [seat11]
GO
USE [master]
GO
ALTER DATABASE [Bus Reservation System] SET  READ_WRITE 
GO
