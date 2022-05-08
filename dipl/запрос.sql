create database CensusGoods
go
use CensusGoods
create table City
(
id int identity primary key,
[name] nvarchar(50) not null
)
create table [Role]
(
id int identity primary key,
[name] nvarchar(100)
)
create table [User]
(
id int identity primary key,
[login] nvarchar(50) not null,
[password] nvarchar(50) not null,
fioContastFace nvarchar(100) not null,
numberContactFace nvarchar(28) not null,
emailContactFace nvarchar(100) not null,
idRole int not null,
foreign key (idRole) references [Role](id)
)

create table Company
(
id int identity primary key,
[name] nvarchar(100) not null,
inn nvarchar(20) not null,
ogrn nvarchar(25) not null,
registrNum nvarchar(25) not null,
discount nvarchar(10),
city int not null,
contacts int not null
foreign key (city) references City(id),
foreign key (contacts) references [User](id)
)
create table Tariff
(
id int identity primary key,
[name] nvarchar(50) not null,
[days] nvarchar(10) not null,
cost decimal not null,
available bit default 0 not null

)
create table Sector
(
id int identity primary key,
cellSector int not null,
nameSector nvarchar(10) not null
)
create table Container
(
id int identity primary key,
idSector int not null,
[weight] nvarchar(10) not null,
height nvarchar(10) not null,
[status] bit default 0 not null,
foreign key (idSector) references Sector(id)
)
create table Product
(
id int identity primary key,
[name] nvarchar(50) not null,
[image] nvarchar(100),
[description] nvarchar(250)
)

create table InfoContainer
(
id int identity primary key,
idContainer int not null,
idProduct int not null,
QuantityProduct nvarchar(20),
CargoWeight nvarchar(20),
dateStart datetime not null,
available bit default 0 not null,
foreign key (idContainer) references Container(id),
foreign key (idProduct) references Product(id)
)

create table Receipt
(
id int identity primary key,
infoContainer int not null,
idCompany int not null,
idTariff int not null default 1,
[delay] bit not null default 0,
foreign key (infoContainer) references Container(id),
foreign key (idCompany) references Company(id),
foreign key (idTariff) references Tariff(id)
)
