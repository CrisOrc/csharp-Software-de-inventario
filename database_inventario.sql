CREATE DATABASE inventario;
GO
USE inventario;
GO

CREATE TABLE UsuariosSistema (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Rol NVARCHAR(50) NOT NULL
);

CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    Telefono NVARCHAR(15)
);

CREATE TABLE Categorias (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(100),
    Marca NVARCHAR(100),
    Precio FLOAT,
    Stock INT,
    CategoriaId INT FOREIGN KEY REFERENCES Categorias(Id)
);

CREATE TABLE MediosPago (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Metodo NVARCHAR(100) NOT NULL
);

CREATE TABLE Facturas (
    Id INT IDENTITY(1,1) PRIMARY KEY,	
    ClienteId INT FOREIGN KEY REFERENCES Clientes(Id),
    Fecha DATETIME DEFAULT GETDATE(),
    Total FLOAT,
    MedioPagoId INT FOREIGN KEY REFERENCES MediosPago(Id),
	FacturadorId INT FOREIGN KEY REFERENCES UsuariosSistema(Id)
);

CREATE TABLE FacturasProductos (
    FacturaId INT FOREIGN KEY REFERENCES Facturas(Id),
    ProductoId INT FOREIGN KEY REFERENCES Productos(Id),
    Cantidad INT NOT NULL,
    Precio FLOAT NOT NULL, 
    PrecioTotal AS (Cantidad * Precio) PERSISTED,
    PRIMARY KEY (FacturaId, ProductoId)
);



---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
/*go

create proc MostrarProductos
as
select *from Productos
go
--------------------------INSERTAR 
create proc InsetarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int
as
insert into Productos values (@nombre,@descrip,@marca,@precio,@stock)
go
------------------------ELIMINAR
create proc EliminarProducto
@idpro int
as
delete from Productos where Id=@idpro
go
------------------EDITAR
create proc EditarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int,
@id int
as
update Productos set Nombre=@nombre, Descripcion=@descrip, Marca=@marca, Precio=@precio, Stock=@stock where Id=@id
go*/