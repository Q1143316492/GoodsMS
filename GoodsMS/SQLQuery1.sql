

create table entry  ---进仓表
(
  entryid varchar(20), ---进仓单号
  entrytime date,      ---进仓时间
  peopleid varchar(20), ----操作人员代码
  text1 varchar(20),   ---备注
  goodsid varchar(20),  ---物料代码
  entrynumber  int,  ---进仓数量
)

create table come  ---出仓表
(
  comeid varchar(20), ---出仓单号
  cometime date,      ---出仓时间
  peopleid varchar(20), ----操作人员代码
  text2 varchar(20),   ---备注
  goodsid varchar(20),  ---物料代码
  comenumber  int,  ---出仓数量
)

use GoodsMS;

insert into entry (entryid, entrytime, peopleid, text1, goodsid, entrynumber) values('admin20:251', '2018/12/25 20:25:13', 'admin', '', 'FX20', 10)
update goods set goods_num = goods_num + 10 where goods_id = 'FX20' 


update goods set goods_num = goods_num + 1 where goods_id = 'FX20'

select * from entry;