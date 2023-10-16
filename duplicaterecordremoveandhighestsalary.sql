
create table #temp(
Id int not null Identity(1,1),
Name varchar(25),
Salary decimal(18,0)
)

insert into #temp values ('mari','9000'),('ravi','8000'),('jack','8500'),('prask','9500')

select *from #temp order by Name 

select Name,
	case 
		when Salary <=8000 then 'Below 8K'
		when Salary >8000 then 'more 8K'
		end as 'salary range'
	from #temp

select *from #temp where Name Like

-----unique values show------------
select distinct name,salary from #temp
select name from #temp group by name
---------------------------------------


--------find nth highest data-------------
with topserond as
(
select Name,salary,ROW_NUMBER() over(order by salary desc) as rownumber from #temp
)
select *from topserond where rownumber=2

select *from #temp

---------------------------------------



----remove duplicate data----------
with duplicatedelet as
(
select Name,salary,ROW_NUMBER() over(partition by Name order by Name,salary)as deldata from #temp
)

delete from duplicatedelet where deldata >1

---------------------------------------

---column into row---
SELECT EmpID, Attribute, Value
FROM (
  SELECT EmpID, FirstName, LastName, Age
  FROM Employee
) p
UNPIVOT (
  Value FOR Attribute IN (FirstName, LastName, Age)
) AS unpvt;

select Id,Name,Salary from #temp

select Id,Attribute,value from(
select Id,Name,Salary from #temp
)p
UNPIVOT(
value for Attribute in (Name)
) as unpvt


select convert(varchar,GETDATE(),103) --dd/mm/yyyy
select convert(varchar,GETDATE(),101)--mm/dd/yyyy
select FORMAT(GETDATE(),'dd/MM/yyyy') as dateformat --13/10/2023
select FORMAT(GETDATE(),'dd/MM/yy') as dateformat --13/10/23
select FORMAT(GETDATE(),'dd MMMM yy') as dateformat --13 October 23

