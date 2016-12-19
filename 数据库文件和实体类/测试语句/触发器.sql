USE [UOMSDB]
GO

CREATE trigger [dbo].[InsertIntoSOderItem] on [dbo].[b_order_item_T]
for insert
as
begin 
    insert into s_order_item_T select * from inserted where b_o_Id=(select b_o_Id from inserted)
	update product_T set   p_cNum=p_cNum-(select p_num from inserted),p_saleNum=p_saleNum+(select p_num from inserted) where p_Id=(select p_Id from inserted)
end

GO

CREATE trigger [dbo].[InsertIntoSOrder] on [dbo].[b_order_T]
for insert
as 
begin
    insert into s_order_T select b_o_Id,b_account,s_account,b_orderState,b_o_totalPrice,b_o_time from inserted where b_o_Id=(select b_o_Id from inserted)
	if(select b_o_totalPrice from inserted where b_orderState='已付款')>0
	update seller_T set s_profit += (select b_o_totalPrice from inserted where b_orderState='已付款')
end

GO