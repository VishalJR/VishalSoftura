use AdventureWorks2019
go
--Task1
select  COUNT(+[StandardCost]) Totalnoofrows
from [Production].[ProductCostHistory]
--SUM()
select SUM([StandardCost]) SumCost
from [Production].[ProductCostHistory]
--DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from [Production].[ProductCostHistory]
--ADDDATE()
SELECT DATEADD(year, 3, '2000/02/30') AS DateAdd
--CONVERT()
SELECT CONVERT(int,88.66);
--LEFT()
SELECT LEFT('VETTEL', 3) AS ExtractString;
--LEN()
select LEN('MAX')
--REVERSE()
select REVERSE('MAX STEVENS')
--Task2
create function fn_RupeesC(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'₹'+@amount)
end
select BusinessEntityID,dbo.fn_RupeesC(rate) as Dollar 
from HumanResources.EmployeePayHistory
--Task3
create table tbl_student
(
Sno int,
StuName varchar(20),
StuAge int
)
alter table tbl_student
add Gender char(1)
select * from tbl_student
alter table tbl_student
add MobileNO int
insert into tbl_student values(1,'CAM',19,'M',233007)
alter table tbl_student
alter column MobileNO char(10)
create view vw_ss
as
select [Sno],[StuName],[StuAge]
from [dbo].[tbl_student]
go
select *from vw_ss
insert into tbl_student values(2,'ERIK',19,'M',856485)
--Task4
use trial
go
select * from dbo.tbl_just
create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

taskIns_sp 'Max','M'
create proc taskup_sp
@sno int,
@age int,
@name varchar(50)
as
update tbl_just set sno=@sno,age=@age where name = @name

task1_sp 1,19,'Max'
create proc taskDel_sp
@sno int
as
delete from tbl_just where sno = @sno

taskDel_sp 1
--Task5
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))
--Task6
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]

--Task7
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name