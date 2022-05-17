alter View Vm_TotalReceipt
as
select top 100
c.[name] as 'Название контейнера',
comp.[name] as 'Название компании',
t.[name] as 'Тариф',
comp.discount as 'Скидка компании',
r.[delay] as 'Задолжность'

from InfoContainer ic
 right join Container c on ic.idContainer = c.id
  right join Receipt r on c.[name] = r.infoContainer
 right join Company comp on r.idCompany = comp.id
 right join Tariff t on t.id = r.idTariff

group by c.[name], comp.[name], t.[name], comp.discount, r.[delay]


select * from Vm_TotalReceipt