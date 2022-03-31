use task 
go
create table regform
(
Sno int identity(1,1) constraint pk_Sno primary key(Sno),
Fname varchar(30),
Lname varchar(30),
Mobile varchar(30),
Gender char(1) constraint ck_gen Check (gender in ('M','F')),
Dept varchar(30),
XMarks int,
DipXII char(30) constraint chk_batch Check (DipXII in ('12th','Diploma')),
XXMarks int,
Email varchar(20),
DOB varchar(30),
Qual char(30) constraint chk_Qual Check (Qual in ('BE','BTech','BA','ME')),
Nationality varchar(30),
Address varchar(100),
City varchar(30),
State varchar(20),
Country varchar(30),
)

select * from regform
insert into regform(Fname,Lname,Mobile,Gender,Dept,XMarks,DipXII,XXMarks,Email,DOB,Qual,Nationality,Address,City,State,Country) 
values('Sebastian','Vettel','9784575','M','F1',94,'12th',75,'sebvettel@f1.com','21-4-2000','BE','German','Munich','Berlin','Germany','europe')
insert into regform(Fname,Lname,Mobile,Gender,Dept,XMarks,DipXII,XXMarks,Email,DOB,Qual,Nationality,Address,City,State,Country) 
values('Fernando','Alonso','9784574','M','F1',84,'12th',85,'falonso@f1.com','21-2-2000','Btech','Spanish','Valencia','Catalunya','Madrid','Spain')

exec sp_help [regform]