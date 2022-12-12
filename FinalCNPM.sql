Create database Final_CNPM
go 
use Final_CNPM
go

/*---------Create tables--------*/
create table PRODUCT
(
	PRODUCT_ID varchar(5) primary key not null,
	PRODUCT_NAME nvarchar(255),
	PRODUCT_PRICE varchar(255),
);
--drop table PRODUCT



create table AGENT
(
	AGENT_ID varchar(5) primary key not null,
	AGENT_NAME nvarchar(255),
	AGENT_EMAIL varchar(50),
	AGENT_ADDRESS nvarchar(255),
	AGENT_PHONE varchar(11),
);
--drop table AGENT



create table PAYMENT_METHOD
(
	PAYMENT_ID varchar(5) primary key not null,
	PAYMENT_NAME nvarchar(50),

);
--drop table PAYMENT_METHOD


create table EXPORT_ORDER
(
	EXPORT_ID varchar(5) primary key not null,
	AGENT_ID varchar(5),
	EXPORT_DATE datetime,
	PAYMENT_ID varchar(5),
	ORDER_STATUS nvarchar(50),
);
--drop table EXPORT_ORDER



create table EXPORT_DETAIL
(
	EX_DE_ID nvarchar(5) primary key not null,
	EX_ORDER_ID nvarchar(5),
	PRO_ID varchar(5),
	QUANTITY integer,
);
--drop table EXPORT_DETAIL

create table IMPORT_ORDER
(
	IM_OR_ID varchar(5) primary key not null,
	IMPORT_DATE datetime,
);
--drop table IMPORT_ORDER


create table IMPORT_DETAIL
(
	IM_DE_ID varchar(5) primary key not null,
	IM_ORDER_ID varchar(5),
	PRO_ID varchar(5),
	QUANTITY integer,
);
--drop table IMPORT_DETAIL





/*----add relationships----*/

alter table EXPORT_ORDER
add constraint FK_EXPORT_AGENT foreign key(AGENT_ID) references AGENT(AGENT_ID)

alter table EXPORT_ORDER
add constraint FK_EXPORT_PAYMENT foreign key(PAYMENT_ID) references PAYMENT_METHOD(PAYMENT_ID)

alter table EXPORT_DETAIL
add constraint FK_EXPORT_DETAIL_PRODUCT foreign key(PRO_ID) references PRODUCT(PRODUCT_ID)

alter table IMPORT_DETAIL
add constraint FK_IMPORT_DETAIL_PRODUCT foreign key(PRO_ID) references PRODUCT(PRODUCT_ID)

alter table IMPORT_DETAIL
add constraint FK_IMPORT_DETAIL_ORDER foreign key(IM_ORDER_ID) references IMPORT_ORDER(IM_OR_ID)
	

/*----Insert data---*/

insert into AGENT values ('AGT1', N'đại lý số 1','agent1@gmail.com', N'Số 1, đường Nguyễn Hữu Thọ, quận 1, TP.HCM', '0122344546');
insert into AGENT values ('AGT2', N'đại lý số 2','agent2@gmail.com', N'Số 2, đường Nguyễn Hữu Thọ, quận 2, TP.HCM', '0122344546');
insert into AGENT values ('AGT3', N'đại lý số 3','agent3@gmail.com', N'Số 3, đường Nguyễn Hữu Thọ, quận 3, TP.HCM', '0122344546');
insert into AGENT values ('AGT4', N'đại lý số 4','agent4@gmail.com', N'Số 4, đường Nguyễn Hữu Thọ, quận 4, TP.HCM', '0122344546');
insert into AGENT values ('AGT5', N'đại lý số 5','agent5@gmail.com', N'Số 5, đường Nguyễn Hữu Thọ, quận 5, TP.HCM', '0122344546');
insert into AGENT values ('AGT6', N'đại lý số 6','agent6@gmail.com', N'Số 6, đường Nguyễn Hữu Thọ, quận 6, TP.HCM', '0122344546');
insert into AGENT values ('AGT7', N'đại lý số 7','agent7@gmail.com', N'Số 7, đường Nguyễn Hữu Thọ, quận 7, TP.HCM', '0122344546');
--select * from AGENT

insert into PRODUCT values('PRO1',N'Thuốc 1','12000')
insert into PRODUCT values('PRO2',N'Thuốc 2','13000')
insert into PRODUCT values('PRO3',N'Thuốc 3','14000')
insert into PRODUCT values('PRO4',N'Thuốc 4','15000')
insert into PRODUCT values('PRO5',N'Thuốc 5','16000')
insert into PRODUCT values('PRO6',N'Thuốc 6','17000')
--select * from PRODUCT

insert into PAYMENT_METHOD values('PAY1',N'Mono')
insert into PAYMENT_METHOD values('PAY2',N'Thanh toán trực tiếp')
insert into PAYMENT_METHOD values('PAY3',N'Chuyển khoản qua BIDV')
insert into PAYMENT_METHOD values('PAY4',N'Chuyển khoản qua VCB')
insert into PAYMENT_METHOD values('PAY5',N'Zalo Pay')
--select * from PAYMENT_METHOD


insert into EXPORT_ORDER values('EX1','AGT1','2022-11-15','PAY1',N'Đã thanh toán')
insert into EXPORT_ORDER values('EX2','AGT1','2022-11-14','PAY2',N'Đã thanh toán')
insert into EXPORT_ORDER values('EX3','AGT2','2022-11-25','PAY3',N'Chưa thanh toán')
insert into EXPORT_ORDER values('EX4','AGT4','2022-11-16','PAY2',N'Chưa thanh toán')
insert into EXPORT_ORDER values('EX5','AGT5','2022-11-5','PAY5',N'Đã thanh toán')
--select * from EXPORT_ORDER

insert into EXPORT_DETAIL values('ED1','EX1','PRO1',100)
insert into EXPORT_DETAIL values('ED2','EX1','PRO3',110)
insert into EXPORT_DETAIL values('ED3','EX1','PRO4',10)
insert into EXPORT_DETAIL values('ED4','EX1','PRO2',100)
insert into EXPORT_DETAIL values('ED5','EX2','PRO1',20)
insert into EXPORT_DETAIL values('ED6','EX2','PRO2',300)
insert into EXPORT_DETAIL values('ED7','EX2','PRO3',500)
insert into EXPORT_DETAIL values('ED8','EX2','PRO4',120)
insert into EXPORT_DETAIL values('ED9','EX3','PRO1',110)
insert into EXPORT_DETAIL values('ED10','EX3','PRO2',14)
insert into EXPORT_DETAIL values('ED11','EX3','PRO3',120)
insert into EXPORT_DETAIL values('ED12','EX4','PRO4',10)
insert into EXPORT_DETAIL values('ED13','EX4','PRO1',110)
insert into EXPORT_DETAIL values('ED14','EX4','PRO2',180)
insert into EXPORT_DETAIL values('ED15','EX5','PRO1',150)
insert into EXPORT_DETAIL values('ED16','EX5','PRO2',112)
--select * from EXPORT_DETAIL

insert into IMPORT_ORDER values('IM1','2022-1-15')
insert into IMPORT_ORDER values('IM2','2022-2-19')
insert into IMPORT_ORDER values('IM3','2022-6-5')
insert into IMPORT_ORDER values('IM4','2022-3-25')
insert into IMPORT_ORDER values('IM5','2022-5-14')
insert into IMPORT_ORDER values('IM6','2021-11-15')
--select * from IMPORT_ORDER



insert into IMPORT_DETAIL values('ID1','IM1','PRO1',1000)
insert into IMPORT_DETAIL values('ID2','IM1','PRO2',2000)
insert into IMPORT_DETAIL values('ID3','IM2','PRO3',4000)
insert into IMPORT_DETAIL values('ID4','IM2','PRO5',1100)
insert into IMPORT_DETAIL values('ID5','IM3','PRO2',100)
insert into IMPORT_DETAIL values('ID6','IM3','PRO1',1300)
insert into IMPORT_DETAIL values('ID7','IM4','PRO2',1400)
insert into IMPORT_DETAIL values('ID8','IM4','PRO3',1100)
insert into IMPORT_DETAIL values('ID9','IM5','PRO4',1300)
insert into IMPORT_DETAIL values('ID10','IM5','PRO5',2000)
insert into IMPORT_DETAIL values('ID11','IM6','PRO2',1100)
insert into IMPORT_DETAIL values('ID12','IM6','PRO1',1000)
--select * from IMPORT_DETAIL