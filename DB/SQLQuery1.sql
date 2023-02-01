CREATE DATABASE LOGEOSs
USE LOGEOSs


--TABLAS DE ADMINISTRADOR--

CREATE TABLE tipos_usuarios(
Id_tipo INT NOT NULL PRIMARY KEY,
Nombre VARCHAR (50) NOT NULL
);


create table usuarios(
Id_usuarios INT NOT NULL PRIMARY KEY,
Nombre_usuario VARCHAR (25),
Contrase�a VARCHAR (50)NOT NULL,
Id_tipo INT NOT NULL REFERENCES tipos_usuarios
);


INSERT INTO tipos_usuarios VALUES(1,'USUARIO')
INSERT INTO tipos_usuarios VALUES(2,'ADMIN')
INSERT INTO tipos_usuarios VALUES(3,'SECRETARIA')

INSERT INTO usuarios VALUES (1,'Juan','123',1)
INSERT INTO usuarios VALUES (2,'Erick','1234',2)
INSERT INTO usuarios VALUES (3,'Matias','12345',3)
DROP TABLE usuarios
DROP TABLE tipos_usuarios
SELECT * FROM usuarios
SELECT * FROM tipos_usuarios


--TABLAS SECUNDARIAS--
CREATE TABLE NUEVOS_EMPLEADOS(
Id_empleado INT NOT NULL PRIMARY KEY,
Nombre VARCHAR (25),
Apelllido VARCHAR (25),
Tipo_empleo VARCHAR(35),
Codigo INT NOT NULL
);
Select * from NUEVOS_EMPLEADOS
DROP TABLE NUEVOS_EMPLEADOS

drop table CUENTAS_ACTIVADAS
CREATE TABLE CUENTAS_ACTIVADAS(
Id_usuarios INT NOT NULL PRIMARY KEY,
Nombre_usuario VARCHAR (25),
Contrase�a VARCHAR (50)NOT NULL,
Id_tipo INT
);


DROP TABLE CUENTAS_ACTIVADAS
select * from CUENTAS_ACTIVADAS

CREATE TABLE ID_EN_USO(
Id INT NOT NULL PRIMARY KEY);


Select * from ID_EN_USO
Drop table ID_EN_USO
INSERT INTO ID_EN_USO VALUES (1)
INSERT INTO ID_EN_USO VALUES (2)
INSERT INTO ID_EN_USO VALUES (3)