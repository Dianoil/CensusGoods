alter View Vm_InfoContainer
as
select top 100
c.[name] as '�������� ����������',
p.[name] as '�������� ��������',
ic.available as '�����������'

from InfoContainer ic
 join Container c on ic.idContainer = c.id
 join Product p on ic.idProduct = p.id

group by c.[name], p.[name], ic.available



select * from Vm_InfoContainer