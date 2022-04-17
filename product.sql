create database Product
use Product
go
create table product
(
ProductId int identity(1,1),
ProductName varchar(20),
Price int,
ManufacturedAt date default getdate(),
ExpiryDate date default getdate()
)
insert into product values('Cookies',100,getdate(),dateadd(m,1,getdate()))
insert into product values('Crisps',200,getdate(),dateadd(m,2,getdate()))
insert into product values('Vegetables',50,getdate(),dateadd(day,5,getdate()))
insert into product values('Bar',10,getdate(),dateadd(m,5,getdate()))

select *from product


create table Customer
(
CustomerId int identity(1,1),
CustomerName varchar(20),
Gender char(1),
DoB date,
ContactNO varchar(10),
EmailId varchar(50),
City varchar(20)
)
insert into Customer values('Giri','M','2000-06-13','4569871334','giri@gmail.com','CHENNAI')
insert into Customer values('Vishal','M','2001-04-09','7894561235','vishal@gmail.com','MADURAI')
insert into Customer values('Ricky','M','1999-02-01','8529637415','ricky@gmail.com','CHENNAI')
insert into Customer values('Dilliman','M','2001-08-10','7418529635','dilli@gmail.com','COIMBATORE')

select*from Customer

create table Purchase
(
BillNo int identity(1,1),
CustID int,
ProductID int,
Quantity int,
Totatamount int
)
select*from purchase
