
use tasks
go
create table product
(
ProductId int identity(1,1),
ProductName varchar(20),
Price int,
DoM date default getdate(),
Expiry date default getdate()
)
insert into product values('Axe Deo',100,getdate(),dateadd(m,1,getdate()))
insert into product values('Garnier Dye',200,getdate(),dateadd(m,2,getdate()))
insert into product values('Heineken 0.0 ',50,getdate(),dateadd(day,5,getdate()))
insert into product values('Beer Shampoo',10,getdate(),dateadd(m,5,getdate()))

select *from product


create table Customer
(
custid int identity(1,1),
Name varchar(20),
Gender char(1),
DoB varchar(20),
ContactNo varchar(10),
EmailId varchar(50),
City varchar(20)
)
insert into Customer values('Max','M','2000-06-13','4569871334','max@gmail.com','Chennai')
insert into Customer values('Stephen','M','2001-04-09','7894561235','stephen@gmail.com','MumbaiI')
insert into Customer values('Austin','M','1999-02-01','8529637415','Austin@gmail.com','CHENNAI')
insert into Customer values('Ellie Goulding','F','2001-08-10','7418529635','EllieG@gmail.com','Bangalore')

select*from Customer

create table Purchased
(
BillNo int identity(1,1),
CustID int,
ProductID int,
Quantity int,
Totatamount int
)
select*from purchased
