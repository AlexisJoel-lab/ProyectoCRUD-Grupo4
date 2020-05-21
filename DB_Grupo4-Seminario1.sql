use master
go
create database CursoMVC
go
Use CursoMVC
go

CREATE TABLE empleados(
	codEmp int primary key IDENTITY(1,1) ,
	nomEmp varchar(50) ,
	edadEmp int ,
	sexoEmp char(1) ,
	sueldoEmp money ,
)
go

CREATE TABLE cliente(
	idCli int IDENTITY(1,1)PRIMARY KEY NOT NULL,
	nomCli varchar(50) NOT NULL,
	apeCli varchar(50) NOT NULL,
	dniCli varchar(8) NOT NULL,
	sexCli varchar(1) NULL,
	telfCli varchar(9) NULL,
	dirCli varchar(100) NULL,
	emailCli varchar(50) NULL,
 ) 
go

CREATE TABLE producto(
	idProd int  IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nomProd varchar(50) NOT NULL,
	marcaProd varchar(50) NULL,
	modeloProd varchar(50) NULL,
	serieProd varchar(50) NULL,	
	stockProd int
)
GO
insert into empleados values ('Pepito Perez',25,'M',3000)


/*===============================PROCEDIMIENTOS ALMACENADOS==========================================*/
/*EMPLEADO===================*/
create proc MostrarEmpleados
as
select codEmp as Codigo, nomEmp as Nombre, edadEmp as Edad, sexoEmp as Sexo, sueldoEmp as Sueldo from Empleados
go
--------------------------INSERTAR 
create proc InsertarEmpleados
@nomEmp varchar (50),
@edadEmp int,
@sexoEmp char (1),
@sueldoEmp money
as
insert into Empleados values (@nomEmp,@edadEmp,@sexoEmp,@sueldoEmp)
go
------------------------ELIMINAR
create proc EliminarEmpleados
@codEmp int
as
delete from empleados 
where codEmp=@codEmp
go
------------------EDITAR
create proc EditarEmpleados
@nomEmp varchar (50),
@edadEmp int,
@sexoEmp char (1),
@sueldoEmp money,
@codEmp int
as
update empleados set nomEmp=@nomEmp, edadEmp=@edadEmp, sexoEmp=@sexoEmp, sueldoEmp=@sueldoEmp 
where codEmp=@codEmp
go

/*CLIENTE===================*/
create proc MostrarCliente
as
select idCli as Código, nomCli as Nombre, apeCli as Apellidos, dniCli as DNI, sexCli as Sexo, telfCli as Teléfono, dirCli as Dirección, emailCli as Email from cliente
go

--------------------------INSERTAR 
CREATE proc InsertarCliente
@nomCli varchar (50),
@apeCli varchar (50),
@dniCli varchar (8),
@sexCli varchar (1),
@telfCli varchar (9),
@dirCli varchar (100),
@emailCli varchar (50)
as 
Insert into cliente Values (@nomCli,@apeCli,@dniCli,@sexCli,@telfCli,@dirCli,@emailCli)
GO

--------------------------EDITAR
CREATE proc EditarCliente
@nomCli varchar (50),
@apeCli varchar (50),
@dniCli varchar (8),
@sexCli varchar (1),
@telfCli varchar (9),
@dirCli varchar (100),
@emailCli varchar (50),
@idCli int
as
Update cliente Set nomCli=@nomCli,apeCli=@apeCli,dniCli=@dniCli,sexCli=@sexCli,telfCli=@telfCli,
dirCli=@dirCli,
emailCli=@emailCli
Where idCli=@idCli
GO

--------------------------ELIMINAR
create proc EliminarCliente
@idCli int
As
Delete from cliente
Where idCli=@idCli
GO

/*PRODUCTO===================*/
create proc MostrarProducto
as
SELECT idProd as Código, nomProd as Producto, marcaProd as Marca, modeloProd as Modelo, serieProd as Serie, stockProd as Stock FROM producto
GO

--------------------------INSERTAR 
create proc InsertarProducto
@nomProd varchar (50),
@marcaProd varchar (50),
@modeloProd varchar (50),
@serieProd varchar (50),
@stockProd int
as 
Insert into producto
Values (@nomProd,@marcaProd,@modeloProd,@serieProd,@stockProd)
GO

--------------------------EDITAR
create proc EditarProducto
@nomProd varchar (50),
@marcaProd varchar (50),
@modeloProd varchar (50),
@serieProd varchar (50),
@stockProd int,
@idProd int
as
Update producto Set nomProd=@nomProd, marcaProd=@marcaProd, modeloProd=@modeloProd, serieProd=@serieProd, stockProd =@stockProd 
Where idProd=@idProd
GO

--------------------------ELIMINAR
create proc EliminarProducto
@idProd int
As
Delete from producto
Where idProd=@idProd
GO
