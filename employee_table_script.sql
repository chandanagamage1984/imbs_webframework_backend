use EmployeesManagementSystem

create table employees(
id int identity(1,1) primary key,
name nvarchar(128) not null,
position nvarchar(64) not null,
department nvarchar(64) not null,
salary float not null
)