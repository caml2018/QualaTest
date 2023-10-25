use master;
CREATE DATABASE DbQualaTest
ON
(
	NAME = Quala_dat,
	FILENAME='C:\database\Quala.mdf',
	SIZE=1GB,
	MAXSIZE=UNLIMITED,
	FILEGROWTH=50MB
)
LOG ON
(
	NAME= Quala_log,
	FILENAME='C:\database\Quala.ldf',
	SIZE=512MB,
	MAXSIZE=1GB,
	FILEGROWTH=10%
)

SELECT name, database_id, create_date
FROM sys.databases

USE [DbQualaTest]
GO
CREATE USER qualatest FOR LOGIN qualatest


CREATE SCHEMA [sucursales] AUTHORIZATION [qualatest]
GO

GRANT SELECT, UPDATE, DELETE, INSERT, CREATE SCHEMA sucursales TO qualatest;
GO

USE [DbQualaTest]
GO


DROP TABLE [sucursales].[sucursal]
CREATE TABLE [sucursales].[sucursal](
	id int IDENTITY(1,1) NOT NULL,
	codigo int NOT NULL,
	descripcion varchar(250),
	direccion varchar(250),
	identificacion varchar(50),
	fechacreacion date,
	monedaId int
	PRIMARY KEY (id)
	CONSTRAINT FK_sucursal_moneda
	FOREIGN KEY (monedaId)
	REFERENCES [sucursales].[moneda](id)
)
DROP TABLE [sucursales].[moneda]
CREATE TABLE [sucursales].[moneda](
	id int IDENTITY(1,1) NOT NULL,
	codigo varchar(5),
	nombre varchar(50),
	estado int,
	PRIMARY KEY (id)
)


