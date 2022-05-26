USE Project
GO
create table patient_table
(
Pid int identity(1001,1),
Fname varchar(20),
Lname varchar(20),
Gender varchar(5),
Age int,
Dob varchar(20)
)
create table doctor_table
(
DoctorId int primary key identity(20,1),
FirstName varchar(50),
LastName varchar(50),
Sex varchar(10),
Specialization varchar(30),
VisitingHours varchar(20)
)
create table Appoint_table
(
AppID int identity(1,1),
Pid int,
Special varchar(20),
Doc varchar(20),
Vdate varchar(20),
AppoinTime varchar(20)
)
select * from user_table
insert into doctor_table values('Ashok','Kumar','M','Pediatrics','9AM-11AM')
select * from doctor_table

create proc Doctorproc
@fname varchar(50),
@lname varchar(50),
@sex varchar(10),
@spec varchar(30),
@vhour varchar(20)
as
insert into doctor_table values(@fname,@lname,@sex,@spec,@vhour)

create proc userlogin
@Userid varchar(20),
@Pass varchar(10)
as
select*from user_table   where FirstName like @Userid and Password=@Pass

insert into user_table values('Max','Stevens','Password')
create proc Patientproc
@fname varchar (50),
@lname varchar (50),
@sex char(1),
@dob date
as
begin
declare @age int
set @age=(select DATEDIFF(YEAR,@dob,getdate()))
insert into patient_table(Fname,Lname,Gender,Age,Dob)
values(@fname,@lname,@sex,@age,@dob)
end

 exec Patientproc 'santhosh','kumar','M','2000-06-03'
create proc Userproc
@uname varchar(20),
@fname varchar(20),
@lname varchar(20),
@password varchar(20)
as
insert into user_table values(@uname,@fname,@lname,@password)
drop proc Userproc

select * from patient_table

drop table Appoint_table
select * from Appoint_table
create proc Appointproc
@id int,
@spec varchar(20),
@doctor varchar(20),
@visit varchar(20),
@atime varchar(20)
as
insert into Appoint_table values(@id,@spec,@doctor,@visit,@atime)

select * from patient_table
insert into patient_table values('Kick','Buttowski','M',22,'12-04-2000')

delete from Appoint_table where Vdate='2022-05-13'

create proc DelAppoint 
@id int
as
delete from Appoint_table where AppID = @id
drop proc DelAppoint

create proc ShowDetails
as 
select AppID,Pid,Special,Doc,Vdate,AppoinTime 
from Appoint_table
drop proc ShowDetails

select * from user_table

select * from Appoint_table

select * from patient_table
truncate table patient_table

select DATEDIFF(YEAR,DoB,getdate()) from patient_table




drop table patient_table

select * from patient_table

create proc Displaydoctor
as
select DoctorId,FirstName,LastName,Sex,Specialization,VisitingHours
from doctor_table

create proc Displaypatient
as
select Pid,Fname,Lname,Gender,Dob,Age
from patient_table
truncate table doctor_table
truncate table patient_table
truncate table Appoint_table