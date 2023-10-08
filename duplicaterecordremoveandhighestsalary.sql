
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

select *from #temp where Name Like '----'

with topserond as
(
select Name,salary,ROW_NUMBER() over(order by salary desc) as rownumber from #temp
)
select *from topserond where rownumber=2

select *from #temp


with duplicatedelet as
(
select Name,salary,ROW_NUMBER() over(partition by Name order by Name,salary)as deldata from #temp
)

delete from duplicatedelet where deldata >1


