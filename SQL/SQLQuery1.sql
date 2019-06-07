USE BDALBERDI

--THE DROP TABLE
DROP TABLE Usuarios
DROP TABLE Producto_Categoria
DROP TABLE Producto_Marca
DROP TABLE Marcas
DROP TABLE Categorias
DROP TABLE Descuentoss
DROP TABLE Ajuste_Precio
DROP TABLE Ajuste_Stock 
DROP TABLE Detalle_Factura_Compra 
DROP TABLE Factura_Compras
DROP TABLE Proveedores
DROP TABLE Detalle_Venta_Error
DROP TABLE Venta_Error
DROP TABLE Detalle_Venta
DROP TABLE Productos
DROP TABLE Boleta_Venta
DROP TABLE Factura_Venta
DROP TABLE Nota_Debito
DROP TABLE Nota_Credito 
DROP TABLE Ventas
DROP TABLE Empleados
DROP TABLE Clientes







--THE CREATE TABLE
CREATE TABLE Usuarios(
	Id_usuario tinyint not null IDENTITY(1,1) , -- (2)
	Rut_empleado int not null  UNIQUE,          -- (8)
	Contraseña varchar(8) not null,             -- (8)
	Permisos tinyint                           -- (2)->(1)?
 
)
CREATE TABLE Empleados(
	Rut_empleado int not null ,                 -- (8)
	Nombres varchar(20) ,                       -- (20)
	Apellido_p varchar(20),               -- (20)
	Apellido_m varchar(20),               -- (20)
	Telefono_f char(8),                         -- (8)
	Telefono_c char(9),                         -- (9)
	False_delete bit default 0					-- (1)
)
CREATE TABLE Clientes(
	Rut_cliente int not null ,                  -- (8)
	Nombres varchar(20) ,                       -- (20)
	Apellido_p varchar(20),                     -- (20)
	Apellido_m varchar(20),                     -- (20)
	Descuento tinyint,                          -- (2)
	False_delete bit default 0					-- (1)
)
CREATE TABLE Proveedores(
	Rut_proveedor int not null ,                -- (8)
	Nombres varchar(20) ,                       -- (20)
	Apellido_p  varchar(20),               -- (20)
	Apellido_m varchar(20),               -- (20)
	Telefono_f char(8),                         -- (8)
	Telefono_c char(9),							-- (9)
	Email varchar(30),							-- (30)
	Direccion varchar(35),						-- (35)
	False_delete bit default 0					-- (1)
)
Create Table Ventas(--OJO POR DONDE EMPIEZA
	Num_venta int not null IDENTITY(1,1),		-- (6)
	Rut_cliente int not null,					-- (8)
	Rut_empleado int not null,					-- (8)
	Fecha date,									-- (10)
	Hora time,									-- (8)
	Subtotal int,								-- (7)
	Descuento int,								-- (7)
	Total int,									-- (7)
	Iva int,									-- (7)
	Medio_pago tinyint,							-- (1)
	Factura bit,								-- (1)
	Boleta bit,									-- (1)
	Nota_credito bit,							-- (1)
	Nota_debito bit								-- (1)
)
Create Table Detalle_Venta(
	Num_venta int not null,						-- (6)
	Id_producto SMALLINT not null,				-- (4)
	Cantidad SMALLINT,							-- (3)
	Precio int,									-- (7)
	Subtotal int,								-- (7)
	Descuento int,								-- (7)
	Total int									-- (7)
)
Create Table Venta_Error(
	Id_Error SMALLINT not null IDENTITY(1,1),   -- (4)
	Num_venta int not null ,					-- (6)
	Subtotal int,								-- (7)
	Descuento int,								-- (7)
	Total int,									-- (7)
	Iva int										-- (7)
)
Create Table Detalle_Venta_Error(
	Id_error SMALLINT  not null,				-- (4)
	Id_producto SMALLINT not null,			    -- (4)
	Cantidad SMALLINT,							-- (3)
	Precio int,									-- (7)
	Subtotal int,								-- (7)
	Descuento int,								-- (7)
	Total int									-- (7)
)
CREATE TABLE Descuentos(
	Id_descuento SMALLINT not null IDENTITY(1,1),-- (4)
	Id_producto SMALLINT not null,              -- (4)
	Fecha_inicio date,							-- (10)
	Fecha_termino date,							-- (10)
	Condicion varchar(10)						-- (10)->SEGURO
)
CREATE TABLE Boleta_Venta(
	Num_folio int not null IDENTITY(1,1),		-- (7)--> OJO POR DONDE COMIENZA
	Num_venta int not null,						-- (6)
	Codigo_xml xml								-- (?)--> NI IDEA DEL LARGO QUE TENDRA 
)
CREATE TABLE Factura_Venta(
	Num_folio int not null IDENTITY(1,1),		-- (7)--> OJO POR DONDE COMIENZA
	Num_venta int not null,						-- (6)
	Codigo_xml xml								-- (?)--> NI IDEA DEL LARGO QUE TENDRA 
)
CREATE TABLE Nota_Credito(
	Num_folio int not null IDENTITY(1,1),		-- (7)--> OJO POR DONDE COMIENZA
	Num_venta int not null,						-- (6)
	Codigo_xml xml								-- (?)--> NI IDEA DEL LARGO QUE TENDRA 
)
CREATE TABLE Nota_Debito(
	Num_folio int not null IDENTITY(1,1),		-- (7)--> OJO POR DONDE COMIENZA
	Num_venta int not null,						-- (6)
	Codigo_xml xml								-- (?)--> NI IDEA DEL LARGO QUE TENDRA 
)
CREATE TABLE Productos(
	Id_producto SMALLINT not null IDENTITY(1,1),-- (4)
	Nombre varchar(50),							-- (50)
	Precio int,									-- (7)
	Stock smallint,								-- (3)
	Stock_critico tinyint,						-- (2)
	Codigo_producto char(13), 		 			-- (13)
	False_delete bit default 0					-- (1)
)
CREATE TABLE Producto_Categoria(
	Id_producto SMALLINT not null,			    -- (4)
	Id_categoria smallint not null				-- (3)
)
CREATE TABLE Categorias(
	Id_categoria smallint not null IDENTITY(1,1),-- (3)
	Nombre varchar(50),							-- (50)
	Codigo smallint,							-- (4)
	False_delete bit default 0					-- (1)
)

CREATE TABLE Producto_Marca(
	Id_producto SMALLINT not null,
	Id_marca    SMALLINT not null
)
CREATE TABLE Marcas(
	Id_marca SMALLINT NOT NULL IDENTITY(1,1),   -- (4)
	Nombre VARCHAR(50)							-- (50)
)
CREATE TABLE Ajuste_Precios(
	Id_producto SMALLINT not null,		    	-- (4)
	Fecha date not null,						-- (10)
	Hora time not null,							-- (8)
	Precio int not null,						-- (7)
	Rut_empleado int not null					-- (8)
)
CREATE TABLE Ajuste_Stock(
	Id_producto SMALLINT not null,				-- (4)
	Fecha date not null,						-- (10)
	Hora time not null,							-- (8)
	Cantidad Smallint,							-- (7)
	Razon tinyint,								-- (1)
	Stock Smallint,								-- (3)
	Rut_empleado int not null					-- (8)

)
Create Table Factura_Compra(
	Num_folio int not null,						-- (6)
	Rut_proveedor int not null,					-- (8)
	Fecha date,									-- (7)
	Iva int,									-- (7)
    Total int									-- (7)
)
Create Table Detalle_Factura_Compra(
	Num_folio int not null,						-- (6)
	Id_producto smallint not null,				-- (4)
	Cantidad smallint,							-- (3)
	Precio int,									-- (7)
	Subtotal int								-- (7)
)


--THE SELECT TABLE'S
---SELECT Id_usuario FROM Usuario where Rut_empleado = 20093264
SELECT * FROM Usuarios
SELECT * FROM Empleados
SELECT * FROM Clientes
SELECT * FROM Proveedores
SELECT * FROM Ventas
SELECT * FROM Detalle_Venta
SELECT * FROM Venta_Error
SELECT * FROM Detalle_Venta_Error
SELECT * FROM Descuentos
SELECT * FROM Boleta_Venta
SELECT * FROM Factura_Venta
SELECT * FROM Nota_Credito
SELECT * FROM Nota_Debito
SELECT * FROM Productos
SELECT * FROM Producto_Categoria
SELECT * FROM Categorias 
SELECT * FROM Producto_Marca 
SELECT * FROM Marcas 
SELECT * FROM Ajuste_Precios
SELECT * FROM Ajuste_Stock
SELECT * FROM Factura_Compra
SELECT * FROM Detalle_Factura_Compra 


-- Primary Keys
ALTER TABLE Usuarios
	ADD CONSTRAINT pk_usuario  PRIMARY KEY(Id_usuario ); 
ALTER TABLE Empleados
	ADD CONSTRAINT pk_empleado PRIMARY KEY(Rut_empleado);
ALTER TABLE Clientes
	ADD CONSTRAINT pk_cliente PRIMARY KEY(Rut_cliente);
ALTER TABLE Proveedores
	ADD CONSTRAINT pk_proveedor PRIMARY KEY(Rut_proveedor);
ALTER TABLE Ventas
	ADD CONSTRAINT pk_venta PRIMARY KEY(Num_venta);
ALTER TABLE Detalle_Venta
	ADD CONSTRAINT pk_detalle_venta PRIMARY KEY(Num_venta,Id_producto);
ALTER TABLE Venta_Error
	ADD CONSTRAINT pk_venta_error PRIMARY KEY(Id_error);
ALTER TABLE Detalle_Venta_Error
	ADD CONSTRAINT pk_detalle_venta_error PRIMARY KEY(Id_error,Id_producto); 
ALTER TABLE Descuentos
	ADD CONSTRAINT pk_descuentos PRIMARY KEY(Id_descuento);
ALTER TABLE Boleta_Venta
	ADD CONSTRAINT pk_boleta_venta PRIMARY KEY(Num_venta,num_folio);
ALTER TABLE Factura_Venta
	ADD CONSTRAINT pk_factura_venta PRIMARY KEY(Num_venta,num_folio);
ALTER TABLE Nota_Credito
	ADD CONSTRAINT pk_nota_credito PRIMARY KEY(Num_venta,num_folio);
ALTER TABLE Nota_Debito
	ADD CONSTRAINT pk_nota_debito PRIMARY KEY(Num_venta,num_folio);
ALTER TABLE Productos
	ADD CONSTRAINT pk_producto PRIMARY KEY(Id_producto);
ALTER TABLE Producto_Categoria
	ADD CONSTRAINT pk_producto_categoria PRIMARY KEY(Id_producto,Id_categoria);
ALTER TABLE Categorias
	ADD CONSTRAINT pk_categoria PRIMARY KEY(Id_categoria); 
ALTER TABLE Producto_Marca
	ADD CONSTRAINT pk_producto_marca PRIMARY KEY(Id_producto,Id_marca);
ALTER TABLE Marcas
	ADD CONSTRAINT pk_marca PRIMARY KEY(Id_marca);
ALTER TABLE Ajuste_Precios
	ADD CONSTRAINT pk_ajuste_precio PRIMARY KEY(Id_producto,Fecha,Hora);
ALTER TABLE Ajuste_Stock
	ADD CONSTRAINT pk_ajuste_stock PRIMARY KEY(Id_producto,Fecha,Hora);
ALTER TABLE Factura_Compra
	ADD CONSTRAINT pk_factuta_compra PRIMARY KEY(Num_folio);
ALTER TABLE Detalle_Factura_Compra
	ADD CONSTRAINT pk_detalle_factura_compra PRIMARY KEY(Num_folio,Id_producto);
 

-- Foreign Keys
ALTER TABLE Usuarios
	ADD CONSTRAINT fk_usuario_empleado 
	FOREIGN KEY(Rut_empleado) REFERENCES EmpleadoS(Rut_empleado);

ALTER TABLE Ventas
	ADD CONSTRAINT fk_venta_cliente
	FOREIGN KEY(Rut_cliente) REFERENCES ClienteS(Rut_cliente);
ALTER TABLE Ventas
	ADD CONSTRAINT fk_venta_empleado 
	FOREIGN KEY(Rut_empleado) REFERENCES EmpleadoS(Rut_empleado);

ALTER TABLE Detalle_Venta
	ADD CONSTRAINT fk_detalleVenta_numVenta
	FOREIGN KEY(Num_venta) REFERENCES Ventas(Num_venta);
ALTER TABLE Detalle_Venta
	ADD CONSTRAINT fk_detalleVenta_producto
	FOREIGN KEY(Id_producto) REFERENCES Productos(Id_producto);  
  
ALTER TABLE Venta_Error
	ADD CONSTRAINT fk_ventaError_numVenta 
	FOREIGN KEY(Num_venta) REFERENCES Ventas(Num_venta);

ALTER TABLE Detalle_Venta_Error
	ADD CONSTRAINT fk_detalleVentaError_ventaError
	FOREIGN KEY(Id_error) REFERENCES Venta_Error(Id_error);
ALTER TABLE Detalle_Venta_Error
	ADD CONSTRAINT fk_detalleVentaError_producto
	FOREIGN KEY(Id_producto) REFERENCES Productos(Id_producto);  
 
ALTER TABLE Descuentos
	ADD CONSTRAINT fk_descuento_producto 
	FOREIGN KEY(Id_producto) REFERENCES Productos(Id_producto);

ALTER TABLE Boleta_Venta
	ADD CONSTRAINT fk_boletaVenta_venta 
	FOREIGN KEY(Num_venta) REFERENCES Ventas(Num_venta);

ALTER TABLE Nota_Debito
	ADD CONSTRAINT fk_notaDebito_venta 
	FOREIGN KEY(Num_venta) REFERENCES Ventas(Num_venta);

ALTER TABLE Nota_Credito
	ADD CONSTRAINT fk_notaCredito_venta 
	FOREIGN KEY(Num_venta) REFERENCES Ventas(Num_venta);

ALTER TABLE Factura_Venta
	ADD CONSTRAINT fk_facturaVenta_venta 
	FOREIGN KEY(Num_venta) REFERENCES Ventas(Num_venta);

ALTER TABLE Producto_Categoria
	ADD CONSTRAINT fk_productoCategoria_producto 
	FOREIGN KEY(Id_producto) REFERENCES Productos(Id_producto);
ALTER TABLE Producto_Categoria
	ADD CONSTRAINT fk_productoCategoria_categoria 
	FOREIGN KEY(Id_categoria) REFERENCES Categorias(Id_categoria);

ALTER TABLE Producto_Marca
	ADD CONSTRAINT fk_productoMarca_producto 
	FOREIGN KEY(Id_producto) REFERENCES Producto(Id_producto);
ALTER TABLE Producto_Marca
	ADD CONSTRAINT fk_productoMarca_categoria 
	FOREIGN KEY(Id_marca) REFERENCES Marcas(Id_marca);

ALTER TABLE Ajuste_Precios
	ADD CONSTRAINT fk_ajustePrecio_producto 
	FOREIGN KEY(Id_producto) REFERENCES Productos(Id_producto);

ALTER TABLE Ajuste_Stock
	ADD CONSTRAINT fk_ajusteStock_producto 
	FOREIGN KEY(Id_producto) REFERENCES Productos(Id_producto);


ALTER TABLE Factura_Compra
	ADD CONSTRAINT fk_facturaCompra_proveedor 
	FOREIGN KEY(Rut_proveedor) REFERENCES Proveedores(Rut_proveedor);

ALTER TABLE Detalle_Factura_Compra
	ADD CONSTRAINT fk_detalleFacturaCompra_facturaCompra 
	FOREIGN KEY(Num_folio) REFERENCES Factura_Compra(Num_folio);
ALTER TABLE Detalle_Factura_Compra
	ADD CONSTRAINT fk_detalleFacturaCompra_producto 
	FOREIGN KEY(Id_producto) REFERENCES Productos(Id_producto);


 --THE INSERT TABLE'S
INSERT INTO Empleados(Rut_empleado,Nombres,Apellido_p,Apellido_m,telefono_f,telefono_c)
	VALUES(20093264,'Kevin Alan','Peralta', 'Lopez',null,'994740752')
INSERT INTO Empleados(Rut_empleado,Nombres,Apellido_p,Apellido_m,telefono_f,telefono_c)
	VALUES(20107427,'Juan Pablo','Cortez', 'Marin',null,'741852963')


INSERT INTO Usuarios(Rut_empleado,Contraseña,Permisos) VALUES(20093264,'admin',3)
INSERT INTO Usuarios(Rut_empleado,Contraseña,Permisos) VALUES(20107427,'admin',3)



INSERT INTO Clientes(Rut_cliente,Nombres,Apellido_p,Apellido_m,Descuento)
	VALUES(20093264,'Kevin Alan','Peralta', 'Lopez',15)
INSERT INTO Clientes(Rut_cliente,Nombres,Apellido_p,Apellido_m,Descuento)
	VALUES(20107427,'Juan Pablo','Cortez', 'Marin',33) 
  
INSERT INTO Proveedores(Rut_proveedor,Nombres,Apellido_paterno,Apellido_materno,telefono_f,telefono_c,Email,Direccion)
	VALUES(20093264,'Kevin Alan','Peralta', 'Lopez',null,'994740752','kevin.peralta@sansano.usm.cl','viña')
INSERT INTO Proveedores (Rut_proveedor,Nombres,Apellido_paterno,Apellido_materno,telefono_f,telefono_c,Email,Direccion)
	VALUES(20107427,'Juan Pablo','Cortez', 'Marin',null,'741852963','juan.cortez@sansano.usm.cl','viña')

INSERT INTO Ventas(Rut_cliente,Rut_empleado,Fecha,Hora,Subtotal,Descuento,Total,Iva,Medio_pago,Factura,Boleta,Nota_credito,Nota_debito)
	VALUES(20093264,20093264,SYSDATETIME( ),SYSDATETIME( ),100,10,90,12,1,0,1,0,0)

INSERT INTO Categorias(Nombre,codigo)
	VALUES('Materiales de Construccion',101)
INSERT INTO Categorias(Nombre,codigo)
	VALUES('Alargadores y extensiones',201)
INSERT INTO Categorias(Nombre,codigo)
	VALUES('Interruptores y Tableros',202)
INSERT INTO Categorias(Nombre,codigo)
	VALUES('WC y Sanitarios',301)
INSERT INTO Categorias(Nombre,codigo)
	VALUES('Muebles de Cocina',401)

INSERT INTO Productos(Nombre,Precio,Stock,Stock_critico)
	VALUES('Ibirica Cemento gris 5kg',1990,10,5)
INSERT INTO Productos(Nombre,Precio,Stock,Stock_critico)
	VALUES('Halux Extension electrica con seguro 30m Naranja',11990,9,5)
INSERT INTO Productos(Nombre,Precio,Stock,Stock_critico)
	VALUES('Legrand Interruptores diferenciales 40A',44190,12,5)
INSERT INTO Productos(Nombre,Precio,Stock,Stock_critico)
	VALUES('Combo Sanitario + Estanque Infantil',98480,20,5)
INSERT INTO Productos(Nombre,Precio,Stock,Stock_critico)
	VALUES('Just Home Collection Mueble base 60x60 melamina',69990,8,5)

INSERT INTO Producto_Categoria(Id_producto,Id_categoria)
	VALUES(1,1)
INSERT INTO Producto_Categoria(Id_producto,Id_categoria)
	VALUES(2,2)
INSERT INTO Producto_Categoria(Id_producto,Id_categoria)
	VALUES(3,3)
INSERT INTO Producto_Categoria(Id_producto,Id_categoria)
	VALUES(4,4)
INSERT INTO Producto_Categoria(Id_producto,Id_categoria)
	VALUES(5,5) 

INSERT INTO Ajuste_Precios(Id_producto,Fecha,Hora,Precio,Rut_empleado)
	VALUES(1,SYSDATETIME( ),SYSDATETIME( ),1990,20093264)
INSERT INTO Ajuste_Precios(Id_producto,Fecha,Hora,Precio,Rut_empleado)
	VALUES(2,SYSDATETIME( ),SYSDATETIME( ),11998,20093264)
INSERT INTO Ajuste_Precios(Id_producto,Fecha,Hora,Precio,Rut_empleado)
	VALUES(3,SYSDATETIME( ),SYSDATETIME( ),44190,20093264)
INSERT INTO Ajuste_Precios(Id_producto,Fecha,Hora,Precio,Rut_empleado)
	VALUES(4,SYSDATETIME( ),SYSDATETIME( ),98480,20093264)
INSERT INTO Ajuste_Precios(Id_producto,Fecha,Hora,Precio,Rut_empleado)
	VALUES(5,SYSDATETIME( ),SYSDATETIME( ),69000,20093264)

INSERT INTO Ajuste_Stock(Id_producto,Fecha,Hora,Cantidad,Razon,Stock,Rut_empleado)
	VALUES(1,SYSDATETIME( ),SYSDATETIME( ),10,1,10,20093264) 
INSERT INTO Ajuste_Stock(Id_producto,Fecha,Hora,Cantidad,Razon,Stock,Rut_empleado)
	VALUES(2,SYSDATETIME( ),SYSDATETIME( ),9,1,9,20093264) 
INSERT INTO Ajuste_Stock(Id_producto,Fecha,Hora,Cantidad,Razon,Stock,Rut_empleado)
	VALUES(3,SYSDATETIME( ),SYSDATETIME( ),12,1,12,20093264) 
INSERT INTO Ajuste_Stock(Id_producto,Fecha,Hora,Cantidad,Razon,Stock,Rut_empleado)
	VALUES(4,SYSDATETIME( ),SYSDATETIME( ),20,1,20,20093264) 
INSERT INTO Ajuste_Stock(Id_producto,Fecha,Hora,Cantidad,Razon,Stock,Rut_empleado)
	VALUES(5,SYSDATETIME( ),SYSDATETIME( ),8,1,8,20093264) 


INSERT INTO Descuentos(Id_producto,Fecha_inicio ,Fecha_termino ,Condicion)
	VALUES(1,SYSDATETIME( ),'10/06/2019','05X02')   
 INSERT INTO Descuentos(Id_producto,Fecha_inicio ,Fecha_termino ,Condicion)
	VALUES(2,SYSDATETIME( ),'10/06/2019','10E4A')   




	
-- UPDATE TABLE 
UPDATE Usuarios
SET Permisos = '3'
WHERE Rut_empleado = '20093264'

-- DELETE TABLE
DELETE FROM Usuarios WHERE Contraseña = '12345';



SELECT Id_producto,Nombre,Precio,Stock,Stock_critico FROM Productos where False_delete = 0 AND Id_producto = 1

UPDATE Productos
SET False_delete = 0
WHERE Id_producto = 1


SELECT * FROM Usuarios WHERE False_delete = 0  AND  Rut_empleado = 20093264 AND Contraseña = 'admin'

SELECT * FROM Productos
SELECT * FROM Ajuste_Stock
delete from Productos


select * from Usuarios  where rut_empleado = 20093264


SELECT Descuentos.Id_descuento, Productos.Nombre, Descuentos.Fecha_inicio , Descuentos.Fecha_termino , Descuentos.Condicion  , Descuentos.Id_descuento 
FROM Descuentos
INNER JOIN Productos ON Descuentos.Id_producto=Productos.Id_producto

select * from descuentos

DELETE FROM Descuentos  WHERE Id_descuento =  3