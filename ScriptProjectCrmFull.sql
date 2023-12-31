USE [master]
GO
/****** Object:  Database [Project_CRM]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE DATABASE [Project_CRM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project_CRM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL2017\MSSQL\DATA\Project_CRM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project_CRM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL2017\MSSQL\DATA\Project_CRM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Project_CRM] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_CRM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_CRM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_CRM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_CRM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_CRM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_CRM] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_CRM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project_CRM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_CRM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_CRM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_CRM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_CRM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_CRM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_CRM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_CRM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_CRM] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Project_CRM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_CRM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_CRM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_CRM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_CRM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_CRM] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Project_CRM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_CRM] SET RECOVERY FULL 
GO
ALTER DATABASE [Project_CRM] SET  MULTI_USER 
GO
ALTER DATABASE [Project_CRM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_CRM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_CRM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_CRM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project_CRM] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Project_CRM', N'ON'
GO
ALTER DATABASE [Project_CRM] SET QUERY_STORE = OFF
GO
USE [Project_CRM]
GO
/****** Object:  User [test]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE USER [test] FOR LOGIN [test] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [test]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Picture] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
	[DeleteStatus] [bit] NOT NULL,
	[RegDate] [datetime] NOT NULL,
	[UserGroup_id] [int] NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reminders]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reminders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[ReminderInfo] [nvarchar](max) NULL,
	[RegDate] [datetime] NOT NULL,
	[DeleteStatus] [bit] NOT NULL,
	[ReminderDate] [datetime] NOT NULL,
	[IsDone] [bit] NOT NULL,
	[Users_id] [int] NULL,
 CONSTRAINT [PK_dbo.Reminders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_1]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT        dbo.Reminders.Title AS [موضوع یادآور], dbo.Reminders.ReminderInfo AS [جزیات یادآور], dbo.Reminders.ReminderDate AS [تاریخ یادآور], dbo.Reminders.IsDone AS [انجام شد], dbo.Users.Name AS [کاربر مربوط]
FROM            dbo.Reminders INNER JOIN
                         dbo.Users ON dbo.Reminders.Users_id = dbo.Users.id
GO
/****** Object:  Table [dbo].[Activities]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Info] [nvarchar](max) NULL,
	[RegDate] [datetime] NOT NULL,
	[DeleteStatus] [bit] NOT NULL,
	[ActivityCategory_Id] [int] NULL,
	[Customer_id] [int] NULL,
	[User_id] [int] NULL,
 CONSTRAINT [PK_dbo.Activities] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActivityCategories]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
	[DeleteStatus] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.ActivityCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[DeleteStatus] [bit] NOT NULL,
	[RegDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_2]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_2]
AS
SELECT        dbo.Activities.id AS ردیف, dbo.Activities.Title AS [موضوع فعالیت], dbo.ActivityCategories.CategoryName AS [دسته بندی], dbo.Customers.Name AS [نام مشتری], dbo.Users.UserName AS [نام کاربر], 
                         dbo.Activities.RegDate AS [تاریخ ثبت ]
FROM            dbo.Activities INNER JOIN
                         dbo.Customers ON dbo.Activities.Customer_id = dbo.Customers.id INNER JOIN
                         dbo.Users ON dbo.Activities.User_id = dbo.Users.id INNER JOIN
                         dbo.ActivityCategories ON dbo.Activities.ActivityCategory_Id = dbo.ActivityCategories.Id
GO
/****** Object:  View [dbo].[View_3]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_3]
AS
SELECT        dbo.Activities.Title AS [عنوان فعالیت], dbo.Activities.Info AS [اطلاعات ثبت شده], dbo.Activities.RegDate AS [تاریخ ثبت], dbo.Customers.Name AS [نام مشتری], dbo.Users.Name AS [نام فروشنده]
FROM            dbo.Activities INNER JOIN
                         dbo.Users ON dbo.Activities.User_id = dbo.Users.id INNER JOIN
                         dbo.Customers ON dbo.Activities.Customer_id = dbo.Customers.id
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [nvarchar](max) NULL,
	[RegDate] [datetime] NOT NULL,
	[IsCheckOut] [bit] NOT NULL,
	[DeleteStatus] [bit] NOT NULL,
	[CkeckOutDate] [datetime] NULL,
	[Customer_id] [int] NULL,
	[User_id] [int] NULL,
 CONSTRAINT [PK_dbo.Invoices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[DeleteStatus] [bit] NOT NULL,
	[Stock] [int] NOT NULL,
	[SumPrice] [float] NOT NULL,
	[RegDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductInvoices]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInvoices](
	[Product_id] [int] NOT NULL,
	[Invoice_id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ProductInvoices] PRIMARY KEY CLUSTERED 
(
	[Product_id] ASC,
	[Invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Invoice]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Invoice]
AS
SELECT        dbo.Invoices.id AS ردیف, dbo.Invoices.InvoiceNumber AS [شماره فاکتور], dbo.Invoices.RegDate AS [تاریخ ثبت], dbo.Customers.Name AS [نام مشتری], dbo.Customers.Phone AS [شماره تماس مشتری], dbo.Products.Name AS [نام کالا], 
                         dbo.Products.Price AS [قیمت کالا], dbo.Products.SumPrice AS [مجموعه قیمت], dbo.Invoices.IsCheckOut AS [پرداخت شده]
FROM            dbo.Invoices INNER JOIN
                         dbo.Customers ON dbo.Invoices.Customer_id = dbo.Customers.id INNER JOIN
                         dbo.ProductInvoices ON dbo.Invoices.id = dbo.ProductInvoices.Invoice_id INNER JOIN
                         dbo.Products ON dbo.ProductInvoices.Product_id = dbo.Products.id
GROUP BY dbo.Invoices.id, dbo.Invoices.InvoiceNumber, dbo.Invoices.RegDate, dbo.Customers.Name, dbo.Customers.Phone, dbo.Invoices.IsCheckOut, dbo.Products.Price, dbo.Products.Name, dbo.Products.SumPrice
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAccessRoles]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccessRoles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Section] [nvarchar](max) NULL,
	[CanEnter] [bit] NOT NULL,
	[CanCreate] [bit] NOT NULL,
	[CanUpdate] [bit] NOT NULL,
	[CanDelete] [bit] NOT NULL,
	[UserGroup_id] [int] NULL,
 CONSTRAINT [PK_dbo.UserAccessRoles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserGroups]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroups](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.UserGroups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_ActivityCategory_Id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_ActivityCategory_Id] ON [dbo].[Activities]
(
	[ActivityCategory_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Customer_id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_Customer_id] ON [dbo].[Activities]
(
	[Customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_id] ON [dbo].[Activities]
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Customer_id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_Customer_id] ON [dbo].[Invoices]
(
	[Customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_User_id] ON [dbo].[Invoices]
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Invoice_id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_Invoice_id] ON [dbo].[ProductInvoices]
(
	[Invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_Product_id] ON [dbo].[ProductInvoices]
(
	[Product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_Users_id] ON [dbo].[Reminders]
(
	[Users_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserGroup_id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserGroup_id] ON [dbo].[UserAccessRoles]
(
	[UserGroup_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserGroup_id]    Script Date: 7/4/2022 2:58:13 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserGroup_id] ON [dbo].[Users]
(
	[UserGroup_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Activities_dbo.ActivityCategories_ActivityCategory_Id] FOREIGN KEY([ActivityCategory_Id])
REFERENCES [dbo].[ActivityCategories] ([Id])
GO
ALTER TABLE [dbo].[Activities] CHECK CONSTRAINT [FK_dbo.Activities_dbo.ActivityCategories_ActivityCategory_Id]
GO
ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Activities_dbo.Customers_Customer_id] FOREIGN KEY([Customer_id])
REFERENCES [dbo].[Customers] ([id])
GO
ALTER TABLE [dbo].[Activities] CHECK CONSTRAINT [FK_dbo.Activities_dbo.Customers_Customer_id]
GO
ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Activities_dbo.Users_User_id] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Activities] CHECK CONSTRAINT [FK_dbo.Activities_dbo.Users_User_id]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Invoices_dbo.Customers_Customer_id] FOREIGN KEY([Customer_id])
REFERENCES [dbo].[Customers] ([id])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_dbo.Invoices_dbo.Customers_Customer_id]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Invoices_dbo.Users_User_id] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_dbo.Invoices_dbo.Users_User_id]
GO
ALTER TABLE [dbo].[ProductInvoices]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ProductInvoices_dbo.Invoices_Invoice_id] FOREIGN KEY([Invoice_id])
REFERENCES [dbo].[Invoices] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductInvoices] CHECK CONSTRAINT [FK_dbo.ProductInvoices_dbo.Invoices_Invoice_id]
GO
ALTER TABLE [dbo].[ProductInvoices]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ProductInvoices_dbo.Products_Product_id] FOREIGN KEY([Product_id])
REFERENCES [dbo].[Products] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductInvoices] CHECK CONSTRAINT [FK_dbo.ProductInvoices_dbo.Products_Product_id]
GO
ALTER TABLE [dbo].[Reminders]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Reminders_dbo.Users_Users_id] FOREIGN KEY([Users_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Reminders] CHECK CONSTRAINT [FK_dbo.Reminders_dbo.Users_Users_id]
GO
ALTER TABLE [dbo].[UserAccessRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserAccessRoles_dbo.UserGroups_UserGroup_id] FOREIGN KEY([UserGroup_id])
REFERENCES [dbo].[UserGroups] ([id])
GO
ALTER TABLE [dbo].[UserAccessRoles] CHECK CONSTRAINT [FK_dbo.UserAccessRoles_dbo.UserGroups_UserGroup_id]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Users_dbo.UserGroups_UserGroup_id] FOREIGN KEY([UserGroup_id])
REFERENCES [dbo].[UserGroups] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_dbo.Users_dbo.UserGroups_UserGroup_id]
GO
/****** Object:  StoredProcedure [dbo].[ActiviysReport]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActiviysReport] 
AS
BEGIN
SELECT        dbo.Activities.Title AS [عنوان فعالیت], dbo.Activities.Info AS [اطلاعات ثبت شده], dbo.Activities.RegDate AS [تاریخ ثبت], dbo.Customers.Name AS [نام مشتری], dbo.Users.Name AS [نام فروشنده]
FROM            dbo.Activities INNER JOIN
                         dbo.Users ON dbo.Activities.User_id = dbo.Users.id INNER JOIN
                         dbo.Customers ON dbo.Activities.Customer_id = dbo.Customers.id
END
GO
/****** Object:  StoredProcedure [dbo].[CustomerReports]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerReports] 
AS
BEGIN
 SELECT        id AS ردیف, Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ ثبت]
FROM            dbo.Customers
END
GO
/****** Object:  StoredProcedure [dbo].[Invocereport]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Invocereport]

AS
BEGIN
Declare @startOfCureentMouth DateTime
Set @startOfCureentMouth=DATEADD(month,datediff(month,0,Current_Timestamp),0)
SELECT        dbo.Invoices.InvoiceNumber AS [شماره فاکتور], dbo.Customers.Name AS [نام مشتری], dbo.Invoices.RegDate AS [تاریخ ثبت], dbo.Invoices.DeleteStatus
FROM            dbo.Invoices INNER JOIN
                         dbo.Customers ON dbo.Invoices.Customer_id = dbo.Customers.id
Where        (dbo.Invoices.DeleteStatus = 0) And (dbo.Invoices.RegDate) >= DATEADD(Month,0,@startOfCureentMouth)
END
GO
/****** Object:  StoredProcedure [dbo].[InvoiceReportWeekOld]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InvoiceReportWeekOld]
	
AS
BEGIN
	Declare @startOfCureentMouth DateTime
Set @startOfCureentMouth=DATEADD(month,datediff(month,0,Current_Timestamp),0)
SELECT        dbo.Invoices.InvoiceNumber AS [شماره فاکتور], dbo.Customers.Name AS [نام مشتری], dbo.Invoices.RegDate AS [تاریخ ثبت], dbo.Invoices.DeleteStatus
FROM            dbo.Invoices INNER JOIN
                         dbo.Customers ON dbo.Invoices.Customer_id = dbo.Customers.id
Where        (dbo.Invoices.DeleteStatus = 0) And (dbo.Invoices.RegDate) >= DATEADD(WEEK,0,@startOfCureentMouth)
END
GO
/****** Object:  StoredProcedure [dbo].[InvoiceReportYearOld]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InvoiceReportYearOld]
	
AS
BEGIN
	Declare @startOfCureentMouth DateTime
Set @startOfCureentMouth=DATEADD(month,datediff(month,0,Current_Timestamp),0)
SELECT        dbo.Invoices.InvoiceNumber AS [شماره فاکتور], dbo.Customers.Name AS [نام مشتری], dbo.Invoices.RegDate AS [تاریخ ثبت], dbo.Invoices.DeleteStatus
FROM            dbo.Invoices INNER JOIN
                         dbo.Customers ON dbo.Invoices.Customer_id = dbo.Customers.id
Where        (dbo.Invoices.DeleteStatus = 0) And (dbo.Invoices.RegDate) = DATEADD(YEAR,0,@startOfCureentMouth)
END
GO
/****** Object:  StoredProcedure [dbo].[R]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[R]
AS
BEGIN


SELECT dbo.Reminders.id AS ردیف, dbo.Reminders.Title AS موضوع,
dbo.Reminders.ReminderInfo AS [جزیات یاداور], 
dbo.Reminders.RegDate AS [تاریخ یادآور],
dbo.Users.Name AS [کاربر مربوط], dbo.Reminders.IsDone AS [انجام شد]
FROM   dbo.Reminders INNER JOIN
dbo.Users ON dbo.Reminders.Users_id = dbo.Users.id
WHERE (dbo.Reminders.DeleteStatus = 0)


END
GO
/****** Object:  StoredProcedure [dbo].[ReadAll]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ReadAll]
	
AS
BEGIN
SELECT        dbo.Activities.id AS ردیف, dbo.Activities.Title AS [موضوع فعالیت], dbo.ActivityCategories.CategoryName AS [دسته بندی], dbo.Customers.Name AS [نام مشتری], dbo.Users.UserName AS [نام کاربر], 
                         dbo.Activities.RegDate AS [تاریخ ثبت ]
FROM            dbo.Activities INNER JOIN
                         dbo.Customers ON dbo.Activities.Customer_id = dbo.Customers.id INNER JOIN
                         dbo.Users ON dbo.Activities.User_id = dbo.Users.id INNER JOIN
                         dbo.ActivityCategories ON dbo.Activities.ActivityCategory_Id = dbo.ActivityCategories.Id
END
GO
/****** Object:  StoredProcedure [dbo].[ReadInvoices]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ReadInvoices]

AS
BEGIN
SELECT        dbo.Invoices.id AS ردیف, dbo.Invoices.InvoiceNumber AS [شماره فاکتور], dbo.Invoices.RegDate AS [تاریخ ثبت], dbo.Customers.Name AS [نام مشتری], dbo.Customers.Phone AS [شماره تماس مشتری], dbo.Products.Name AS [نام کالا], 
                         dbo.Products.Price AS [قیمت کالا], dbo.Products.SumPrice AS [مجموعه قیمت], dbo.Invoices.IsCheckOut AS [پرداخت شده]
FROM            dbo.Invoices INNER JOIN
                         dbo.Customers ON dbo.Invoices.Customer_id = dbo.Customers.id INNER JOIN
                         dbo.ProductInvoices ON dbo.Invoices.id = dbo.ProductInvoices.Invoice_id INNER JOIN
                         dbo.Products ON dbo.ProductInvoices.Product_id = dbo.Products.id
GROUP BY dbo.Invoices.id, dbo.Invoices.InvoiceNumber, dbo.Invoices.RegDate, dbo.Customers.Name, dbo.Customers.Phone, dbo.Invoices.IsCheckOut, dbo.Products.Price, dbo.Products.Name, dbo.Products.SumPrice
END
GO
/****** Object:  StoredProcedure [dbo].[ReadReminders]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReadReminders]

AS
BEGIN
SELECT        dbo.Reminders.Title AS [موضوع یادآور], dbo.Reminders.ReminderInfo AS [جزیات یادآور], dbo.Reminders.ReminderDate AS [تاریخ یادآور], dbo.Reminders.IsDone AS [انجام شد], dbo.Users.Name AS [کاربر مربوط]
FROM   dbo.Reminders INNER JOIN
dbo.Users ON dbo.Reminders.Users_id = dbo.Users.id
END
GO
/****** Object:  StoredProcedure [dbo].[SearchReminder]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SearchReminder]
	@Search Nvarchar(max)
AS
BEGIN
SELECT        dbo.Reminders.Title AS [موضوع یادآورد], dbo.Reminders.ReminderInfo AS [موارد یادآور], dbo.Reminders.ReminderDate AS [تاریخ یادآور], dbo.Reminders.IsDone AS [انجام شده], dbo.Users.Name AS [کاربر مربوط]
FROM            dbo.Reminders INNER JOIN
                         dbo.ReminderUsers ON dbo.Reminders.id = dbo.ReminderUsers.Reminder_id INNER JOIN
                         dbo.Users ON dbo.ReminderUsers.User_id = dbo.Users.id
WHERE        (dbo.Users.Name  like '%'+@Search+'%')
END
GO
/****** Object:  StoredProcedure [dbo].[SerchCustomer]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SerchCustomer]
@Serch Nvarchar(max) =null
AS
if @Serch Is null 
Begin
Print 'Null Parameter...'
Return
End
BEGIN
	
	Select [Name] as [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ وساعت] From dbo.Customers
	WHERE  (DeleteStatus = 0) AND (Name Like '%'+@Serch+'%') Or (Phone Like '%'+@Serch+'%')
END
GO
/****** Object:  StoredProcedure [dbo].[SerchCustomerName]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SerchCustomerName]
@Serch Nvarchar(max) 
AS
BEGIN
	
	Select [Name] as [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ وساعت] From dbo.Customers
	WHERE  (DeleteStatus = 0) AND (Name Like '%'+@Serch+'%') 
END
GO
/****** Object:  StoredProcedure [dbo].[SerchCustomerPhone]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SerchCustomerPhone]
@Serch Nvarchar(max) 
AS
BEGIN
	
	Select [Name] as [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ وساعت] From dbo.Customers
	WHERE  (DeleteStatus = 0) AND  (Phone Like '%'+@Serch+'%')
END
GO
/****** Object:  StoredProcedure [dbo].[SerchProduct]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SerchProduct]
@Serch Nvarchar(max) 
AS
BEGIN
	
	Select [Name] as [نام محصول] From dbo.Products
	WHERE  (DeleteStatus = 0) AND  (Name Like '%'+@Serch+'%')
END
GO
/****** Object:  StoredProcedure [dbo].[Sumoliations]    Script Date: 7/4/2022 2:58:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[Sumoliations]
@Num1 int=null,
@num2 int=null
As
If @Num1 IS null Or @num2 Is Null
Begin
Print 'Valid Parameter....'
Return
End
Begin
Select @Num1+@num2 As [Sum]
End
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[21] 2[17] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Reminders"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Users"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Activities"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Customers"
            Begin Extent = 
               Top = 154
               Left = 497
               Bottom = 284
               Right = 667
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Users"
            Begin Extent = 
               Top = 183
               Left = 204
               Bottom = 313
               Right = 374
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ActivityCategories"
            Begin Extent = 
               Top = 0
               Left = 493
               Bottom = 132
               Right = 663
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 1305
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 135' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Activities"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Users"
            Begin Extent = 
               Top = 29
               Left = 406
               Bottom = 159
               Right = 576
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Customers"
            Begin Extent = 
               Top = 63
               Left = 748
               Bottom = 193
               Right = 918
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[27] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Invoices"
            Begin Extent = 
               Top = 36
               Left = 578
               Bottom = 166
               Right = 765
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Customers"
            Begin Extent = 
               Top = 22
               Left = 956
               Bottom = 152
               Right = 1142
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ProductInvoices"
            Begin Extent = 
               Top = 53
               Left = 327
               Bottom = 149
               Right = 513
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Products"
            Begin Extent = 
               Top = 32
               Left = 41
               Bottom = 162
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Invoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Invoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Invoice'
GO
USE [master]
GO
ALTER DATABASE [Project_CRM] SET  READ_WRITE 
GO
