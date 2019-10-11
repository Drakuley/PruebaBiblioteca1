
create table Devoluciones(
    idDevolucion numeric(5) not null,
    idPrestamo numeric(5) not null,
    numeroAdquisicion varchar(40) not null,
    fechaDevuelo date not null,
    idBibliotecario numeric(5) not null,
    observaciones varchar(200),
    constraint pk_Devoluciones primary key(idDevolucion, idPrestamo),
    constraint fk_Prestamos foreign key(idPrestamo) references Prestamos(idPrestamo)
);

create table Prestamos(
    idPrestamo numeric(5) not null,
    fechaPrestamo date not null,
    numeroAdquisicion varchar(40) not null,
    idUsuario numeric(5),
    idBibliotecario numeric(5) not null,
    fechaDevolucion date not null,
    turno varchar(1) not null,
    constraint pk_Prestamos primary key(idPrestamo),
    constraint fk_Usuarios foreign key(idUsuario) references Usuarios(idUsuario),
    constraint fk_Libros foreign key(numeroAdquisicion) references Libros(numeroAdquisicion),
    constraint fk_Usuarios foreign key(idBibliotecario) references Bibliotecarios(idBibliotecario)
);

create table clasificaciones(
    clasificacion numeric(3,3) not null,
    genero varchar(50) not null,
    constraint pk_Clasificaciones primary key(clasificacion),
);

create table ubicaciones(
    ubicacion varchar(1) not null,
    genero varchar(50) not null,
    constraint pk_Clasificaciones primary key(clasificacion),
);
