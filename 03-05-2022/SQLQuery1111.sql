use tasks
go
create TABLE Customer
(
CustomerID int,
CustomerName varchar(20),
EMailID varchar(30),
MobileNo varchar(20),
constraint PK_CustId Primary key(CustomerID)
)
select * from Customer
create proc GetAllCustomers
as
select CustomerID,CustomerName,EmailID,MobileNo
from [dbo].[Customer]

insert into Customer values(1,'Stevens','Steven@gmail.com','8248030917')
insert into Customer values(2,'Max','max@gmail.com','8248596137')

create proc Insertcustomer
@id int,
@name varchar(20),
@email varchar(20),
@mobileno varchar(20)
as
insert into Customer values(@id,@name,@email,@mobileno)