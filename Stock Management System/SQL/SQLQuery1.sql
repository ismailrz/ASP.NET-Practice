
Create Table StockIn(
Serial int Identity(1,1),
CategoryName Varchar(50),
CompanyName Varchar(50),
ItemName Varchar(50),
Quantity int,
DT date
);

insert into StockIn Values('HP','LG','Mobile',300,GETDATE())
Select * from StockIn
Select * from  StockIn Where CategoryName = 'HP' and CompanyName = 'LG' and ItemName = 'Mobile'
Select * from  Items Where CategoryName = 'LG' and CompanyName = 'HP' and ItemName = 'light'

Update StockIn Set Quantity = 200 Where CategoryName = 'HP' and CompanyName = 'LG' and ItemName = 'Mobile'