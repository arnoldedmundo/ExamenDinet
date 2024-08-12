create table Productos(
Id int primary key,
Nombre varchar(100),
Precio varchar (50),
Fecha_Creacion  varchar(50))

select * from   Productos


exec registrar_producto 2,Edmundo,4,'2024,12,05'

create procedure registrar_producto
 @id int,
 @nombre varchar(100),
 @Precio varchar(50),
 @Fecha_Creacion  varchar(50)
 as
 insert into Productos(Id,Nombre,Precio,Fecha_Creacion) values(@id,@nombre,@Precio,@Fecha_Creacion)
 go

 drop procedure registrar_producto

 create procedure listar_producto
 as
 select id,Nombre,Precio,Fecha_Creacion from Productos
 go