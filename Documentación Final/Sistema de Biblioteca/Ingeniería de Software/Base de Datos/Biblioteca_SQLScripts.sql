CREATE TABLE Ubicaciones (
  ubicacion VARCHAR(10)NOT NULL,
  descripcion VARCHAR(30) NOT NULL,
  CONSTRAINT PK_Ubicacion PRIMARY KEY(ubicacion)
);

INSERT INTO Ubicaciones VALUES('1','Pasillo 1');
INSERT INTO Ubicaciones VALUES('2','Pasillo 2');
INSERT INTO Ubicaciones VALUES('3','Pasillo 3');
INSERT INTO Ubicaciones VALUES('4','Pasillo 4');

CREATE TABLE Clasificaciones (
  clasificacion DECIMAL(5,1)NOT NULL,
  genero VARCHAR(30) NOT NULL,
  CONSTRAINT PK_Clasificacion PRIMARY KEY(clasificacion)
);


INSERT INTO Clasificaciones VALUES(1.1,'Historia de Mexico');
INSERT INTO Clasificaciones VALUES(1.2,'Historia de America');
INSERT INTO Clasificaciones VALUES(2.0,'Terror');
INSERT INTO Clasificaciones VALUES(3.0,'Cuentos Infantiles');
INSERT INTO Clasificaciones VALUES(4.0,'Novelas Juveniles');
INSERT INTO Clasificaciones VALUES(5.0,'Fantasia');

CREATE TABLE Autores (
  idAutor NUMERIC NOT NULL,
  nombreAutor VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Autor PRIMARY KEY(idAutor)
);

INSERT INTO Autores VALUES(1,'Maximiliano Dominguez');
INSERT INTO Autores VALUES(2,'Raimbow Rowell');
INSERT INTO Autores VALUES(3,'J.K Roling');
INSERT INTO Autores VALUES(4,'Stephen King');
INSERT INTO Autores VALUES(5,'Mario Hernandez');


CREATE TABLE Libros (
  numeroAdquisicion VARCHAR(8) NOT NULL,
  titulo VARCHAR(50) NOT NULL,
  idAutor NUMERIC NOT NULL,
  ubicacion VARCHAR(10) NOT NULL,
  ejemplar VARCHAR(5) NOT NULL,
  clasificacion DECIMAL(5,1) NOT NULL,
  estatus VARCHAR(20) NOT NULL,
  Estatus2 VARCHAR(10) NULL,
  CONSTRAINT PK_Libros PRIMARY KEY(numeroAdquisicion),
  CONSTRAINT FK_LibrosAutor FOREIGN KEY(idAutor) REFERENCES Autores(idAutor),
  CONSTRAINT FK_LibrosUbicacion FOREIGN KEY(ubicacion)REFERENCES Ubicaciones(ubicacion),
  CONSTRAINT FK_LibrosClasificacion FOREIGN KEY (clasificacion)REFERENCES Clasificaciones(clasificacion)
);

INSERT INTO Libros VALUES('123E1','La Historia de la Bandera de Mexico',5,'1','EJ1',1.1,'Disponible','Alta');
INSERT INTO Libros VALUES('123E2','La Historia de la Bandera de Mexico',5,'1','EJ2',1.1,'Disponible','Alta');
INSERT INTO Libros VALUES('123E3','La Historia de la Bandera de Mexico',5,'1','EJ3',1.1,'Disponible','Alta');
INSERT INTO Libros VALUES('456E1','Los Ojos de la Princesa Magica',1,'2','EJ1',3.0,'Disponible','Alta');
INSERT INTO Libros VALUES('456E2','Los Ojos de la Princesa Magica',1,'2','EJ2',3.0,'Disponible','Alta');
INSERT INTO Libros VALUES('678E1','Harry Poter y la Piedra Filosofal',3,'3','EJ1',5.0,'Disponible','Alta');
INSERT INTO Libros VALUES('910E1','Attachments',2,'4','EJ1',5.0,'Disponible','Alta');
INSERT INTO Libros VALUES('910E2','Attachments',2,'4','EJ2',5.0,'Disponible','Alta');
INSERT INTO Libros VALUES('100E1','Cementerio de Mascotas',4,'3','EJ1',2.0,'Disponible','Alta');


CREATE TABLE Usuarios (
  idUsuario NUMERIC NOT NULL,
  nombreUsuario VARCHAR(50) NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  telefono VARCHAR(15) NOT NULL,
  genero VARCHAR(10)NOT NULL,
  estatus Varchar(5) null,
  CONSTRAINT PK_Usuarios PRIMARY KEY(idUsuario)
);

INSERT INTO Usuarios VALUES(1,'Ana Karen Melendez',
'Calle Rosas #235 Col.Jardines','8441234567','Femenino','Alta');
INSERT INTO Usuarios VALUES(2,'Alan Maximiliano Dominguez',
'Calle Verde #850 Col.Colores','8442234567','Masculino','Alta');
INSERT INTO Usuarios VALUES(2,'Alan Vazquez',
'Calle Leopardo #842 Col.Felinos','8669334567','Masculino','Alta');

CREATE TABLE Bibliotecarios (
  idBibliotecario NUMERIC NOT NULL,
  nombreBibliotecario VARCHAR(50) NOT NULL,
  contraseña VARCHAR(15) NOT NULL,
  turno VARCHAR(15) NOT NULL
  estatus VARCHAR(5) NULL,
  CONSTRAINT PK_Bibliotecarios PRIMARY KEY(idBibliotecario)
);
INSERT INTO Bibliotecarios VALUES(0001,'Martin Guerrero','martin123','Matutino','Alta');
INSERT INTO Bibliotecarios VALUES(0002,'Sofia Belmares','sofia123','Matutino','Alta');
INSERT INTO Bibliotecarios VALUES(0002,'Miguel Martinez','miguel123','Vespertino','Alta');

CREATE TABLE Prestamos (
  idPrestamo NUMERIC NOT NULL,
  fechaPrestamo DATE NOT NULL,
  numeroAdquisicion NUMERIC NOT NULL,
  idUsuario NUMERIC NOT NULL,
  idBibliotecario NUMERIC NOT NULL,
  fechaDevolucion DATE NOT NULL,
  CONSTRAINT PK_Prestamo PRIMARY KEY(idPrestamo),
  CONSTRAINT FK_PrestamoLibro FOREIGN KEY (numeroAdquisicion)REFERENCES Libros(numeroAdquisicion),
  CONSTRAINT FK_PrestamoUsuario FOREIGN KEY (idUsuario)REFERENCES Usuarios(idUsuario),
  CONSTRAINT FK_PrestamoBibliotecario FOREIGN KEY(idBibliotecario)REFERENCES Bibliotecarios(idBibliotecario)

);

INSERT INTO Prestamos VALUES(100,'2019-01-01','100E1',2,0001,'2019-01-04');
INSERT INTO Prestamos VALUES(101,'2019-03-19','123E2',2,0002,'2019-03-24');


CREATE TABLE Devoluciones (
 idDevolucion NUMERIC NOT NULL,
 idPrestamo NUMERIC NOT NULL,
 numeroAdquisicion VARCHAR(8) NOT NULL,
 idBibliotecario NUMERIC NOT NULL,
 fechaDevuelto DATE NOT NULL,
 observaciones VARCHAR(100) NOT NULL,
 CONSTRAINT PK_DevPrestamo PRIMARY KEY (idDevolucion, idPrestamo),
 CONSTRAINT FK_DevPrestamo FOREIGN KEY(idPrestamo) REFERENCES Prestamos(idPrestamo)
 );



