alter View Vm_InfoContainer
as
select top 100
c.[name] as 'Название контейнера',
p.[name] as 'Название продукта',
comp.[name] as 'Название компании',
ic.available as 'Доступность'

from Receipt r
 join InfoContainer ic on r.infoContainer = ic.id
 join Container c on ic.idContainer = c.id
 join Product p on ic.idProduct = p.id
 join Company comp on r.idCompany = comp.id

group by c.[name], p.[name], ic.available, comp.[name]



select * from Vm_InfoContainer