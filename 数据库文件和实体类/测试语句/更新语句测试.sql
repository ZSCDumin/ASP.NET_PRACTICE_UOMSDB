use UOMSDB
go

--修改买家'2014030402001'的姓名为'修改了买家姓名'
update buyer_T set b_name='修改了买家姓名' where b_account='2014030402001'

--修改卖家'2014030403001'的姓名为'修改了卖家姓名'
update seller_T set s_name='修改了卖家姓名' where s_account='2014030403001'

--测试修改后的结果
go
select * from buyer_T
go
select * from seller_T
go