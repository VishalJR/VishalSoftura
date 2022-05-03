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