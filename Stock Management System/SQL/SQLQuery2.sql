CREATE DATABASE StockManagementSystem
use StockManagementSystem

create Table Category(
Serial int Identity(1,1),
CategoryName Varchar(50)

);
create Table Company(
Serial int Identity(1,1),
CompanyName Varchar(50)

);
create Table Items(
Serial int Identity(1,1),
CategoryName Varchar(50),
CompanyName Varchar(50),
ItemName Varchar(50),
ReorderLevel int default(0)
);

insert into Category Values('Electronics')
insert into Company Values('Symphony')

insert into Items Values('Symphony','Symphony','Mobile',5)

select * from Category
select * from Company
select * from Items

Delete from Company;


