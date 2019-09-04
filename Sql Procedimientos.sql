
create  proc ConsultarProd
as
select * from Producto
go

create proc AgregarProd
@nombre varchar(50),
@descripcion varchar(100),
@precio float
as
 insert into Producto values (@nombre,@descripcion,@precio);
go

create proc EliminarProd
@id_producto int
as
delete from Producto where Id_producto=@id_producto;
go

