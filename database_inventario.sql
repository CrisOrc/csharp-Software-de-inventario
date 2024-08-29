create database inventario
go
use inventario

CREATE TABLE UsuariosSistema (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Rol NVARCHAR(50) NOT NULL
)

CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT FOREIGN KEY REFERENCES UsuariosSistema(Id),
    Nombre NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    Telefono NVARCHAR(15)
)

CREATE TABLE Categorias (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL
)

CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(100),
    Marca NVARCHAR(100),
    Precio FLOAT,
    Stock INT,
    CategoriaId INT FOREIGN KEY REFERENCES Categorias(Id)
)
/**insert into Productos 
values
('Gaseosa','3 litros','marcacola',7.5,24),
('Chocolate','Tableta 100 gramos','iberica',12.5,36)

CREATE TABLE MediosPago (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Metodo NVARCHAR(100) NOT NULL
)**/

CREATE TABLE Facturas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ClienteId INT FOREIGN KEY REFERENCES Clientes(Id),
    Fecha DATETIME DEFAULT GETDATE(),
    Total FLOAT,
    MedioPagoId INT FOREIGN KEY REFERENCES MediosPago(Id)
)

CREATE TABLE FacturasProductos (
    FacturaId INT FOREIGN KEY REFERENCES Facturas(Id),
    ProductoId INT FOREIGN KEY REFERENCES Productos(Id),
    Cantidad INT NOT NULL,
    PRIMARY KEY (FacturaId, ProductoId)
)


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