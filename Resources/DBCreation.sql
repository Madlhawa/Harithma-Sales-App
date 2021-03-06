USE [HarithmaSales]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 12/27/2020 7:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[DiscountID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[DiscountValue] [decimal](19, 4) NOT NULL,
	[DiscountStartDate] [datetime] NULL,
	[DiscountEndDate] [datetime] NOT NULL,
	[DiscountDuration] [int] NULL,
	[DiscountStatus] [nchar](10) NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 12/27/2020 7:54:02 PM ******/
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
/****** Object:  Table [dbo].[Invoice]    Script Date: 12/27/2020 7:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceDate] [datetime] NOT NULL,
	[InvoiceDiscount] [decimal](19, 4) NULL,
	[InvoiceAmount] [decimal](19, 4) NOT NULL,
	[InvoiceAmountRecieved] [decimal](19, 4) NULL,
	[InvoiceBalance] [decimal](19, 4) NULL,
	[InvoicePaymentMethod] [nvarchar](50) NULL,
	[InvoiceRemarks] [nvarchar](100) NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 12/27/2020 7:54:02 PM ******/
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
	[ItemDiscount] [decimal](19, 4) NULL,
	[ItemDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Invoice]    Script Date: 12/27/2020 7:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Invoice](
	[Item_Invoice_ID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [decimal](19, 4) NULL,
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
