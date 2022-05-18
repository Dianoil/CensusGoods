alter View Vm_DirComp
as
select top 100 m.fioContastFace as '�������� ��������',
c.[name] as '�������� ��������',
m.numberContactFace as '����� �������� ��������',
c.discount as '������ ��������',
t.[name] as '����� ��������'

from [User] m
left join InfoUserCompany i on m.id = i.idUser
left join Company c on c.id = i.idCompany
left join [Role] tm on m.idRole = tm.id
left join [Receipt] r on c.id = r.idCompany
left join [Receipt] on c.id = r.idTariff
left join Tariff t on t.id = r.idTariff

where (m.fioContastFace = m.fioContastFace and m.idRole = 2)

group by m.fioContastFace, c.[name], m.numberContactFace, c.discount, t.[name]


select * from Vm_DirComp