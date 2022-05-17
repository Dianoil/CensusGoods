alter View Vm_InfoContainer
as
select top 100
c.[name] as 'Название контейнера',
 p.[name] as 'Название продукта',

ic.available as 'Доступность'

from InfoContainer ic
left join Container c on ic.idContainer = c.id
left join Product p on ic.idProduct = p.id



select * from Vm_InfoContainer