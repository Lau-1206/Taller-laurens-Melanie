create database Taller
go
use Taller
go

create table Usuarios
(
  UsuarioID int primary key,
  Nombre varchar(50) not null,
  CorreoElectronico varchar(50),
  Telefono varchar(20)
)

create table Equipos
(
  EquipoID int primary key,
  TipoEquipo varchar(30) not null,
  Modelo varchar(50),
  UsuarioID int foreign key references Usuarios(UsuarioID)
)

insert into Usuarios values (1, 'Juan Perez', 'juan@uh.com', '8888-1111')
insert into Usuarios values (2, 'Maria Lopez', 'maria@uh.com', '8888-2222')
insert into Equipos values (10, 'Laptop', 'HP 15', 1)
