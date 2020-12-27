USE [master]
GO
/****** Object:  Database [HarithmaSales]    Script Date: 12/27/2020 11:49:20 AM ******/
CREATE DATABASE [HarithmaSales]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HarithmaSales', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HarithmaSales.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HarithmaSales_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HarithmaSales_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HarithmaSales] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HarithmaSales].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HarithmaSales] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HarithmaSales] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HarithmaSales] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HarithmaSales] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HarithmaSales] SET ARITHABORT OFF 
GO
ALTER DATABASE [HarithmaSales] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HarithmaSales] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HarithmaSales] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HarithmaSales] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HarithmaSales] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HarithmaSales] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HarithmaSales] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HarithmaSales] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HarithmaSales] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HarithmaSales] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HarithmaSales] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HarithmaSales] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HarithmaSales] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HarithmaSales] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HarithmaSales] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HarithmaSales] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HarithmaSales] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HarithmaSales] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HarithmaSales] SET  MULTI_USER 
GO
ALTER DATABASE [HarithmaSales] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HarithmaSales] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HarithmaSales] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HarithmaSales] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HarithmaSales] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HarithmaSales] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HarithmaSales] SET QUERY_STORE = OFF
GO
USE [HarithmaSales]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 12/27/2020 11:49:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[DiscountID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[DiscountValue] [decimal](19, 4) NULL,
	[DiscountStartDate] [datetime] NULL,
	[DiscountEndDate] [datetime] NULL,
	[DiscountDuration] [int] NULL,
	[DiscountStatus] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 12/27/2020 11:49:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[InventoryID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NOT NULL,
	[StockPrice] [decimal](19, 4) NOT NULL,
	[SellingPrice] [decimal](19, 4) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Remarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[InventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 12/27/2020 11:49:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceDate] [datetime] NOT NULL,
	[InvoiceDiscount] [decimal](19, 4) NULL,
	[InvoiceAmount] [decimal](19, 4) NOT NULL,
	[InvoiceAmountRecieved] [decimal](19, 4) NOT NULL,
	[InvoiceBalance] [decimal](19, 4) NULL,
	[InvoicePaymentMethod] [nvarchar](50) NULL,
	[InvoiceRemarks] [nvarchar](100) NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 12/27/2020 11:49:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](50) NOT NULL,
	[ItemDescription] [nvarchar](max) NULL,
	[ItemStockPrice] [decimal](19, 4) NULL,
	[ItemSellingPrice] [decimal](19, 4) NOT NULL,
	[ItemAvailableQuantity] [int] NOT NULL,
	[ItemDiscount] [float] NULL,
	[ItemDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Invoice]    Script Date: 12/27/2020 11:49:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Invoice](
	[Item_Invoice_ID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_Item_Invoice] PRIMARY KEY CLUSTERED 
(
	[Item_Invoice_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_InvoiceDate]  DEFAULT (getdate()) FOR [InvoiceDate]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_ItemDate]  DEFAULT (getdate()) FOR [ItemDate]
GO
ALTER TABLE [dbo].[Discount]  WITH CHECK ADD  CONSTRAINT [Item_Discount] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Item] ([ItemID])
GO
ALTER TABLE [dbo].[Discount] CHECK CONSTRAINT [Item_Discount]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD  CONSTRAINT [Item_Inventory] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Item] ([ItemID])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [Item_Inventory]
GO
ALTER TABLE [dbo].[Item_Invoice]  WITH CHECK ADD  CONSTRAINT [Invoice_ItemInvoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[Item_Invoice] CHECK CONSTRAINT [Invoice_ItemInvoice]
GO
ALTER TABLE [dbo].[Item_Invoice]  WITH CHECK ADD  CONSTRAINT [Item_ItemInvoice] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Item] ([ItemID])
GO
ALTER TABLE [dbo].[Item_Invoice] CHECK CONSTRAINT [Item_ItemInvoice]
GO
USE [master]
GO
ALTER DATABASE [HarithmaSales] SET  READ_WRITE 
GO
