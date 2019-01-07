--init sys
CREATE DATABASE GoodsMS
ON  PRIMARY  --默认就属于PRIMARY主文件组，可省略
(  NAME = 'goods_data',  --主数据文件的逻辑名
   FILENAME = 'C:\home\DB\goods_data.mdf',  --主数据文件的物理名
   SIZE = 50mb,  --主数据文件初始大小
   MAXSIZE = 100mb,  --主数据文件增长的最大值
   FILEGROWTH = 5mb   --主数据文件的增长率
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

--人员代码、姓名、性别、出生日期、身份证号、籍贯、家庭住址、联系电话、其它情况

create table people
(
	userid varchar(20) primary key, --人员代码
	username varchar(20),			--姓名
	sex varchar(4),					--性别
	birithday date,				    --出生日期
	idnumber varchar(20),			--身份证号
	loc_city varchar(20),			--籍贯
	home_address varchar(20),		--家庭住址
	phone varchar(20),				--联系电话
	others varchar(50)				--其他情况
);

select userid '人员代码', username '姓名', sex '性别', birithday '出生日期', idnumber '身份证号', loc_city '籍贯', home_address '家庭住址', phone '联系电话', others '其他情况'  from people;
delete from people;
insert into people values ('user001', '你好', '男', '1997-10-13', '350123199710134195', 'fj', 'fj', '110', 'null');

--物料代码、物料名称、规格型号、计量单位、库存数量、备注等字段
create table goods
(
	goods_id varchar(20) primary key,		 --物料代码
	goods_name varchar(20),					 --物料名称
	goods_size varchar(20),					--规格型号
	goods_unit varchar(20),					--计量单位
	goods_num  int check(goods_num >= 0),	--库存数量
	note varchar(20)						--备注
);

select goods_id, goods_name, goods_size, goods_unit, goods_num, note from goods;
delete from goods;
insert into goods values('name', 'id', 'fx' ,'台', 0, 'null');

create table entry  ---进仓表
(
  entryid varchar(40) primary key, ---进仓单号
  entrytime date,      ---进仓时间
  peopleid varchar(20), ----操作人员代码
  text1 varchar(20),   ---备注
  goodsid varchar(20),  ---物料代码
  entrynumber  int,  ---进仓数量
)

create table come  ---出仓表
(
  comeid varchar(40) primary key, ---出仓单号
  cometime date,      ---出仓时间
  peopleid varchar(20), ----操作人员代码
  text2 varchar(20),   ---备注
  goodsid varchar(20),  ---物料代码
  comenumber  int,  ---出仓数量
)

create table report
(
  comeid varchar(40) primary key, ---单号
  cometime date,      ---时间
  peopleid varchar(20), ----操作人员代码
  text2 varchar(20),   ---备注
  goodsid varchar(20),  ---物料代码
  comenumber  int,  ---出仓数量
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