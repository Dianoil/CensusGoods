create database CensusGoods
go
use CensusGoods
create table City
(
Id int identity primary key,
Name nvarchar(50) not null
)
create table Contacts
(
Id int identity primary key,
FioContastFace nvarchar(100),
NumberContactFace nvarchar(11),
EmailContactFace nvarchar(100)
)

create table ControlQuestion
(
Id int identity primary key,
Name nvarchar(50) not null
)

insert into ControlQuestion
values
('������� ������� ������'),
('������ ��������� ���������'),
('����� �����'),
('��� ����')

create table TypeCompany
(
Id int identity primary key,
Name nvarchar(50) not null
)
insert into TypeCompany
values
('���������'),
('�������')

create table Valute
(
Id int identity primary key,
Name nvarchar(50) not null
)
insert into Valute
values
('RUB'),
('KZH'),
('YUAN'),
('BYN')
create table Company
(
Id int identity primary key,
Name nvarchar(100) not null,
Inn nvarchar(12) not null,
Ogrn nvarchar(13) not null,
City int not null,
Contacts int not null,
Email nvarchar(100) not null,
Password nvarchar(100) not null,
IdTypeCompany int not null,
IdValute int not null,
IdControlQuestion int not null,
foreign key (IdTypeCompany) references TypeCompany(Id),
foreign key (IdValute) references Valute(Id),
foreign key (IdControlQuestion) references ControlQuestion(Id),
foreign key (City) references City(Id),
foreign key (Contacts) references Contacts(Id)
)
create table Product
(
Id int identity primary key,
Name nvarchar(100) not null,
Price decimal not null default 0,
Comment nvarchar(200),
Image nvarchar(50)
)
create table Supply
(
Id int identity primary key,
IdCompany int not null,
DateSuppl datetime not null,
foreign key (IdCompany) references Company(Id)

)
create table SupplyInfo
(
Id int identity primary key,
IdSupply int not null,
IdProduct int not null,
Quantity int not null default 0,
foreign key (IdSupply) references Supply(Id),
foreign key (IdProduct) references Product(Id)
)
create table Sector
(
Id int identity primary key,
CellSector int not null,
RangeSector int not null,
NameSector nvarchar(10)
)
create table SectorProduct
(
Id int identity primary key,
IdProduct int not null,
IdSector int not null,
foreign key (IdProduct) references Product(Id),
foreign key (IdSector) references Sector(Id)
)
create table TypePayment
(
Id int identity primary key,
Name nvarchar(50)
)
insert into TypePayment
values
('��������'),
('� ����')
create table Ordery
(
Id int identity primary key,
IdSector int not null,
TypePayment int not null,
OrdDate datetime not null,
foreign key (IdSector) references Sector(Id),
foreign key (TypePayment) references TypePayment(Id),
)
create table ProductInfo
(
Id int identity primary key,
IdCompany int not null,
IdProduct int not null,
foreign key (IdProduct) references Product(Id),
foreign key (IdCompany) references Company(Id)
)
create table OrderInfo
(
Id int identity primary key,
IdOrder int not null,
IdProduct int not null,
Comment nvarchar(200),
Quantity int not null default 0,
foreign key (IdProduct) references Product(Id),
foreign key (IdOrder) references Ordery(Id)
)
