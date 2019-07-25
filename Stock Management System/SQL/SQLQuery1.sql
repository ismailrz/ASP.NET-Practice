
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
Create Table StockIn(
Serial int Identity(1,1),
CategoryName Varchar(50),
CompanyName Varchar(50),
ItemName Varchar(50),
AvailableQuantity int,
ReorderLevel Int, 
DT date
);
Create Table StockOut(
Serial int Identity(1,1),
CategoryName Varchar(50),
CompanyName Varchar(50),
ItemName Varchar(50),
QuantityOut int,
DT date
);

Create Table Sell_Lost_Damage(
Serial int Identity(1,1),
CategoryName Varchar(50),
CompanyName Varchar(50),
ItemName Varchar(50),
QuantityOut int,
Sell_Lost_Damage Varchar(30),
DT date
);

Insert into Sell_Lost_Damage Values ('HP','LG','Mobile',30,'sell',GETDATE())
insert into StockIn Values('HP','Nokia','Mobile',300,25,GETDATE())
insert into StockOut Values('HP','LG','Mobile',300,GETDATE())

Select * From Items
Select * From Company
Select * From Category
Select * from Sell_Lost_Damage
Select * from StockIn
Select * from StockOut

Select * from  StockIn Where CategoryName = 'HP' and CompanyName = 'LG' and ItemName = 'Mobile'
Select * from  Items Where CategoryName = 'LG' and CompanyName = 'HP' and ItemName = 'light'


Update StockIn Set Quantity = 200 Where CategoryName = 'HP' and CompanyName = 'LG' and ItemName = 'Mobile'

Delete  from StockOut;


Drop Table StockIn;