use UOMSDB
go

--删除买家账号'2014030402001'
delete from buyer_T where b_account='2014030402001'

--删除卖家账号'2014030403001'
delete from seller_T where s_account='2014030403001'

--删除buyer_T、seller_T数据表全部数据
delete from buyer_T
delete from seller_T 
--测试修改后的结果
go
select * from buyer_T
go
select * from seller_T
go