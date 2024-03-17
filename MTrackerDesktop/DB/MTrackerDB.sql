USE [MTrackerDBWeb]
GO
/****** Object:  StoredProcedure [dbo].[AddProductInsert]    Script Date: 05-11-2022 10:02:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddProductInsert] 
(  
	@OrgID int,
	@Item_Name nvarchar(max) ,
	@Item_Catagory nvarchar(50),
	@Item_Description nvarchar(50),
	@Date nvarchar(50),
	@Item_Valuation nvarchar(50),
	@Fund_Claim_against_Item nvarchar(50),
	@Interest_Amount nvarchar(50),
	@Expected_Settlement_Date nvarchar(50),
	@Net_Forecust_of_Settlement_Amount nvarchar(50),
	@Owner_Name nvarchar(50),
	@Owner_Contact_No nvarchar(50),
	@Owner_Address nvarchar(50),
	@Owner_ID_Proof nvarchar(max)

    
)  
as  
begin  
INSERT INTO [dbo].[AddProduct]
	  (
	   [OrgID]
	  ,[Item_Name]
      ,[Item_Catagory]
      ,[Item_Description]
      ,[Date]
      ,[Item_Valuation]
      ,[Fund_Claim_against_Item]
      ,[Interest_Amount]
      ,[Expected_Settlement_Date]
      ,[Net_Forecust_of_Settlement_Amount]
      ,[Owner_Name]
      ,[Owner_Contact_No]
      ,[Owner_Address]
      ,[Owner_ID_Proof]
       )
     VALUES
           (
	  @OrgID,
	  @Item_Name,
      @Item_Catagory,
      @Item_Description,
      @Date,
      @Item_Valuation,
      @Fund_Claim_against_Item,
      @Interest_Amount,
      @Expected_Settlement_Date,
      @Net_Forecust_of_Settlement_Amount,
      @Owner_Name,
      @Owner_Contact_No,
      @Owner_Address,
      @Owner_ID_Proof
	  )
End

GO
/****** Object:  StoredProcedure [dbo].[AddProductUpdate]    Script Date: 05-11-2022 10:02:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddProductUpdate] 
(  
	@ItemID int   
)  
as  
begin  
Update [dbo].[AddProduct]
	  SET 
	  Status = 1
WHERE ItemID=@ItemID
End

GO
/****** Object:  StoredProcedure [dbo].[OganizationInsert1]    Script Date: 05-11-2022 10:02:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OganizationInsert1]  
(  
	@OrgName nvarchar(max) ,
	@orgEmail nvarchar(max) ,
	@password nvarchar(10) ,
	@orgContact nvarchar(max) ,
	@orgAddress nvarchar(max) ,
	@gst nvarchar(max) ,
	@state nvarchar(max) ,
	@city nvarchar(max) ,
	@zip nvarchar(max) ,
	@Reg_date datetime,
	@End_date datetime
  
)  
as  
begin  
INSERT INTO [dbo].[Organization]
           ([OrgName]
           ,[OrgEmail]
           ,[Password]
           ,[OrgContact]
           ,[OrgAddress]
           ,[GST]
           ,[State]
           ,[City]
           ,[Zip]
		   ,[Reg_date]
		   ,[End_date])
     VALUES
           (@OrgName
		   ,@orgEmail
		   ,@password
		   ,@orgContact
		   ,@orgAddress
		   ,@gst
		   ,@state
		   ,@city
		   ,@zip
		   ,@Reg_date
		   ,@End_date)  
End

GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 05-11-2022 10:02:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AddProduct]    Script Date: 05-11-2022 10:02:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddProduct](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[OrgID] [int] NULL,
	[Item_Name] [nvarchar](max) NOT NULL,
	[Item_Catagory] [nvarchar](50) NOT NULL,
	[Item_Description] [nvarchar](50) NOT NULL,
	[Date] [nvarchar](50) NOT NULL,
	[Item_Valuation] [nvarchar](50) NOT NULL,
	[Fund_Claim_against_Item] [nvarchar](50) NOT NULL,
	[Interest_Amount] [nvarchar](50) NOT NULL,
	[Expected_Settlement_Date] [nvarchar](50) NOT NULL,
	[Net_Forecust_of_Settlement_Amount] [nvarchar](50) NOT NULL,
	[Owner_Name] [nvarchar](50) NOT NULL,
	[Owner_Contact_No] [nvarchar](50) NOT NULL,
	[Owner_Address] [nvarchar](50) NOT NULL,
	[Owner_ID_Proof] [nvarchar](max) NOT NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_AddProduct] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ContactUs]    Script Date: 05-11-2022 10:02:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactUs](
	[Name] [nvarchar](450) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Contact_No] [nvarchar](max) NULL,
	[Message] [nvarchar](max) NULL,
 CONSTRAINT [PK_ContactUs] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Organization]    Script Date: 05-11-2022 10:02:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization](
	[OrgID] [int] IDENTITY(1,1) NOT NULL,
	[OrgName] [nvarchar](max) NULL,
	[OrgEmail] [nvarchar](max) NULL,
	[Password] [nvarchar](10) NULL,
	[OrgContact] [nvarchar](max) NULL,
	[OrgAddress] [nvarchar](max) NULL,
	[GST] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Zip] [nvarchar](max) NULL,
	[Reg_date] [datetime] NULL,
	[End_date] [datetime] NULL,
 CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED 
(
	[OrgID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsersAdmin]    Script Date: 05-11-2022 10:02:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersAdmin](
	[AdminID] [nchar](10) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nchar](10) NOT NULL,
 CONSTRAINT [PK_UsersAdmin] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220401053534_2', N'6.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220717041652_contact', N'6.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220717042355_contact1', N'6.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220717042709_cn', N'6.0.2')
SET IDENTITY_INSERT [dbo].[AddProduct] ON 

INSERT [dbo].[AddProduct] ([ItemID], [OrgID], [Item_Name], [Item_Catagory], [Item_Description], [Date], [Item_Valuation], [Fund_Claim_against_Item], [Interest_Amount], [Expected_Settlement_Date], [Net_Forecust_of_Settlement_Amount], [Owner_Name], [Owner_Contact_No], [Owner_Address], [Owner_ID_Proof], [Status]) VALUES (1, NULL, N'Nose Pin', N'Pin ', N'Small Nose Pin', N'20 May 2022', N'7000', N'5000', N'250', N'30 May 2022', N'5500', N'Rahul', N'9547840050', N'Rjb', N'Voter', 0)
INSERT [dbo].[AddProduct] ([ItemID], [OrgID], [Item_Name], [Item_Catagory], [Item_Description], [Date], [Item_Valuation], [Fund_Claim_against_Item], [Interest_Amount], [Expected_Settlement_Date], [Net_Forecust_of_Settlement_Amount], [Owner_Name], [Owner_Contact_No], [Owner_Address], [Owner_ID_Proof], [Status]) VALUES (2, NULL, N'Jhumkaa', N'earring', N'Small size', N'22 May 2022', N'14000', N'12000', N'100', N'30 May 2022', N'12500', N'Sarnadeep Mondal', N'8594547101', N'Durgapur', N'Voter', 1)
INSERT [dbo].[AddProduct] ([ItemID], [OrgID], [Item_Name], [Item_Catagory], [Item_Description], [Date], [Item_Valuation], [Fund_Claim_against_Item], [Interest_Amount], [Expected_Settlement_Date], [Net_Forecust_of_Settlement_Amount], [Owner_Name], [Owner_Contact_No], [Owner_Address], [Owner_ID_Proof], [Status]) VALUES (3, NULL, N'', N'', N'', N'28 May 2022', N'', N'', N'', N'28 May 2022', N'', N'', N'', N'', N'', 1)
INSERT [dbo].[AddProduct] ([ItemID], [OrgID], [Item_Name], [Item_Catagory], [Item_Description], [Date], [Item_Valuation], [Fund_Claim_against_Item], [Interest_Amount], [Expected_Settlement_Date], [Net_Forecust_of_Settlement_Amount], [Owner_Name], [Owner_Contact_No], [Owner_Address], [Owner_ID_Proof], [Status]) VALUES (4, NULL, N'Ring', N'Ring', N'Small ring', N'18 June 2022', N'17000', N'15000', N'450', N'18 July 2022', N'15450', N'Sanjay Yadav', N'9832166334', N'Gopalpur', N'Voter', 0)
INSERT [dbo].[AddProduct] ([ItemID], [OrgID], [Item_Name], [Item_Catagory], [Item_Description], [Date], [Item_Valuation], [Fund_Claim_against_Item], [Interest_Amount], [Expected_Settlement_Date], [Net_Forecust_of_Settlement_Amount], [Owner_Name], [Owner_Contact_No], [Owner_Address], [Owner_ID_Proof], [Status]) VALUES (5, 2, N'Jhumka', N'jhumka', N'NEW', N'30 July 2022', N'15000', N'12000', N'360', N'30 September 2022', N'12720', N'Rahul', N'9547840050', N'Durgapur', N'PAn card', 0)
SET IDENTITY_INSERT [dbo].[AddProduct] OFF
SET IDENTITY_INSERT [dbo].[Organization] ON 

INSERT [dbo].[Organization] ([OrgID], [OrgName], [OrgEmail], [Password], [OrgContact], [OrgAddress], [GST], [State], [City], [Zip], [Reg_date], [End_date]) VALUES (1, N'SarnaShop', N'Sarnadeep@gmail.com', N'1230', N'9547081048', N'Rajbandh', N'SSP8597', N'West Bengal', N'Durgapur', N'713212', CAST(N'2022-08-14 09:50:14.423' AS DateTime), CAST(N'2023-02-14 09:50:14.423' AS DateTime))
INSERT [dbo].[Organization] ([OrgID], [OrgName], [OrgEmail], [Password], [OrgContact], [OrgAddress], [GST], [State], [City], [Zip], [Reg_date], [End_date]) VALUES (2, N'Shop2', N'2shop@gmail.com', N'3210', N'8597547101', N'Rajbandh', N'SSP8597', N'West Bengal', N'Durgapur', N'713212', CAST(N'2022-08-14 09:50:14.423' AS DateTime), CAST(N'2023-02-14 09:50:14.423' AS DateTime))
INSERT [dbo].[Organization] ([OrgID], [OrgName], [OrgEmail], [Password], [OrgContact], [OrgAddress], [GST], [State], [City], [Zip], [Reg_date], [End_date]) VALUES (3, N'Shop1', N'shop1@gmail.com', N'3210', N'9547733606', N'bwn', N'S12312', N'WB', N'DGP', N'713212', CAST(N'2022-08-14 09:50:14.423' AS DateTime), CAST(N'2023-02-14 09:50:14.423' AS DateTime))
INSERT [dbo].[Organization] ([OrgID], [OrgName], [OrgEmail], [Password], [OrgContact], [OrgAddress], [GST], [State], [City], [Zip], [Reg_date], [End_date]) VALUES (4, N'New', N'new@gmail.com', N'1212', N'8597547101', N'Station', N'GS1231T', N'West Bengal', N'Durgapur', N'713212', CAST(N'2022-08-14 09:50:14.423' AS DateTime), CAST(N'2023-02-14 09:50:14.423' AS DateTime))
SET IDENTITY_INSERT [dbo].[Organization] OFF
INSERT [dbo].[UsersAdmin] ([AdminID], [Email], [Password]) VALUES (N'1         ', N'Admin@gmail.com', N'admin     ')
