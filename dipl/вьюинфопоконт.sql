alter View Vm_InfoContainer
as
select top 100
c.[name] as '�������� ����������',
 p.[name] as '�������� ��������',

ic.available as '�����������'

from InfoContainer ic
left join Container c on ic.idContainer = c.id
left join Product p on ic.idProduct = p.id



select * from Vm_InfoContainer