 create database passbook;
 use passbook;
 show tables;
 
 create table admin_logs
 (
 ID int auto_increment primary key,
 NAME varchar(100),
 UNAME varchar(100),
 UPASS varchar(100)
 );
 
 select * from admin_logs;
 
 insert into admin_logs(NAME, UNAME, UPASS) values ('Rade', 'admin', 'admin');
 
 create table ledger(
 LID int auto_increment primary key,
 LNAME varchar(50),
 BANK varchar(50),
 BRANCH varchar(50),
 ACCNO varchar(50),
 IFSC varchar(50)
 );
 
 select * from ledger;
 
 insert into ledger(LNAME, BANK, BRANCH, ACCNO, IFSC) value('OTP Hungary', 'OTP Banka', 'OTP Serbia', '123456789', 'ID12101999');
 
 create table bank_transaction(
 TID int auto_increment primary key,
 TTYPE varchar(45),
 TDATE date,
 LID int,
 TRANS_TYPE varchar(50),
 DESCRIPTION_TEXT text,
 TRANS_DETAILS text,
 CR decimal(10,2),
 DR decimal(10,2)
 );
 
 select * from bank_transaction
 
 
 