Create database Parcial1_JonathanMariaDb
GO
USE Parcial1_JonathanMariaDb
GO
create table Productos
(
	IdProducto int primary key identity,
	Descripcion varchar(40),
	Existencia Real,
	Costo real,
	ValorEnInventario real
)
