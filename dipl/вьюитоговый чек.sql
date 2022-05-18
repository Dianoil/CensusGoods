alter View Vm_TotalReceipt
as
select top 100
c.[name] as '�������� ����������',
comp.[name] as '�������� ��������',
t.[name] as '�����',
comp.discount as '������ ��������',
r.[delay] as '�����������'

from InfoContainer ic
 join Container c on ic.idContainer = c.id
 join Receipt r on c.id = r.infoContainer
 join Company comp on r.idCompany = comp.id
 join Tariff t on t.id = r.idTariff

group by c.[name], comp.[name], t.[name], comp.discount, r.[delay]


select * from Vm_TotalReceipt