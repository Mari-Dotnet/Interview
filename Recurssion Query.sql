--Recurssion
create table #Employee(
EmployeeId int identity(1,1) ,
EmployeeName nvarchar(20),
ManagerId int 
)


--insert the data into temp table
insert into #Employee(EmployeeName,ManagerId)  values 
('Mari',0),
('Venkat',1),
('Prakash',2),
('Dhiya',3),
('Senthil',1),
('Ravi',5),
('Poorani',1),
('Mahilavi',7),
('Mahesh',1),
('Mani',1),
('muthili',10),
('Siddhu',11),
('diya',11),
('amul',9)

--read the data
select *from #Employee

-- when  manager Id is 0 they are top level
select *from #Employee where ManagerId=


select *from #Employee  



with employeecte as (
 -- Anchor
 select EmployeeId,EmployeeName,ManagerId from  #Employee
 where EmployeeId=13

 union all
 select #Employee.EmployeeId,#Employee.EmployeeName,#Employee.ManagerId from  #Employee
 join employeecte as ect on #Employee.EmployeeId= ect.ManagerId

)

select  ect.EmployeeId,ect.EmployeeName,emp.EmployeeName as 'Manager Name'  from employeecte as ect
left  join #Employee as emp on ect.ManagerId=emp.EmployeeId