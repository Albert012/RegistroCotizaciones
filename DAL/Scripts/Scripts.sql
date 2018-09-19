create database CotizacionesDB
go
use CotizacionesDB
go

create table Articulos(
ArticuloId int identity primary key not null,
Fecha date,
Descripcion varchar(25),
Costo money,
Precio money,
CantidadCotizada int
);

create table Cotizaciones(
CotizacionId int identity primary key not null,
Fecha date,
Comentarios varchar(40),
Monto money
);

create table CotizacionesDetalles(
Id int identity primary key not null,
CotizacionId int not null,
ArticuloId int not null,
CantidadCotizada int,
Precio money,
Importe money
);


select * from Articulos
select * from Cotizaciones
select * from CotizacionesDetalles

