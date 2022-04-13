create database CensusGoods
go
use CensusGoods
create table City
(
Id int identity primary key,
Name nvarchar(50) not null
)
create table Roly
(
Id int identity primary key,
<<<<<<< Updated upstream
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
('Девичья фамилия матери'),
('Кличка домашнего животного'),
('Номер школы'),
('Имя отца')

create table TypeCompany
(
Id int identity primary key,
Name nvarchar(50) not null
)
insert into TypeCompany
values
('Розничный'),
('Оптовый')

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
=======
Name nvarchar(50) not null
)
create table Users
(
Id int identity primary key,
Login nvarchar(50) not null,
Password nvarchar(50) not null,
FioContastFace nvarchar(100) not null,
NumberContactFace nvarchar(28) not null,
EmailContactFace nvarchar(100) not null,
IdRole int not null,
foreign key (IdRole) references Roly(id)
)
>>>>>>> Stashed changes
create table Company
(
Id int identity primary key,
Name nvarchar(100) not null,
Inn nvarchar(20) not null,
Ogrn nvarchar(25) not null,
City int not null,
RegistrNum nvarchar(25),
Contacts int not null,
<<<<<<< Updated upstream
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
=======
foreign key (City) references City(Id),
foreign key (Contacts) references Users(Id)
>>>>>>> Stashed changes
)
create table Discount
(
<<<<<<< Updated upstream
Id int identity primary key,
Name nvarchar(100) not null,
Price decimal not null default 0,
Comment nvarchar(200),
Image nvarchar(50)
)
create table Supply
(
Id int identity primary key,
=======
IdDiscount int identity primary key,
>>>>>>> Stashed changes
IdCompany int not null,
Percenti int not null,
DateBegin datetime not null,
DateEnd datetime not null,
Available bit not null default 0,
foreign key (IdCompany) references Company(Id)
)
create table Transport
(
Id int identity primary key,
GosNum nvarchar(100) not null,
Model nvarchar(50) not null,
FIODriver nvarchar(100) not null,
PhoneDriver nvarchar(20) not null
)
create table Tariff
(
Id int identity primary key,
Name nvarchar(50) not null,
DateTariff int not null,
Available bit default 0,
Cost decimal not null
)
create table PayStatus
(
Id int identity primary key,
Status nvarchar(50) not null
)
<<<<<<< Updated upstream
insert into TypePayment
values
('Оплачено'),
('В долг')
create table Ordery
(
Id int identity primary key,
IdSector int not null,
TypePayment int not null,
OrdDate datetime not null,
foreign key (IdSector) references Sector(Id),
foreign key (TypePayment) references TypePayment(Id),
=======
create table Receipt
(
IdReceipt int identity primary key,
IdTariff int not null,
IdStatus int not null default 2,
IdDiscount int not null,
DateStart datetime not null,
DateEnd datetime not null,
Delays nvarchar(100) not null default 0,
foreign key (IdTariff) references Tariff(Id),
foreign key (IdDiscount) references Discount(IdDiscount),
foreign key (IdStatus) references PayStatus(Id)
>>>>>>> Stashed changes
)
create table Sector
(
Id int identity primary key,
CellSector int not null,
RangeSector int not null,
NameSector nvarchar(10),
Status bit not null default 0
)
create table InfoTransport
(
Id int identity primary key,
IdTransport int not null,
IdSector int not null,
IdReceipt int not null,
foreign key (IdTransport) references Transport(Id),
foreign key (IdSector) references Sector(Id),
foreign key (IdReceipt) references Receipt(IdReceipt)
)
