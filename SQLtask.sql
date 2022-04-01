use AdventureWorks2019
go
--Task1
select Firstname,Lastname
from Person.Person
where Title is not NULL
--Task2
select Firstname,Lastname
from Person.Person
where Firstname like '%a%' and Lastname like '%a%'
--Task3
select dc.CurrencyCode,Name
 from Sales.Currency,Sales.CountryRegionCurrency dc

 --Task4

 --Task5
create table tbl_table
(
Sno int identity(1,1) ,
Fname varchar(30),
Lname varchar(30),
Nationality varchar(30),
Country varchar(30),
)
insert into tbl_table values('Haas','Ferrari','American','USA')
insert into tbl_table values('Alfa Romeo','Ferrari','American','UK')
insert into tbl_table values('Scuderia','Ferrari','Italian','Italy')
insert into tbl_table values('Alpine','Renault','English','UK')
insert into tbl_table values('McLaren','Mercedes','American','USA')
insert into tbl_table values('Aston Martin','Mercedes','American','USA')
insert into tbl_table values('Williams','Merecedes','American','USA')
insert into tbl_table values('Alphatauri','Honda','Japanese','Japan')
insert into tbl_table values('Red Bull','Honda','Japanese','Japan')
insert into tbl_table values('Repsol','Honda','Japanese','Japan')
insert into tbl_table values('Kawasaki','Engine','Japanese','UK')
insert into tbl_table values('Mercedes','AMG','British','UK')
insert into tbl_table values('Mercedes','AMG','British','UK')
insert into tbl_table values('Mercedes','AMG','British','UK')
insert into tbl_table values('Mercedes','AMG','British','UK')
insert into tbl_table values('Mercedes','AMG','British','UK')
insert into tbl_table values('Mercedes','AMG','British','UK')
insert into tbl_table values('Mercedes','AMG','British','UK')
insert into tbl_table values('Mercedes','AMG','British','UK')
insert into tbl_table values('Mercedes','AMG','British','UK')


select * from tbl_table

--Task6
select B.BusinessEntityID, Addresstypeid, H.DepartmentID
from HumanResources.Department H
join HumanResources.EmployeeDepartmentHistory E
on  H.DepartmentID = E.DepartmentID
join Person.BusinessEntityAddress B
on E.BusinessEntityID = B.BusinessEntityID

--Task 7
select distinct Groupname
from HumanResources.Department
--Task8
select a.standardcost,sum(listprice) sum1,sum(a.standardcost+ListPrice) Sum2
from Production.Product a
join Production.ProductCostHistory b
on a.ProductID = b.ProductID
group by a.StandardCost
--Task9
select datediff (YY,StartDate,EndDate) as YOA
from HumanResources.EmployeeDepartmentHistory
--Task10
select sum(SalesQuota)
 from Sales.SalesPersonQuotaHistory
 where SalesQuota>5000 and salesquota<100000
 group by SalesQuota
--Task11
select max(taxrate) as Max_taxrate
from sales.SalesTaxRate
--Task12
select hd.BusinessEntityID,dept.DepartmentID,ShiftID
from HumanResources.Employee He
join HumanResources.EmployeeDepartmentHistory hd
on he.BusinessEntityID=hd.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=hd.DepartmentID
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee
--Task13
create view View_name
as
select His.ShiftID,Emp.BirthDate,datediff(YY,emp.BirthDate,Getdate()) as age
from HumanResources.Employee emp
join HumanResources.EmployeeDepartmentHistory His
on His.BusinessEntityID=emp.BusinessEntityID
join HumanResources.Department dept
on His.BusinessEntityID =dept.DepartmentID

go
select * from View_name
--Task14
SESELECT count(*) No_of_rows_hr
FROM [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]
--Task15
select max(rate) as MaxSalary,Name
from HumanResources.EmployeePayHistory pay
join HumanResources.EmployeeDepartmentHistory dhis
on pay.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = dhis.DepartmentID
GRoup By name
--Task16
select FirstName,MiddleName,Title,dhis.BusinessEntityID
from Person.BusinessEntityAddress dhis
left outer join Person.Person pp
on pp.BusinessEntityID=dhis.BusinessEntityID
where title is not null
--Task17
select productID,LocationID,Shelf
from Production.ProductInventory
where ProductID>300 and ProductID<=350 and Shelf ='E'
--task18
select pl.LocationID,Shelf,name
from Production.ProductInventory s
inner join Production.Location pl
on s.LocationID=pl.LocationID
--Task19
select AddressID,AddressLine1,AddressLine2, pq.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince ps
join Person.Address pq
on ps.StateProvinceID=pq.StateProvinceID
--Task20
select sum([SubTotal]),sum([TaxAmt])
from [Sales].[CountryRegionCurrency] crc
join [Sales].[SalesTerritory] st
on crc.[CountryRegionCode]=st.[CountryRegionCode]
join [Sales].[SalesOrderHeader] soh
on st.[TerritoryID]=soh.[TerritoryID]
group by st.[TerritoryID]
