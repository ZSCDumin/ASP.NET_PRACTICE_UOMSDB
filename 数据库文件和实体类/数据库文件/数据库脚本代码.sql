-----------------------创建数据库UOMSDB

CREATE DATABASE UOMSDB
go

-------------------------创建各数据表

USE [UOMSDB]
GO

----创建买家订单评价表
CREATE TABLE [dbo].[b_evaluate_T](
	[evaluate_Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[b_account] [varchar](20) NOT NULL,
	[p_Id] [int] NOT NULL,
	[p_name] [varchar](30) NOT NULL,
	[p_photo] [varchar](200) NOT NULL,
	[p_evaluate] [varchar](200) NOT NULL,
)

GO

---创建买家订单项目表
CREATE TABLE [dbo].[b_order_item_T](
	[b_o_Id] [int] NOT NULL,
	[p_Id] [int] NOT NULL,
	[p_price] [money] NOT NULL,
	[p_num] [int] NOT NULL,
	PRIMARY KEY([b_o_Id])
)

GO

---创建买家订单状态表
CREATE TABLE [dbo].[b_order_state_T](
	[b_o_Id] [int] NOT NULL,
	[b_o_state] [varchar](10) NOT NULL,
	[b_o_subTime] [datetime] default(GETDATE()) NOT NULL,
	PRIMARY KEY([b_o_Id],[b_o_subTime])
)

GO

----创建买家订单表
CREATE TABLE [dbo].[b_order_T](
	[b_o_Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[b_account] [varchar](20) NOT NULL,
	[s_account] [varchar](20) NOT NULL,
	[s_storeName] [varchar](20) NOT NULL,
	[b_orderState] [varchar](20) NOT NULL,
	[b_o_totalPrice] [money] NOT NULL,
	[b_o_time] [datetime] default(GETDATE()) NOT NULL,
)

GO

---创建买家信息表
CREATE TABLE [dbo].[buyer_T](
	[b_account] [varchar](20) PRIMARY KEY NOT NULL,
	[b_password] [varchar](20) NOT NULL,
	[b_name] [varchar](20) NOT NULL,
	[b_tel] [varchar](11) NOT NULL,
	[b_balance] [money] default(0) NOT NULL,
	[b_question] [varchar](50) NOT NULL,
	[b_answer] [varchar](50) NOT NULL,
	[b_email] [varchar](50) NOT NULL
)
GO

----创建购物车表
CREATE TABLE [dbo].[cart_T](
	[b_account] [varchar](20) NOT NULL,
	[s_account] [varchar](20) NOT NULL,
	[s_storeName] [varchar](20) NOT NULL,
	[p_Id] [int] NOT NULL,
	[p_name] [varchar](20) NOT NULL,
	[p_price] [money] NOT NULL,
	[p_num] [int] default(1) NOT NULL,
	PRIMARY KEY([b_account],[p_Id])
)
GO
---创建商品表
CREATE TABLE [dbo].[product_T](
	[p_Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[s_account] [varchar](20) NOT NULL,
	[p_name] [varchar](30) NOT NULL,
	[p_category] [varchar](20) NOT NULL,
	[p_price] [money] NOT NULL,
	[p_cNum] [int] default(50) NOT NULL,
	[p_photo] [varchar](200) NOT NULL,
	[p_saleNum] [int] default(0) NOT NULL
)

GO
---创建卖家订单项目表
CREATE TABLE [dbo].[s_order_item_T](
	[s_o_Id] [int] NOT NULL,
	[p_Id] [int] NOT NULL,
	[p_price] [money] NOT NULL,
	[p_num] [int] NOT NULL,
	PRIMARY KEY([s_o_Id])
)

GO
---创建卖家订单表
CREATE TABLE [dbo].[s_order_T](
	[s_o_Id] [int] PRIMARY KEY NOT NULL,
	[b_account] [varchar](20) NOT NULL,
	[s_account] [varchar](20) NOT NULL,
	[s_o_state] [varchar](10) NOT NULL,
	[s_o_totalprice] [money] NOT NULL,
	[s_o_time] [datetime] default(GETDATE()) NOT NULL
)

GO
---创建卖家信息表
CREATE TABLE [dbo].[seller_T](
	[s_account] [varchar](20) PRIMARY KEY NOT NULL,
	[s_password] [varchar](20) NOT NULL,
	[s_storeName] [varchar](20) NOT NULL,
	[s_name] [varchar](20) NOT NULL,
	[s_tel] [varchar](11) NOT NULL,
	[s_question] [varchar](20) NOT NULL,
	[s_answer] [varchar](20) NOT NULL,
	[s_state] [bit] default(1) NOT NULL,
	[s_profit] [money] default(0) NOT NULL
)
GO
