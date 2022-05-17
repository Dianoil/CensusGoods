alter View Vm_DirGoods
as
select top 100 m.fioContastFace as 'Директор склада',
c.[name] as 'Название компании',
m.numberContactFace as 'Номер телефона компании',
m.emailContactFace as 'Почта директора'

from [User] m
left join InfoUserCompany i on m.id = i.idUser
left join Company c on c.id = i.idCompany
left join [Role] tm on m.idRole = tm.id
left join [Receipt] r on c.id = r.idCompany
left join [Receipt] on c.id = r.idTariff
left join Tariff t on t.id = r.idTariff

where (m.fioContastFace = m.fioContastFace and m.idRole = 3)

group by m.fioContastFace, c.[name], m.numberContactFace, c.discount, t.[name], m.emailContactFace


select * from Vm_DirGoods