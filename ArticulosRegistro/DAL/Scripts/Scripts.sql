create database ArticulosDb
go
create table Articulos
(
	ArticuloId int primary key identity(1,1),
	FechaVencimiento datetime,
	Descripcion varchar (20),
	Precio float,
	Existencia float,
	CantCotizada float
);