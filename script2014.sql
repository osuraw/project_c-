USE [master]
GO
/****** Object:  Database [project1-2018-7-15-5-7]    Script Date: 2018-07-17 8:04:46 AM ******/
CREATE DATABASE [project1-2018-7-15-5-7]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'project1-2018-7-15-5-7_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\project1-2018-7-15-5-7.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'project1-2018-7-15-5-7_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\project1-2018-7-15-5-7.ldf' , SIZE = 16064KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [project1-2018-7-15-5-7].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET ARITHABORT OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET  ENABLE_BROKER 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET RECOVERY FULL 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET  MULTI_USER 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET DB_CHAINING OFF 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET TARGET_RECOVERY_TIME = 120 SECONDS 
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'project1-2018-7-15-5-7', N'ON'
GO
USE [project1-2018-7-15-5-7]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Categoryid] [smallint] NOT NULL,
	[Category] [nchar](30) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Categoryid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrossProfit]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrossProfit](
	[GrossProfitId] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[FromDate] [date] NULL,
	[ToDate] [date] NULL,
	[TotalIncom] [money] NULL,
	[TotalExpense] [money] NULL,
 CONSTRAINT [PK_GrossProfit] PRIMARY KEY CLUSTERED 
(
	[GrossProfitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceId] [int] NOT NULL,
	[GrossProfitId] [int] NULL,
	[UserId] [int] NULL,
	[Total] [money] NULL,
	[Discount] [money] NULL,
	[PaidAmount] [money] NULL,
	[Balance] [money] NULL,
	[DateTime] [smalldatetime] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetails]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetails](
	[InvoiceId] [int] NOT NULL,
	[StockId] [int] NOT NULL,
	[Quantity] [smallint] NULL,
 CONSTRAINT [PK_IIDSID] PRIMARY KEY CLUSTERED 
(
	[InvoiceId] ASC,
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] NOT NULL,
	[SupplierId] [smallint] NULL,
	[UserId] [int] NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [smallint] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [smallint] NOT NULL,
	[Name] [nchar](50) NULL,
	[Category] [nchar](20) NULL,
	[Quantity] [int] NULL,
	[Details] [nchar](200) NULL,
	[ExisitingQuantity] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrder](
	[OrderId] [int] NOT NULL,
	[SupplierID] [smallint] NOT NULL,
	[UserId] [int] NOT NULL,
	[Date] [date] NULL,
	[Note] [nchar](200) NULL,
 CONSTRAINT [PK_PurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[StockId] [char](5) NOT NULL,
	[SupplierId] [int] NULL,
	[Date] [datetime] NULL,
	[PaidAmount] [float] NULL,
 CONSTRAINT [PK_StockId] PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockDetail]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockDetail](
	[StockDetailID] [int] NOT NULL,
	[StockID] [char](5) NULL,
	[ProductID] [int] NULL,
	[PurchasePrice] [float] NULL,
	[SellingPrice] [float] NULL,
	[ManufactureDate] [datetime] NULL,
	[ExpiryDate] [datetime] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_StockDetailId] PRIMARY KEY CLUSTERED 
(
	[StockDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID] [smallint] NOT NULL,
	[Name] [nchar](50) NULL,
	[Address] [nchar](100) NULL,
	[Telephone] [nchar](10) NULL,
	[Email] [nchar](50) NULL,
	[BankAccountNo] [nchar](20) NULL,
	[Details] [nchar](200) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2018-07-17 8:04:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](20) NULL,
	[LastName] [nchar](20) NULL,
	[Mobile] [nchar](10) NULL,
	[Address] [nchar](100) NULL,
	[Username] [nchar](20) NULL,
	[Password] [nchar](20) NULL,
	[UserType] [smallint] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_GrossProfitId]  DEFAULT ((0)) FOR [GrossProfitId]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_Supplier1] FOREIGN KEY([ID])
REFERENCES [dbo].[Supplier] ([ID])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_Supplier1]
GO
USE [master]
GO
ALTER DATABASE [project1-2018-7-15-5-7] SET  READ_WRITE 
GO
