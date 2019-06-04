Create database Parcial1_JonathanMariaDb
GO
USE Parcial1_JonathanMariaDb
GO
create table Productos
(
	ProductoId int primary key identity,
	Descripcion varchar(40),
	Existencia int,
	Costo real,
	ValorEnInventario real
)

create table Inventarios
(
	InventarioId int unique,
	Valor real
)

create table Ubicaciones
(
	UbicacionId int primary key identity,
	Descripcion varchar(30)
)