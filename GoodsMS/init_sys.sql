--init sys
CREATE DATABASE GoodsMS
ON  PRIMARY  --Ĭ�Ͼ�����PRIMARY���ļ��飬��ʡ��
(  NAME = 'goods_data',  --�������ļ����߼���
   FILENAME = 'C:\home\DB\goods_data.mdf',  --�������ļ���������
   SIZE = 50mb,  --�������ļ���ʼ��С
   MAXSIZE = 100mb,  --�������ļ����������ֵ
   FILEGROWTH = 5mb   --�������ļ���������
)
LOG ON
(  NAME = 'goods_log',
   FILENAME = 'C:\home\DB\goods_log.mdf',
   SIZE = 2mb,
   FILEGROWTH = 10%
);

use GoodsMS;

create table sys_user 
(
	username varchar(20) primary key,
	userpswd varchar(20) not null,
	userid varchar(20),
	usertype int
);

select * from sys_user;
delete from sys_user where username = 'admin'
insert into sys_user values ('admin', '123456', 'admin', 0x7FFFFFFF);
update sys_user set usertype = 138 where username != 'admin'

--��Ա���롢�������Ա𡢳������ڡ����֤�š����ᡢ��ͥסַ����ϵ�绰���������

create table people
(
	userid varchar(20) primary key, --��Ա����
	username varchar(20),			--����
	sex varchar(4),					--�Ա�
	birithday date,				    --��������
	idnumber varchar(20),			--���֤��
	loc_city varchar(20),			--����
	home_address varchar(20),		--��ͥסַ
	phone varchar(20),				--��ϵ�绰
	others varchar(50)				--�������
);

select userid '��Ա����', username '����', sex '�Ա�', birithday '��������', idnumber '���֤��', loc_city '����', home_address '��ͥסַ', phone '��ϵ�绰', others '�������'  from people;
delete from people;
insert into people values ('user001', '���', '��', '1997-10-13', '350123199710134195', 'fj', 'fj', '110', 'null');

--���ϴ��롢�������ơ�����ͺš�������λ�������������ע���ֶ�
create table goods
(
	goods_id varchar(20) primary key,		 --���ϴ���
	goods_name varchar(20),					 --��������
	goods_size varchar(20),					--����ͺ�
	goods_unit varchar(20),					--������λ
	goods_num  int check(goods_num >= 0),	--�������
	note varchar(20)						--��ע
);

select goods_id, goods_name, goods_size, goods_unit, goods_num, note from goods;
delete from goods;
insert into goods values('name', 'id', 'fx' ,'̨', 0, 'null');

create table entry  ---���ֱ�
(
  entryid varchar(40) primary key, ---���ֵ���
  entrytime date,      ---����ʱ��
  peopleid varchar(20), ----������Ա����
  text1 varchar(20),   ---��ע
  goodsid varchar(20),  ---���ϴ���
  entrynumber  int,  ---��������
)

create table come  ---���ֱ�
(
  comeid varchar(40) primary key, ---���ֵ���
  cometime date,      ---����ʱ��
  peopleid varchar(20), ----������Ա����
  text2 varchar(20),   ---��ע
  goodsid varchar(20),  ---���ϴ���
  comenumber  int,  ---��������
)

create table report
(
  comeid varchar(40) primary key, ---����
  cometime date,      ---ʱ��
  peopleid varchar(20), ----������Ա����
  text2 varchar(20),   ---��ע
  goodsid varchar(20),  ---���ϴ���
  comenumber  int,  ---��������
)

select * from entry;
select * from come;
delete from entry;
delete from come;

select * from entry;
select * from report;

insert into report (comeid, cometime, peopleid, text2, goodsid, comenumber) values
	('test03','2018/12/26', 'admin', 'test01', 'test01', 10);

select * from report where cometime between  '2018-12-26' and '2018-12-26'