

create table entry  ---���ֱ�
(
  entryid varchar(20), ---���ֵ���
  entrytime date,      ---����ʱ��
  peopleid varchar(20), ----������Ա����
  text1 varchar(20),   ---��ע
  goodsid varchar(20),  ---���ϴ���
  entrynumber  int,  ---��������
)

create table come  ---���ֱ�
(
  comeid varchar(20), ---���ֵ���
  cometime date,      ---����ʱ��
  peopleid varchar(20), ----������Ա����
  text2 varchar(20),   ---��ע
  goodsid varchar(20),  ---���ϴ���
  comenumber  int,  ---��������
)

use GoodsMS;

insert into entry (entryid, entrytime, peopleid, text1, goodsid, entrynumber) values('admin20:251', '2018/12/25 20:25:13', 'admin', '', 'FX20', 10)
update goods set goods_num = goods_num + 10 where goods_id = 'FX20' 


update goods set goods_num = goods_num + 1 where goods_id = 'FX20'

select * from entry;