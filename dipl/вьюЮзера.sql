alter View Vm_User
as
select top 100 m.fioContastFace as 'ФИО Работника',
m.numberContactFace as 'Номер телефона работника',
m.emailContactFace as 'Почта работника',
c.[name] as 'Компания'


from [User] m
left join InfoUserCompany i on m.id = i.idUser
left join Company c on c.id = i.idCompany
left join [Role] tm on m.idRole = tm.id


where (m.fioContastFace = m.fioContastFace and m.idRole = 1)

group by m.fioContastFace, m.emailContactFace, m.numberContactFace, c.[name]


select * from Vm_User