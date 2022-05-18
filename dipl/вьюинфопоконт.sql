alter View Vm_InfoContainer
as
select top 100
c.[name] as 'Название контейнера',
p.[name] as 'Название продукта',
ic.available as 'Доступность'

from InfoContainer ic
 join Container c on ic.idContainer = c.id
 join Product p on ic.idProduct = p.id

group by c.[name], p.[name], ic.available



select * from Vm_InfoContainer