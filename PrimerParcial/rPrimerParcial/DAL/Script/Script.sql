CREATE DATABASE Parcial1Db
GO
USE Parcial1
GO
CREATE TABLE Grupo
(
	GrupoId int primary key identity(1,1),
	Fecha DateTime,
	Descripcion varchar(40),
	Cantidad int(5),
	Grupo int(5),
	Integrantes int(5),
);