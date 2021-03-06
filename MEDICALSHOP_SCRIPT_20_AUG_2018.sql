USE [master]
GO
/****** Object:  Database [MEDICALSHOP]    Script Date: 8/20/2018 9:37:00 PM ******/
CREATE DATABASE [MEDICALSHOP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MEDICALSHOP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MEDICALSHOP.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MEDICALSHOP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MEDICALSHOP_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MEDICALSHOP] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MEDICALSHOP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MEDICALSHOP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET ARITHABORT OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MEDICALSHOP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MEDICALSHOP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MEDICALSHOP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MEDICALSHOP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MEDICALSHOP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MEDICALSHOP] SET  MULTI_USER 
GO
ALTER DATABASE [MEDICALSHOP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MEDICALSHOP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MEDICALSHOP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MEDICALSHOP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MEDICALSHOP] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MEDICALSHOP]
GO
/****** Object:  Table [dbo].[GSTPURCHASE]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GSTPURCHASE](
	[GST PURCHASE ID] [int] IDENTITY(1,1) NOT NULL,
	[DATE] [varchar](max) NULL,
	[GSTIN] [varchar](max) NULL,
	[NAME OF PARTY] [varchar](max) NULL,
	[0%] [float] NULL,
	[5%] [float] NULL,
	[SGST 2.5%] [float] NULL,
	[CGST 2.5%] [float] NULL,
	[12%] [float] NULL,
	[SGST 6%] [float] NULL,
	[CGST 6%] [float] NULL,
	[18%] [float] NULL,
	[SGST 9%] [float] NULL,
	[CGST 9%] [float] NULL,
	[28%] [float] NULL,
	[SGST 14%] [float] NULL,
	[CGST 14%] [float] NULL,
	[GROSS AMOUNT] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ManufacturerMaster]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ManufacturerMaster](
	[Mid] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer_Name] [varchar](50) NULL,
	[Manufacturer_Id] [varchar](50) NULL,
 CONSTRAINT [PK_ManufacturerMaster] PRIMARY KEY CLUSTERED 
(
	[Mid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesReturn]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesReturn](
	[ReturnID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [varchar](50) NULL,
	[SupplierName] [varchar](50) NULL,
	[ItemName] [varchar](50) NULL,
	[CompanyName] [varchar](50) NULL,
	[Batch] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Rate] [float] NULL,
	[ReturnTo] [varchar](50) NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesReturnDisplay]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesReturnDisplay](
	[ReturnID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [varchar](50) NULL,
	[SupplierName] [varchar](50) NULL,
	[ItemName] [varchar](50) NULL,
	[CompanyName] [varchar](50) NULL,
	[Batch] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Rate] [float] NULL,
	[ReturnTo] [varchar](50) NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_AdminLogin]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_AdminLogin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_AdminLogin] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_BranchMaster]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_BranchMaster](
	[BranchId] [int] IDENTITY(1,1) NOT NULL,
	[BrannchName] [varchar](max) NULL,
	[Location] [varchar](max) NULL,
	[Kgst.No] [varchar](max) NULL,
	[PhoneNo] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_BranchMaster] PRIMARY KEY CLUSTERED 
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Form]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Form](
	[FormID] [int] NULL,
	[FormName] [varchar](50) NULL,
	[Type] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_ProductMaster]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_ProductMaster](
	[PrdId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[ManufactureName] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
	[SubCategory] [varchar](50) NULL,
	[GenericName] [varchar](50) NULL,
	[Schedule] [varchar](50) NULL,
	[RackNo] [varchar](50) NULL,
	[MinLevel] [varchar](50) NULL,
	[MaxLevel] [varchar](50) NULL,
	[HSNCode] [varchar](50) NULL,
	[GST] [varchar](50) NULL,
	[SubHead] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PrdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Purchase]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Purchase](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [varchar](50) NULL,
	[DateofPurchase] [varchar](50) NULL,
	[GST] [varchar](50) NULL,
	[InvoiceNumber] [varchar](50) NULL,
	[InvoiceDate] [varchar](50) NULL,
	[Receivedon] [varchar](50) NULL,
	[CeditDays] [varchar](50) NULL,
	[SetRack] [varchar](50) NULL,
	[TMRP1] [varchar](50) NULL,
	[TMRP2] [varchar](50) NULL,
	[Discount] [varchar](50) NULL,
	[AdlDiscount] [varchar](50) NULL,
	[Rounding] [varchar](50) NULL,
	[Adjustment] [varchar](50) NULL,
	[Narration] [varchar](50) NULL,
	[GrandTotal] [varchar](50) NULL,
	[NetBalance] [varchar](50) NULL,
	[AmountforAccounts] [varchar](50) NULL,
	[PaidAmount] [varchar](50) NULL,
	[Balance] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Purchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_purchaseItem]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_purchaseItem](
	[RowId] [int] IDENTITY(1,1) NOT NULL,
	[ItemNo] [varchar](50) NULL,
	[PurchaseID] [varchar](50) NULL,
	[ItemName] [varchar](50) NULL,
	[ItemDesc] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[Batch] [varchar](50) NULL,
	[ExpDate] [varchar](50) NULL,
	[Pad] [varchar](50) NULL,
	[PQty] [int] NULL,
	[Qy] [varchar](50) NULL,
	[Rate] [varchar](50) NULL,
	[Discount] [varchar](50) NULL,
	[Amount] [varchar](50) NULL,
	[SalesRate] [varchar](50) NULL,
	[MRP] [float] NULL,
	[Rack] [varchar](50) NULL,
	[GST] [float] NULL,
	[HSN Code] [varchar](50) NULL,
	[NetRate] [float] NULL,
	[SRate] [float] NULL,
	[Free] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_purchaseItem] PRIMARY KEY CLUSTERED 
(
	[RowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_PurchaseReturn]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_PurchaseReturn](
	[Purchase_ReturnID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [varchar](50) NULL,
	[Date] [date] NULL,
	[SupplierName] [varchar](50) NULL,
	[ItemName] [varchar](50) NULL,
	[CompanyName] [varchar](50) NULL,
	[Batch] [varchar](50) NULL,
	[Reason] [varchar](50) NULL,
	[Rate] [float] NULL,
	[Total] [float] NULL,
	[ReturnTo] [varchar](50) NULL,
	[Quantity] [float] NULL,
 CONSTRAINT [PK_Tbl_PurchaseReturn] PRIMARY KEY CLUSTERED 
(
	[Purchase_ReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_PurchaseReturnDisplay]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_PurchaseReturnDisplay](
	[PurchaseReturn_ID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [varchar](50) NULL,
	[ItemName] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[Batch] [varchar](50) NULL,
	[Reason] [varchar](50) NULL,
	[Amount] [float] NULL,
	[Quantity] [float] NULL,
 CONSTRAINT [PK_Tbl_PurchaseReturnDisplay] PRIMARY KEY CLUSTERED 
(
	[PurchaseReturn_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Sales]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Sales](
	[BillNo] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NULL,
	[Date] [datetime] NULL,
	[UserID] [varchar](50) NOT NULL,
	[DoctorName] [varchar](50) NULL,
	[Patient] [varchar](50) NULL,
	[Discount] [varchar](50) NULL,
	[SalesReturn] [varchar](50) NULL,
	[Adj] [varchar](50) NULL,
	[Note] [varchar](50) NULL,
	[Grandtotal] [float] NULL,
	[CashReceived] [varchar](50) NULL,
	[Balance] [varchar](50) NULL,
	[ReceivedAmount] [varchar](50) NULL,
	[GST] [varchar](50) NULL,
	[Profit] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Sales] PRIMARY KEY CLUSTERED 
(
	[BillNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_SalesItem]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_SalesItem](
	[SlNo] [int] IDENTITY(1,1) NOT NULL,
	[ItemNo] [bigint] NULL,
	[BillNo] [bigint] NOT NULL,
	[ItemName] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[Qty] [bigint] NULL,
	[Batch] [varchar](50) NULL,
	[Exp] [varchar](50) NULL,
	[GST] [bigint] NULL,
	[MRP] [money] NULL,
	[Rate] [money] NULL,
	[Amount] [money] NULL,
	[Rack] [varchar](50) NULL,
	[Total] [money] NULL,
	[SGST] [float] NULL,
	[Discount] [float] NULL,
	[NetRate] [float] NULL,
	[HSNCode] [varchar](50) NULL,
	[SalesRate] [float] NULL,
	[Free] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_SalesItem] PRIMARY KEY CLUSTERED 
(
	[SlNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_SalesItem_DUMMY]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_SalesItem_DUMMY](
	[SlNo] [int] IDENTITY(1,1) NOT NULL,
	[ITEMNO] [varchar](50) NULL,
	[BILLNO] [varchar](50) NULL,
	[ITEMNAME] [varchar](50) NULL,
	[COMPANY] [varchar](50) NULL,
	[QUANTITY] [varchar](50) NULL,
	[BATCH] [varchar](50) NULL,
	[EXP DATE] [varchar](50) NULL,
	[GST] [varchar](50) NULL,
	[MRP] [varchar](50) NULL,
	[RATE] [varchar](50) NULL,
	[AMOUNT] [varchar](50) NULL,
	[RACK] [varchar](50) NULL,
	[TOTAL] [float] NULL,
	[DISCOUNT] [float] NULL,
	[NETRATE] [float] NULL,
	[HSNCODE] [varchar](50) NULL,
	[SALERATE] [float] NULL,
	[FREE] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_SalesItem_DUMMY] PRIMARY KEY CLUSTERED 
(
	[SlNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Stock]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Stock](
	[RowId] [int] IDENTITY(1,1) NOT NULL,
	[ItemNo] [varchar](50) NULL,
	[PurchaseID] [varchar](50) NULL,
	[ItemName] [varchar](50) NULL,
	[ItemDesc] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[Batch] [varchar](50) NULL,
	[ExpDate] [varchar](50) NULL,
	[Pad] [varchar](50) NULL,
	[PQty] [int] NULL,
	[Qy] [varchar](50) NULL,
	[Rate] [varchar](50) NULL,
	[Discount] [varchar](50) NULL,
	[Amount] [varchar](50) NULL,
	[SalesRate] [varchar](50) NULL,
	[MRP] [float] NULL,
	[Rack] [varchar](50) NULL,
	[SGST] [float] NULL,
	[HSN Code] [varchar](50) NULL,
	[NetRate] [float] NULL,
	[SRate] [float] NULL,
	[Free] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Stock] PRIMARY KEY CLUSTERED 
(
	[RowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Stock_dummy]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Stock_dummy](
	[RowId] [int] IDENTITY(1,1) NOT NULL,
	[ItemNo] [varchar](50) NULL,
	[PurchaseID] [varchar](50) NULL,
	[ItemName] [varchar](50) NULL,
	[ItemDesc] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[Batch] [varchar](50) NULL,
	[ExpDate] [varchar](50) NULL,
	[Pad] [varchar](50) NULL,
	[PQty] [int] NULL,
	[Qy] [int] NULL,
	[Rate] [float] NULL,
	[Discount] [float] NULL,
	[Amount] [float] NULL,
	[SalesRate] [float] NULL,
	[MRP] [float] NULL,
	[Rack] [varchar](50) NULL,
	[SGST] [float] NULL,
	[HSNcode] [varchar](50) NULL,
	[NetRate] [float] NULL,
	[Free] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Stock_dummy_item_D] PRIMARY KEY CLUSTERED 
(
	[RowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_SupplierMaster]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_SupplierMaster](
	[Supplierid] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[GSTN] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[DrugLicense] [varchar](50) NULL,
	[ContactPerson] [varchar](50) NULL,
	[Reference] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
	[FirstVisitDate] [varchar](50) NULL,
	[Duration] [varchar](50) NULL,
	[Note] [varchar](50) NULL,
	[PhoneNooff] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[PhoneRes] [varchar](50) NULL,
	[FAX] [varchar](50) NULL,
	[CSTNo] [varchar](50) NULL,
	[Descr] [varchar](50) NULL,
	[VisitDays] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_SupplierMaster] PRIMARY KEY CLUSTERED 
(
	[Supplierid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_User]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tble_privelages]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tble_privelages](
	[PrvID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [varchar](50) NULL,
	[FormID] [varchar](50) NULL,
 CONSTRAINT [PK_Tble_privelages] PRIMARY KEY CLUSTERED 
(
	[PrvID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRIALTRACKER]    Script Date: 8/20/2018 9:37:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIALTRACKER](
	[TRIALSTART] [date] NULL,
	[TRAILENDS] [date] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Tbl_AdminLogin] ON 

INSERT [dbo].[Tbl_AdminLogin] ([AdminID], [UserName], [Password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Tbl_AdminLogin] OFF
SET IDENTITY_INSERT [dbo].[Tbl_BranchMaster] ON 

INSERT [dbo].[Tbl_BranchMaster] ([BranchId], [BrannchName], [Location], [Kgst.No], [PhoneNo]) VALUES (1, N'AKSHAYA COMMUNITY PHARMACY', N'HIGH SCHOOL JN||KOLLAM||KERALA', N'H123J', N'04742477865')
SET IDENTITY_INSERT [dbo].[Tbl_BranchMaster] OFF
SET IDENTITY_INSERT [dbo].[Tbl_ProductMaster] ON 

INSERT [dbo].[Tbl_ProductMaster] ([PrdId], [ProductName], [ManufactureName], [Category], [SubCategory], [GenericName], [Schedule], [RackNo], [MinLevel], [MaxLevel], [HSNCode], [GST], [SubHead]) VALUES (1, N'HORLICKS', N'GSK', N'General', N'', N'H133', N'H12', N'T1', N'100', N'', N'H14254', N'1', N'')
INSERT [dbo].[Tbl_ProductMaster] ([PrdId], [ProductName], [ManufactureName], [Category], [SubCategory], [GenericName], [Schedule], [RackNo], [MinLevel], [MaxLevel], [HSNCode], [GST], [SubHead]) VALUES (2, N'CROSSIN', N'GSK', N'Medical', N'', N'H12', N'H6', N'T2', N'100', N'', N'HKJY66', N'12', N'')
INSERT [dbo].[Tbl_ProductMaster] ([PrdId], [ProductName], [ManufactureName], [Category], [SubCategory], [GenericName], [Schedule], [RackNo], [MinLevel], [MaxLevel], [HSNCode], [GST], [SubHead]) VALUES (3, N'OATS', N'QUIKAR', N'Medical', N'G', N'J7', N'H4', N'T3', N'100', N'', N'HJGHJ', N'5', N'')
SET IDENTITY_INSERT [dbo].[Tbl_ProductMaster] OFF
SET IDENTITY_INSERT [dbo].[tbl_Purchase] ON 

INSERT [dbo].[tbl_Purchase] ([PurchaseID], [SupplierName], [DateofPurchase], [GST], [InvoiceNumber], [InvoiceDate], [Receivedon], [CeditDays], [SetRack], [TMRP1], [TMRP2], [Discount], [AdlDiscount], [Rounding], [Adjustment], [Narration], [GrandTotal], [NetBalance], [AmountforAccounts], [PaidAmount], [Balance]) VALUES (1, N'', N'Saturday, August 11, 2018', N'', N'', N'', N'Saturday, August 11, 2018', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[tbl_Purchase] ([PurchaseID], [SupplierName], [DateofPurchase], [GST], [InvoiceNumber], [InvoiceDate], [Receivedon], [CeditDays], [SetRack], [TMRP1], [TMRP2], [Discount], [AdlDiscount], [Rounding], [Adjustment], [Narration], [GrandTotal], [NetBalance], [AmountforAccounts], [PaidAmount], [Balance]) VALUES (2, N'', N'Saturday, August 11, 2018', N'', N'', N'', N'Saturday, August 11, 2018', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'16', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[tbl_Purchase] OFF
SET IDENTITY_INSERT [dbo].[tbl_purchaseItem] ON 

INSERT [dbo].[tbl_purchaseItem] ([RowId], [ItemNo], [PurchaseID], [ItemName], [ItemDesc], [Company], [Batch], [ExpDate], [Pad], [PQty], [Qy], [Rate], [Discount], [Amount], [SalesRate], [MRP], [Rack], [GST], [HSN Code], [NetRate], [SRate], [Free]) VALUES (1, N'', N'', N'', NULL, N'', N'', N'30/10/2017', NULL, 0, NULL, N'0', N'0', N'0', N'0', 0, N'', 0, N'', 0, NULL, N'')
INSERT [dbo].[tbl_purchaseItem] ([RowId], [ItemNo], [PurchaseID], [ItemName], [ItemDesc], [Company], [Batch], [ExpDate], [Pad], [PQty], [Qy], [Rate], [Discount], [Amount], [SalesRate], [MRP], [Rack], [GST], [HSN Code], [NetRate], [SRate], [Free]) VALUES (2, N'1', N'', N'HORLICKS', NULL, N'GSK', N'H1', N'30/10/2017', NULL, 200, NULL, N'20', N'2', N'4000', N'20.38', 45, N'T1', 2, N'H14254', 20.4, NULL, N'')
INSERT [dbo].[tbl_purchaseItem] ([RowId], [ItemNo], [PurchaseID], [ItemName], [ItemDesc], [Company], [Batch], [ExpDate], [Pad], [PQty], [Qy], [Rate], [Discount], [Amount], [SalesRate], [MRP], [Rack], [GST], [HSN Code], [NetRate], [SRate], [Free]) VALUES (3, N'3', N'2', N'OATS', NULL, N'QUIKAR', N'j7', N'30/10/2017', NULL, 4, NULL, N'4', N'7', N'16', N'4.21', 60, N'T3', 7, N'HJGHJ', 4.28, NULL, N'')
INSERT [dbo].[tbl_purchaseItem] ([RowId], [ItemNo], [PurchaseID], [ItemName], [ItemDesc], [Company], [Batch], [ExpDate], [Pad], [PQty], [Qy], [Rate], [Discount], [Amount], [SalesRate], [MRP], [Rack], [GST], [HSN Code], [NetRate], [SRate], [Free]) VALUES (4, N'', N'3', N'', NULL, N'', N'', N'30/10/2017', NULL, 0, NULL, N'0', N'0', N'0', N'0', 0, N'', 0, N'', 0, NULL, N'')
SET IDENTITY_INSERT [dbo].[tbl_purchaseItem] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Sales] ON 

INSERT [dbo].[Tbl_Sales] ([BillNo], [CustomerName], [Date], [UserID], [DoctorName], [Patient], [Discount], [SalesReturn], [Adj], [Note], [Grandtotal], [CashReceived], [Balance], [ReceivedAmount], [GST], [Profit]) VALUES (3, N'', CAST(N'2018-08-11 00:00:00.000' AS DateTime), N'', N'', N'', N'', N'', N'', N'', 407.6, N'', N'', NULL, NULL, NULL)
INSERT [dbo].[Tbl_Sales] ([BillNo], [CustomerName], [Date], [UserID], [DoctorName], [Patient], [Discount], [SalesReturn], [Adj], [Note], [Grandtotal], [CashReceived], [Balance], [ReceivedAmount], [GST], [Profit]) VALUES (4, N'', CAST(N'2018-08-11 00:00:00.000' AS DateTime), N'', N'', N'', N'', N'', N'', N'', 1589.64, N'', N'', NULL, NULL, NULL)
INSERT [dbo].[Tbl_Sales] ([BillNo], [CustomerName], [Date], [UserID], [DoctorName], [Patient], [Discount], [SalesReturn], [Adj], [Note], [Grandtotal], [CashReceived], [Balance], [ReceivedAmount], [GST], [Profit]) VALUES (5, N'', CAST(N'2018-08-08 00:00:00.000' AS DateTime), N'', N'', N'', N'', N'', N'', N'', 12.63, N'', N'', NULL, NULL, NULL)
INSERT [dbo].[Tbl_Sales] ([BillNo], [CustomerName], [Date], [UserID], [DoctorName], [Patient], [Discount], [SalesReturn], [Adj], [Note], [Grandtotal], [CashReceived], [Balance], [ReceivedAmount], [GST], [Profit]) VALUES (6, N'', CAST(N'2018-08-11 00:00:00.000' AS DateTime), N'', N'', N'', N'', N'', N'', N'', 285.32, N'300', N'14.68', NULL, NULL, NULL)
INSERT [dbo].[Tbl_Sales] ([BillNo], [CustomerName], [Date], [UserID], [DoctorName], [Patient], [Discount], [SalesReturn], [Adj], [Note], [Grandtotal], [CashReceived], [Balance], [ReceivedAmount], [GST], [Profit]) VALUES (7, N'', CAST(N'2018-08-11 00:00:00.000' AS DateTime), N'', N'', N'', N'', N'', N'', N'', 917.1, N'1000', N'82.9', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Sales] OFF
SET IDENTITY_INSERT [dbo].[Tbl_SalesItem] ON 

INSERT [dbo].[Tbl_SalesItem] ([SlNo], [ItemNo], [BillNo], [ItemName], [Company], [Qty], [Batch], [Exp], [GST], [MRP], [Rate], [Amount], [Rack], [Total], [SGST], [Discount], [NetRate], [HSNCode], [SalesRate], [Free]) VALUES (3, 1, 0, N'HORLICKS', N'GSK', 20, N'H1', N'30/10/2017', 2, 45.0000, 20.3800, NULL, NULL, 407.6000, NULL, 2, NULL, N'H14254', NULL, NULL)
INSERT [dbo].[Tbl_SalesItem] ([SlNo], [ItemNo], [BillNo], [ItemName], [Company], [Qty], [Batch], [Exp], [GST], [MRP], [Rate], [Amount], [Rack], [Total], [SGST], [Discount], [NetRate], [HSNCode], [SalesRate], [Free]) VALUES (4, 1, 4, N'HORLICKS', N'GSK', 78, N'H1', N'30/10/2017', 2, 45.0000, 20.3800, NULL, NULL, 1589.6400, NULL, 2, NULL, N'H14254', NULL, NULL)
INSERT [dbo].[Tbl_SalesItem] ([SlNo], [ItemNo], [BillNo], [ItemName], [Company], [Qty], [Batch], [Exp], [GST], [MRP], [Rate], [Amount], [Rack], [Total], [SGST], [Discount], [NetRate], [HSNCode], [SalesRate], [Free]) VALUES (5, 3, 5, N'OATS', N'QUIKAR', 3, N'j7', N'30/10/2017', 7, 60.0000, 4.2100, NULL, NULL, 12.6300, NULL, 7, NULL, N'HJGHJ', NULL, NULL)
INSERT [dbo].[Tbl_SalesItem] ([SlNo], [ItemNo], [BillNo], [ItemName], [Company], [Qty], [Batch], [Exp], [GST], [MRP], [Rate], [Amount], [Rack], [Total], [SGST], [Discount], [NetRate], [HSNCode], [SalesRate], [Free]) VALUES (6, 1, 6, N'HORLICKS', N'GSK', 7, N'H1', N'30/10/2017', 2, 45.0000, 20.3800, NULL, NULL, 142.6600, NULL, 2, NULL, N'H14254', NULL, NULL)
INSERT [dbo].[Tbl_SalesItem] ([SlNo], [ItemNo], [BillNo], [ItemName], [Company], [Qty], [Batch], [Exp], [GST], [MRP], [Rate], [Amount], [Rack], [Total], [SGST], [Discount], [NetRate], [HSNCode], [SalesRate], [Free]) VALUES (7, 1, 6, N'HORLICKS', N'GSK', 7, N'H1', N'30/10/2017', 2, 45.0000, 20.3800, NULL, NULL, 142.6600, NULL, 2, NULL, N'H14254', NULL, NULL)
INSERT [dbo].[Tbl_SalesItem] ([SlNo], [ItemNo], [BillNo], [ItemName], [Company], [Qty], [Batch], [Exp], [GST], [MRP], [Rate], [Amount], [Rack], [Total], [SGST], [Discount], [NetRate], [HSNCode], [SalesRate], [Free]) VALUES (8, 1, 7, N'HORLICKS', N'GSK', 45, N'H1', N'30/10/2017', 2, 45.0000, 20.3800, NULL, NULL, 917.1000, NULL, 2, NULL, N'H14254', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tbl_SalesItem] OFF
SET IDENTITY_INSERT [dbo].[tbl_Stock] ON 

INSERT [dbo].[tbl_Stock] ([RowId], [ItemNo], [PurchaseID], [ItemName], [ItemDesc], [Company], [Batch], [ExpDate], [Pad], [PQty], [Qy], [Rate], [Discount], [Amount], [SalesRate], [MRP], [Rack], [SGST], [HSN Code], [NetRate], [SRate], [Free]) VALUES (1, N'', N'', N'', NULL, N'', N'', N'30/10/2017', NULL, 0, NULL, N'0', N'0', N'0', N'0', 0, N'', 0, N'', 0, NULL, N'')
INSERT [dbo].[tbl_Stock] ([RowId], [ItemNo], [PurchaseID], [ItemName], [ItemDesc], [Company], [Batch], [ExpDate], [Pad], [PQty], [Qy], [Rate], [Discount], [Amount], [SalesRate], [MRP], [Rack], [SGST], [HSN Code], [NetRate], [SRate], [Free]) VALUES (2, N'1', N'', N'HORLICKS', NULL, N'GSK', N'H1', N'30/10/2017', NULL, 0, NULL, N'20', N'2', N'4000', N'20.38', 45, N'T1', 2, N'H14254', 20.4, NULL, N'')
INSERT [dbo].[tbl_Stock] ([RowId], [ItemNo], [PurchaseID], [ItemName], [ItemDesc], [Company], [Batch], [ExpDate], [Pad], [PQty], [Qy], [Rate], [Discount], [Amount], [SalesRate], [MRP], [Rack], [SGST], [HSN Code], [NetRate], [SRate], [Free]) VALUES (3, N'3', N'2', N'OATS', NULL, N'QUIKAR', N'j7', N'30/10/2017', NULL, 1, NULL, N'4', N'7', N'16', N'4.21', 60, N'T3', 7, N'HJGHJ', 4.28, NULL, N'')
SET IDENTITY_INSERT [dbo].[tbl_Stock] OFF
SET IDENTITY_INSERT [dbo].[Tbl_User] ON 

INSERT [dbo].[Tbl_User] ([UserID], [Name], [Address], [Username], [Password]) VALUES (1, N'psp', N'psp', N'psp', N'psp')
SET IDENTITY_INSERT [dbo].[Tbl_User] OFF
SET IDENTITY_INSERT [dbo].[Tble_privelages] ON 

INSERT [dbo].[Tble_privelages] ([PrvID], [UserID], [FormID]) VALUES (1, N'1', N'1')
INSERT [dbo].[Tble_privelages] ([PrvID], [UserID], [FormID]) VALUES (2, N'1', N'2')
INSERT [dbo].[Tble_privelages] ([PrvID], [UserID], [FormID]) VALUES (3, N'1', N'3')
INSERT [dbo].[Tble_privelages] ([PrvID], [UserID], [FormID]) VALUES (4, N'1', N'4')
INSERT [dbo].[Tble_privelages] ([PrvID], [UserID], [FormID]) VALUES (5, N'1', N'5')
INSERT [dbo].[Tble_privelages] ([PrvID], [UserID], [FormID]) VALUES (6, N'1', N'6')
INSERT [dbo].[Tble_privelages] ([PrvID], [UserID], [FormID]) VALUES (7, N'1', N'7')
INSERT [dbo].[Tble_privelages] ([PrvID], [UserID], [FormID]) VALUES (8, N'1', N'8')
SET IDENTITY_INSERT [dbo].[Tble_privelages] OFF
/****** Object:  StoredProcedure [dbo].[adminlogin]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[adminlogin]
	@username varchar(50),
	@password varchar(50)
AS
	SELECT AdminID  from Tbl_AdminLogin where UserName=@username and Password=@password
RETURN 0



GO
/****** Object:  StoredProcedure [dbo].[autoTextbox_companyname_Purchase]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[autoTextbox_companyname_Purchase]
	
AS
	SELECT ManufactureName FROM Tbl_ProductMaster
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[autoTextbox_itemname_Purchase]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[autoTextbox_itemname_Purchase]
	
AS
	SELECT ProductName FROM Tbl_ProductMaster
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[autoTextbox_sales]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[autoTextbox_sales]

AS
	SELECT ProductName FROM Tbl_ProductMaster
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[billincrement_sales]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[billincrement_sales]

AS
	select BillNo from  Tbl_Sales
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[BranchMaster_Delete]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BranchMaster_Delete]
	@BrachID int,
	@branchname  varchar(Max),
	@location varchar(max),
	@kgstno varchar(max),
	@phoneno varchar(50)
AS
begin
	Delete from Tbl_BranchMaster where BranchId=@BrachID
	end
RETURN 0


GO
/****** Object:  StoredProcedure [dbo].[BranchMaster_insertEdit]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BranchMaster_insertEdit]
	
	        @branchname varchar(max),
			@location varchar(max),
           @kgstno varchar(max),
           @phoneno varchar(max)
            
AS
BEGIN
	INSERT INTO Tbl_BranchMaster (BrannchName,Location,[Kgst.No],PhoneNo)
	VALUES  (@branchname,@location,@kgstno,@phoneno)
END





GO
/****** Object:  StoredProcedure [dbo].[BranchMaster_Update]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BranchMaster_Update]
	@BrachID int,
	@branchname  varchar(Max),
	@location varchar(max),
	@kgstno varchar(max),
	@phoneno varchar(50)
AS
begin
	Update Tbl_BranchMaster set BrannchName=@branchname,Location=@location,[Kgst.No]=@kgstno,PhoneNo=@phoneno where BranchId=@BrachID
	end
RETURN 0


GO
/****** Object:  StoredProcedure [dbo].[BranchMasterDataGridDisplay]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BranchMasterDataGridDisplay]
	
AS
	SELECT BrannchName,Location,[Kgst.No],PhoneNo from Tbl_BranchMaster
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[DeleteItemandStockupdatein_Purchase]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteItemandStockupdatein_Purchase] 
@Itemname  varchar(50),
   @Batch varchar(50),
   @Quantity float
   
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete  from tbl_Stock_dummy where ItemName=@Itemname and Batch=@Batch and PQty=@Quantity
	
	update tbl_Stock set PQty=PQty-@Quantity where ItemName=@Itemname and Batch=@Batch
END 


GO
/****** Object:  StoredProcedure [dbo].[DeleteItemandStockupdatein_Sales]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteItemandStockupdatein_Sales]
	-- Add the parameters for the stored procedure here
   @Itemname  varchar(50),
   @Batch varchar(50),
   @Quantity float,
   @billno varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete  from Tbl_SalesItem_DUMMY where ItemName=@Itemname and Batch=@Batch and QUANTITY=@Quantity
	delete from Tbl_SalesItem where ItemName=@Itemname and Batch=@Batch and Qty=@Quantity and BillNo=@billno
	update tbl_Stock set PQty=PQty+@Quantity where ItemName=@Itemname and Batch=@Batch
END


GO
/****** Object:  StoredProcedure [dbo].[DisplayData_Purchase]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DisplayData_Purchase]
	
AS
	select ItemName,Company,Batch,ExpDate,PQty,Rate,MRP,Rack,SGST,Discount,NetRate,HSNcode,SalesRate,Amount,Free from tbl_Stock_dummy 
RETURN 0



GO
/****** Object:  StoredProcedure [dbo].[DisplayDatagridBranchMaster]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DisplayDatagridBranchMaster]
	
AS
	select BranchId,BrannchName,Location,[Kgst.No],PhoneNo from Tbl_BranchMaster 
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[DisplayStock]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DisplayStock] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from tbl_Stock
END


GO
/****** Object:  StoredProcedure [dbo].[fetch_outofstockfromproductmaster]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[fetch_outofstockfromproductmaster]
	-- Add the parameters for the stored procedure here
	@itemname varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MinLevel from Tbl_ProductMaster where ProductName=@itemname
END


GO
/****** Object:  StoredProcedure [dbo].[FetchdatafromPurchaseReturnDisplay]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FetchdatafromPurchaseReturnDisplay]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT SupplierName,ItemName,Company,Batch,Reason,Amount,Quantity from Tbl_PurchaseReturnDisplay
END


GO
/****** Object:  StoredProcedure [dbo].[FetchHsnCode]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FetchHsnCode]
	@itemname varchar(50)
	AS
	SELECT HSNCode,RackNo,GST,ManufactureName from Tbl_ProductMaster where ProductName=@itemname
RETURN 0

GO
/****** Object:  StoredProcedure [dbo].[FetchItemNo]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FetchItemNo]
	-- Add the parameters for the stored procedure here
	@productname varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT PrdId from Tbl_ProductMaster where ProductName=@productname
END


GO
/****** Object:  StoredProcedure [dbo].[FetchQuantityfromstock]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FetchQuantityfromstock] 
	-- Add the parameters for the stored procedure here
	@itemname varchar(50),
	@Batch varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT PQty from tbl_Stock where ItemName=@itemname and Batch=@Batch
END


GO
/****** Object:  StoredProcedure [dbo].[FETCHSALESREPORTDATAGRID]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FETCHSALESREPORTDATAGRID]
	-- Add the parameters for the stored procedure here
	@from varchar
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  Tbl_Sales.BillNo,Tbl_Sales.Date,Tbl_Sales.Grandtotal,Tbl_SalesItem.ItemName,Tbl_SalesItem.ItemNo,Tbl_SalesItem.Qty FROM Tbl_Sales INNER JOIN Tbl_SalesItem  ON Tbl_Sales.BillNo = Tbl_SalesItem.BillNo where Tbl_Sales.Date=@from 
END


GO
/****** Object:  StoredProcedure [dbo].[FetchSupplierDetailswithsuppliierId]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FetchSupplierDetailswithsuppliierId]
	@supplierid int

AS
	SELECT SupplierName,Address,Email,GSTN,Type,DrugLicense,ContactPerson,Reference,Description,FirstVisitDate,Duration,Note,PhoneNooff,Mobile,PhoneRes,FAX,CSTNo,Descr,VisitDays from Tbl_SupplierMaster where Supplierid=@supplierid
RETURN 0





GO
/****** Object:  StoredProcedure [dbo].[insert_into_Tablestockdummy]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insert_into_Tablestockdummy]
@purchaseid varchar(50),
@itemno varchar(50),
            @itemname varchar(50),
            @company varchar(50),
            @batch varchar(50),
            @expdate varchar(50),
            @pqty int,
            @rate float,
            @amount float,
			@Discount float,
			@MRP FLOAT,
			@Rack varchar(50),
			@SGST float,
			@HSNcode varchar(50),@NetRate float,@Srate float,@Free varchar(50)

AS
begin
insert into tbl_purchaseItem(PurchaseID,ItemNo,ItemName,Company,Batch,ExpDate,PQty,Rate,Amount,Discount,MRP,Rack,GST,[HSN Code],NetRate,SalesRate,Free)values(@purchaseid,@itemno,@itemname,@company,@batch,@expdate,@pqty,@rate,@amount,@Discount,@MRP,@Rack,@SGST,@HSNcode,@NetRate,@Srate,@Free)
end

begin
	insert into tbl_Stock_dummy(PurchaseID,ItemNo,ItemName,Company,Batch,ExpDate,PQty,Rate,Amount,Discount,MRP,Rack,SGST,HSNcode,NetRate,SalesRate,Free)values(@purchaseid,@itemno,@itemname,@company,@batch,@expdate,@pqty,@rate,@amount,@Discount,@MRP,@Rack,@SGST,@HSNcode,@NetRate,@Srate,@Free)
end
if exists(select 1 from tbl_Stock where ItemNo=@itemno and Batch=@batch)
begin
update tbl_Stock set PQty=PQty+@pqty where ItemNo=@itemno AND Batch=@batch
end
else 
begin
	insert into tbl_Stock(PurchaseID,ItemNo,ItemName,Company,Batch,ExpDate,PQty,Rate,Amount,Discount,MRP,Rack,SGST,[HSN Code],NetRate,SalesRate,Free)values(@purchaseid,@itemno,@itemname,@company,@batch,@expdate,@pqty,@rate,@amount,@Discount,@MRP,@Rack,@SGST,@HSNcode,@NetRate,@Srate,@Free)
end


RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[InsertIntoPurchaseReturnDisplay]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:

CREATE PROCEDURE [dbo].[InsertIntoPurchaseReturnDisplay]
	-- Add the parameters for the stored procedure here
	@SupplierName varchar(50),
	@ItemName varchar(50),
	@CompanyName varchar(50),
	@Reason varchar(50),
	@Batch varchar(50),
	@Rate float,
	@Quantity float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Tbl_PurchaseReturnDisplay(SupplierName,ItemName,Company,Batch,Reason,Amount,Quantity) values(@SupplierName,@ItemName,@CompanyName,@Batch,@Reason,@Rate,@Quantity)

END
Begin 
 delete from tbl_Stock where ItemName=@ItemName and Batch=@Batch
 end 

GO
/****** Object:  StoredProcedure [dbo].[insertintosalesdummy_Sales]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertintosalesdummy_Sales]
 @itemno varchar(50),
 @billno varchar(50),
 
            @itemname varchar(50),
            @batch varchar(50),
            @exp varchar(50),
            @qty varchar(50),
            @rate varchar(50),
            @total float,
			@MRP FLOAT,
			@Discount float,
			@SGST float,
			@HSNCode varchar(50),
			@Company varchar(50)
AS
	INSERT INTO Tbl_SalesItem_DUMMY (ItemNo,BillNo,Company,ItemName,Batch,[EXP DATE],QUANTITY,Rate,Total,MRP,Discount,GST,HSNCode)VALUES(@itemno,@billno,@Company,@itemname,@batch,@exp,@qty,@rate,@total,@MRP,@Discount,@SGST,@HSNCode)
	update tbl_Stock set PQty=PQty-@qty where ItemNo=@itemno and Batch=@batch
	INSERT INTO Tbl_SalesItem(ItemNo,BillNo,Company,Batch,ItemName,Exp,Qty,Rate,Total,MRP,Discount,GST,HSNCode)VALUES(@itemno,@billno,@Company,@batch,@itemname,@exp,@qty,@rate,@total,@MRP,@Discount,@SGST,@HSNCode)
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[InsertIntoTableSalesReturnDisplay]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertIntoTableSalesReturnDisplay]
	-- Add the parameters for the stored procedure here
    
	@Date varchar(50),
   
   -- @SupplierName varchar(50),
	@ItemName varchar(50),
	@CompanyName varchar(50),
	@Batch varchar(50),
	@Quantity	varchar(50),
	@Rate float,
	@ReturnTo varchar(50),
	@Total float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into SalesReturnDisplay(Date,ItemName,CompanyName,Batch,Quantity,Rate,ReturnTo,Total)values(@Date,@ItemName,@CompanyName,@Batch,@Quantity,@Rate,@ReturnTo,@Total)
	insert into SalesReturn(Date,ItemName,CompanyName,Batch,Quantity,Rate,ReturnTo,Total)values(@Date,@ItemName,@CompanyName,@Batch,@Quantity,@Rate,@ReturnTo,@Total)

END
if exists(select 1 from tbl_Stock where ItemName=@ItemName and Batch=@Batch)
begin
update tbl_Stock set PQty=PQty+@Quantity where ItemName=@ItemName and Batch=@Batch
end

GO
/****** Object:  StoredProcedure [dbo].[insertsalesitem_sales]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertsalesitem_sales]
@billno varchar(50) ,
@itemname varchar(50) ,
@batch varchar(50) ,
@exp varchar(50) ,
@rate varchar(50) ,
@total varchar(50) ,
@qty  varchar(50)
AS
	INSERT INTO Tbl_SalesItem (BillNo,ItemName,Batch,Exp,Qty,Rate,Total)VALUES(@billno,@itemname,@batch,@exp,@qty,@rate,@total)
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[InsertToPurchaseReturn]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertToPurchaseReturn] 
	-- Add the parameters for the stored procedure here
	@SupplierName varchar(50),
	@ItemName varchar(50),
	@CompanyName varchar(50),
	@Reason varchar(50),
	@Batch varchar(50),
	@Rate float,

	@PurchaseId varchar(50),
	@Date varchar(50),
	--@Total float,-->
	@ReturnTo varchar(50),
	@Quantity float


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Tbl_PurchaseReturn(SupplierName,ItemName,CompanyName,Batch,Reason,Rate,PurchaseID,Date,ReturnTo,Quantity) values(@SupplierName,@ItemName,@CompanyName,@Batch,@Reason,@Rate,@PurchaseId,@Date,@ReturnTo,@Quantity)
END


GO
/****** Object:  StoredProcedure [dbo].[insertuserdetails]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[insertuserdetails]
	@Name varchar(50),
	@Address varchar(50),
	@UserName varchar(50),
	@UserPassword varchar(50)
	as begin
	insert into Tbl_User(Name,Address,Username,Password)values(@Name,@Address,@UserName,@UserPassword)
	end



GO
/****** Object:  StoredProcedure [dbo].[itemautoTxtbox_Leave_Sales]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[itemautoTxtbox_Leave_Sales]
@itemname varchar(50)
AS
	select ItemNo ,Batch,ExpDate,Rate,SGST,MRP,Rack,Discount,Company,[HSN Code],SalesRate from  Tbl_Stock where ItemName=@itemname
RETURN 0

GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[login]
	@username varchar(50),
	@password varchar(50)
AS
	select UserID  from Tbl_User where Username=@username and Password=@password
RETURN 0



GO
/****** Object:  StoredProcedure [dbo].[Manufacturer_DeleteData]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Manufacturer_DeleteData]
	@manufacturerMid int
AS
	delete from ManufacturerMaster where Mid=@manufacturerMid
RETURN 0


GO
/****** Object:  StoredProcedure [dbo].[Manufacturer_Master_insert]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Manufacturer_Master_insert]
@manufacturername varchar (50),
@manufacturerid varchar (50)
as begin
insert into ManufacturerMaster(Manufacturer_Id,Manufacturer_Name)values(@manufacturername,@manufacturerid)
end 



GO
/****** Object:  StoredProcedure [dbo].[Manufacturer_UpdateDateInTable]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Manufacturer_UpdateDateInTable]
	@manufacturerId varchar(50),
	@manufacturerName varchar(50),
	@manufacturerMid int
AS
	UPDATE ManufacturerMaster SET  
Manufacturer_Id = @manufacturerId, Manufacturer_Name =@manufacturerName
WHERE Mid = @manufacturerMid  
RETURN 0



GO
/****** Object:  StoredProcedure [dbo].[ManufacturermasterDataGridDisplay]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ManufacturermasterDataGridDisplay]

AS
	select Mid,Manufacturer_Name,Manufacturer_Id from ManufacturerMaster
	return 0




GO
/****** Object:  StoredProcedure [dbo].[OutofStockReporting]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OutofStockReporting]
AS
Begin
	SELECT ItemNo,ItemName,Batch,PQty,Company from tbl_Stock where PQty <=50
end


GO
/****** Object:  StoredProcedure [dbo].[privelage_retrive_formid]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[privelage_retrive_formid]
	@userid varchar(50)
AS
	SELECT FormID from Tble_privelages where UserID=@userid
RETURN 0



GO
/****** Object:  StoredProcedure [dbo].[privelages_according_to_user]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[privelages_according_to_user]
	@username varchar(50)
AS
	select UserID from Tbl_User where Username=@username
	
	
	Return


GO
/****** Object:  StoredProcedure [dbo].[ProductMaster_Delete]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductMaster_Delete]
	@PID Int
AS
	DELETE Tbl_ProductMaster where PrdId=@PID
RETURN 0


GO
/****** Object:  StoredProcedure [dbo].[ProductMaster_proc]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductMaster_proc]
	
	       
@productname varchar(50),

           
          @manaufaturername varchar(50),
		  @subcategory varchar(50),
           @category varchar(50),
        @genericname varchar(50),
          @shedule varchar(50),
           @date varchar(50),
           @minlevel varchar(50),
            @maxlevel varchar(50),
         @hsn varchar(50),
           @gst varchar(50),
           @sunhead varchar(50)
            
AS
BEGIN
	INSERT INTO Tbl_ProductMaster(ProductName,ManufactureName,Category,SubCategory,GenericName,Schedule,RackNo,MinLevel,Maxlevel,HSNCode,GST,SubHead)
	                 VALUES(@productname,@manaufaturername,@category,@subcategory,@genericname,@shedule,@date, @minlevel, @maxlevel, @hsn, @gst,@sunhead)
END






GO
/****** Object:  StoredProcedure [dbo].[ProductMaster_Update]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductMaster_Update]
	@productname varchar(50),
	@PID INT,
           
          @manaufaturername varchar(50),
		  @subcategory varchar(50),
           @category varchar(50),
        @genericname varchar(50),
          @shedule varchar(50),
           @date varchar(50),
           @minlevel varchar(50),
            @maxlevel varchar(50),
         @hsn varchar(50),
           @gst varchar(50),
           @sunhead varchar(50)
            
AS
	update Tbl_ProductMaster set ProductName=@productname,ManufactureName=@manaufaturername,SubCategory=@subcategory,Category=@category,GenericName=@genericname,Schedule=@shedule,RackNo=@date,MinLevel=@minlevel,MaxLevel=@maxlevel,HSNCode=@hsn,GST=@gst,SubHead=@sunhead where PrdId=@PID
RETURN 0


GO
/****** Object:  StoredProcedure [dbo].[ProductMasterDatagridDisplay]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductMasterDatagridDisplay]

AS
	select PrdId, ProductName,ManufactureName,Category,SubCategory,GenericName,Schedule,RackNo,MinLevel,Maxlevel,HSNCode,GST,SubHead from Tbl_ProductMaster
RETURN 0

GO
/****** Object:  StoredProcedure [dbo].[Purchase_Details]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Purchase_Details]
	
	      /* @purchaseid varchar(50),*/
			@tmrp varchar(50),

            @suppliername varchar(50),
            @invoiceno varchar(50),
            @receivedon varchar(50),
            @date  varchar(50),
            @creditdate varchar(50),
            @gstn varchar(50),
            @invoicedate varchar(50),
            @discount varchar(50),
            @addldiscount varchar(50),
            @rounding varchar(50),
            @adjustment varchar(50),
            @narration varchar(50),
            @grandtotal varchar(50),
            @netbalance varchar(50),
            @accountforaccounts varchar(50),
            @paidamt varchar(50),
            @balance varchar(50),
			@tmrp2  varchar(50),
			@setrack varchar(50)
AS
BEGIN
	INSERT INTO tbl_Purchase(TMRP1,SupplierName,InvoiceNumber,Receivedon,DateofPurchase,CeditDays,SetRack,gst,InvoiceDate,Discount,AdlDiscount,Rounding,Adjustment,Narration,GrandTotal,NetBalance,AmountforAccounts,PaidAmount,Balance,TMRP2)
	                 VALUES(@tmrp,@suppliername,@invoiceno,@receivedon,@date,@creditdate,@setrack, @gstn, @invoicedate, @discount, @addldiscount,@rounding,@adjustment,@narration,@grandtotal,@netbalance,@accountforaccounts,@paidamt,@balance,@tmrp2)
END






GO
/****** Object:  StoredProcedure [dbo].[PurchaseGst]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PurchaseGst]
	
AS
	SELECT *from tbl_purchaseItem
RETURN 0


GO
/****** Object:  StoredProcedure [dbo].[purchaseidincrement_Purchase]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[purchaseidincrement_Purchase]
	
AS
	select PurchaseID from  tbl_Purchase
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[purchasereturn_pid]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[purchasereturn_pid]
@Purchaseid Varchar
AS
	SELECT ItemName,Company,Batch,Rate from tbl_purchaseItem  where PurchaseID=@Purchaseid
RETURN 0


GO
/****** Object:  StoredProcedure [dbo].[PurchaseReturnDisplay]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PurchaseReturnDisplay]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT SupplierName,ItemName,Company,Batch,Reason,Amount,Quantity from Tbl_PurchaseReturnDisplay
END


GO
/****** Object:  StoredProcedure [dbo].[PurchaseReturnIdFetch]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PurchaseReturnIdFetch] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Purchase_ReturnID from Tbl_PurchaseReturn
End


GO
/****** Object:  StoredProcedure [dbo].[PurchaseReturnonBatch]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PurchaseReturnonBatch]
	-- Add the parameters for the stored procedure here
	@SupplierName varchar(50),
	@ItemName varchar(50),
	@CompanyName varchar(50),
	@Reason varchar(50),
	@Batch varchar(50),
	@Rate float,
	@Quantity float
AS
BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Tbl_PurchaseReturnDisplay(SupplierName,ItemName,Company,Batch,Reason,Amount,Quantity) values(@SupplierName,@ItemName,@CompanyName,@Batch,@Reason,@Rate,@Quantity)

END
Begin 
 update tbl_Stock set PQty=PQty-@Quantity where ItemName=@ItemName and Batch=@Batch
 end 




GO
/****** Object:  StoredProcedure [dbo].[PurchaseReturnReportFetch]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PurchaseReturnReportFetch]
	-- Add the parameters for the stored procedure here
	 @FromDate date,
	 @ToDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	SELECT Purchase_ReturnID,PurchaseID,Date,SupplierName,ItemName,CompanyName,Batch,Reason,Rate,Total,ReturnTo,Quantity from Tbl_PurchaseReturn where Date between @FromDate and @ToDate
end 


GO
/****** Object:  StoredProcedure [dbo].[ReadfromDummyTbl_Purchase]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReadfromDummyTbl_Purchase]
	
AS
	SELECT  PurchaseID,ItemName,Company,PQty,Batch,ExpDate,Rate FROM tbl_Stock_dummy 
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[ReturnIdREtrieve]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ReturnIdREtrieve]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ReturnID from SalesReturn
	End


GO
/****** Object:  StoredProcedure [dbo].[Sales_insert_bill]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sales_insert_bill]
	      
			 @customername varchar(50),

            
            @date date,
             @username varchar(50),
              @doctor varchar(50),
            @patient varchar(50),
            @cashdiscount varchar(50),
            @salesreturn varchar(50),
            @notes varchar(50),
            @adj varchar(50),
            @grandtotal varchar(50),
            @cashreceived varchar(50),
            
            @balance varchar(50)
            
AS
BEGIN
    
	INSERT INTO Tbl_Sales(CustomerName,Date,UserID,DoctorName,Patient,Discount,SalesReturn,Note,Adj,Grandtotal,CashReceived,Balance)
	                 VALUES(@customername,@date,@username,@doctor,@patient,@cashdiscount,@salesreturn, @notes, @adj, @grandtotal, @cashreceived,@balance)

END
/*TRUNCATE TABLE  Tbl_SalesItem_DUMMY***/







GO
/****** Object:  StoredProcedure [dbo].[SalesReportFetch]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SalesReportFetch]
	-- Add the parameters for the stored procedure here
	@FromDate date,
	@ToDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT BillNo,Date,Grandtotal  from Tbl_Sales where Date between @FromDate and @ToDate 
END

GO
/****** Object:  StoredProcedure [dbo].[SalesReturnBillFetch]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalesReturnBillFetch]
	@BillNo varchar(50)
AS
	SELECT ItemName,Company,Batch,Qty,Rate from Tbl_SalesItem where BillNo=@BillNo
RETURN 0


GO
/****** Object:  StoredProcedure [dbo].[SalesReturnReportFetch]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SalesReturnReportFetch] 
	-- Add the parameters for the stored procedure here
	@FromDate varchar(50),
	@ToDate varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ReturnID,ItemName,Date,Batch,Rate,Quantity,ReturnTo from SalesReturn where Date between @FromDate and @ToDate
END


GO
/****** Object:  StoredProcedure [dbo].[setprivilageforuser]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[setprivilageforuser] 
	
	@userId varchar(50),
	@salescheck varchar(50),
	@purchase varchar(50),
	@productmaster varchar(50),

	@manufacturermaster varchar(50),
	@branchmaster varchar(50),
	@supplier varchar(50),
	@salesreport varchar(50),
	@accounts varchar(50)
AS
BEGIN
	

 
	insert into Tble_privelages(UserID,FormID)values(@userId,@salescheck)
	insert into Tble_privelages(UserID,FormID)values(@userId,@purchase)
	insert into Tble_privelages(UserID,FormID)values(@userId ,@productmaster)
	insert into Tble_privelages(UserID,FormID)values(@userId,@manufacturermaster)
	insert into Tble_privelages(UserID,FormID)values(@userId,@branchmaster)
	insert into Tble_privelages(UserID,FormID)values(@userId,@supplier)
	insert into Tble_privelages(UserID,FormID)values(@userId,@salesreport)
	insert into Tble_privelages(UserID,FormID)values(@userId,@accounts)


END



GO
/****** Object:  StoredProcedure [dbo].[StockUpDateitemBatchRetreive]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[StockUpDateitemBatchRetreive]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ItemName,Batch from Tbl_PurchaseReturn
END


GO
/****** Object:  StoredProcedure [dbo].[sumfromdummyStock]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sumfromdummyStock]

AS
	select SUM(Amount)from tbl_Stock_dummy
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[sumtotal_PurchaseReturn]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sumtotal_PurchaseReturn]
 
AS
	select SUM(Amount )from Tbl_PurchaseReturnDisplay
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[sumtotal_Sales]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sumtotal_Sales]
 
AS
	select SUM(Total )from Tbl_SalesItem_DUMMY
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[SupplierAutoText_Purchase]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SupplierAutoText_Purchase]
	
AS
	SELECT SupplierName FROM Tbl_SupplierMaster
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[SupplierMaster]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SupplierMaster]
@suppliername varchar(50),
@address varchar(50),
@email varchar(50),
@gnst varchar(50),
@type varchar(50),
@druglic varchar(50),
@contactpers varchar(50),
@reference varchar(50),
@description varchar(50),
@firstvisitdate varchar(50),
@duration varchar(50),
@note varchar(50),
@phoneoffi varchar(50),
@phoneres varchar(50),
@mobile varchar(50),
@fax varchar(50),
@cst varchar(50),
@descr varchar(50),
@visitdays varchar(50)
as begin 
insert into Tbl_SupplierMaster(SupplierName,Address,Email,GSTN,type,DrugLicense,ContactPerson,Reference,Description,FirstVisitDate,Duration,Note,PhoneNooff,Mobile,PhoneRes,FAX,CSTNo,Descr,VisitDays)values(@suppliername,@address,@email,@gnst,@type,@druglic,@contactpers,@reference,@description,@firstvisitdate,@duration,@note,@phoneoffi,@phoneres,@mobile,@fax,@cst,@descr,@visitdays)
end



GO
/****** Object:  StoredProcedure [dbo].[SupplierMaster_Delete]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SupplierMaster_Delete]
	@supplierid int
AS
	delete from Tbl_SupplierMaster where Supplierid=@supplierid
RETURN 0


GO
/****** Object:  StoredProcedure [dbo].[SupplierMaster_Update]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SupplierMaster_Update]
@supplierid int,
	@suppliername varchar(50),
@address varchar(50),
@email varchar(50),
@gnst varchar(50),
@type varchar(50),
@druglic varchar(50),
@contactpers varchar(50),
@reference varchar(50),
@description varchar(50),
@firstvisitdate varchar(50),
@duration varchar(50),
@note varchar(50),
@phoneoffi varchar(50),
@phoneres varchar(50),
@mobile varchar(50),
@fax varchar(50),
@cst varchar(50),
@descr varchar(50),
@visitdays varchar(50)
as begin 
update  Tbl_SupplierMaster set SupplierName=@suppliername,Address=@address,Email=@email,GSTN=@gnst,Type=@type,DrugLicense=@druglic,ContactPerson=@contactpers,Reference=@reference,Description=@description,FirstVisitDate=@firstvisitdate,Duration=@duration,Note=@note,PhoneNooff=@phoneoffi,PhoneRes=@phoneres,Mobile=@mobile,FAX=@fax,CSTNo=@cst,Descr=@descr,VisitDays=@visitdays where Supplierid=@supplierid
end

GO
/****** Object:  StoredProcedure [dbo].[Tbl_SalesItem_DUMMY_sales]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Tbl_SalesItem_DUMMY_sales]

AS
	select  ITEMNAME,HSNCODE,COMPANY,BATCH,[EXP DATE],QUANTITY,RATE,MRP,GST,DISCOUNT,TOTAL from Tbl_SalesItem_DUMMY
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[tbl_Stockinsertfromdummy_purchase]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery20.sql|7|0|C:\Users\PRANAV~1\AppData\Local\Temp\~vsD65A.sql
CREATE PROCEDURE [dbo].[tbl_Stockinsertfromdummy_purchase]
	@purchaseid varchar(50),

	@itemname varchar(50),
	@qty varchar(50),
	@batch varchar(50),
	@expd varchar(50),
	@rate varchar(50)
AS
	insert into tbl_Stock (PurchaseID,ItemName,PQty,Batch,ExpDate,Rate)values(@purchaseid,@itemname,@qty,@batch,@expd,@rate) 
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[tblSalesReturnDisplay]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[tblSalesReturnDisplay]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ItemName,CompanyName,Batch,Quantity,Rate from SalesReturnDisplay
END

GO
/****** Object:  StoredProcedure [dbo].[TrailTracker]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TrailTracker]
	-- Add the parameters for the stored procedure here
	@trailstart  date,
	@trailends date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
insert into TRIALTRACKER (TRIALSTART,TRAILENDS)values(@trailstart,@trailends)
end


GO
/****** Object:  StoredProcedure [dbo].[TRUNCATE_Tbl_SalesItem_DUMMY]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[TRUNCATE_Tbl_SalesItem_DUMMY]
 
AS
	TRUNCATE TABLE Tbl_SalesItem_DUMMY
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[TRUNCATETABLEtbl_Stock_dummy]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TRUNCATETABLEtbl_Stock_dummy]
	
AS
	TRUNCATE TABLE tbl_Stock_dummy
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[TRUNICATE_PURCHASERETURNDISPLAY]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[TRUNICATE_PURCHASERETURNDISPLAY]
	
AS
	TRUNCATE TABLE Tbl_PurchaseReturnDisplay
RETURN 0

GO
/****** Object:  StoredProcedure [dbo].[trunicateSalesDummy_Sales]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trunicateSalesDummy_Sales]

AS
	TRUNCATE TABLE Tbl_SalesItem
RETURN 0




GO
/****** Object:  StoredProcedure [dbo].[tunicateSalesReturndisplaytable]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[tunicateSalesReturndisplaytable]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	TRUNCATE table SalesReturnDisplay;
END


GO
/****** Object:  StoredProcedure [dbo].[update_quantity_in_stock]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[update_quantity_in_stock]
	-- Add the parameters for the stored procedure here
	@quantity INT,
	@itemno varchar(50),
	@batch varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update tbl_Stock set PQty=PQty-@quantity where ItemNo=@itemno and Batch=@batch
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateStock]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateStock]
	-- Add the parameters for the stored procedure here
	@item varchar(50),
	@batch varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from tbl_Stock where ItemName=@item and Batch=@batch

END


GO
/****** Object:  StoredProcedure [dbo].[Useridretrivalfromusertableforprivilageset]    Script Date: 8/20/2018 9:37:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Useridretrivalfromusertableforprivilageset]
	
AS
BEGIN
	
	SELECT UserID from Tbl_User
END



GO
USE [master]
GO
ALTER DATABASE [MEDICALSHOP] SET  READ_WRITE 
GO
