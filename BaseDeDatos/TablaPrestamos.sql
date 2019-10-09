
create table Devoluciones(
    idDevolucion numeric(5) not null,
    idPrestamo numeric(5) not null,
    numeroAdquisicion varchar(40) not null,
    fechaDevuelo date not null,
    idBibliotecario numeric(5) not null,
    observaciones varchar(200),
    constraint pk_Devoluciones primary key(idDevolucion, idPrestamo),
    constraint fk_Dev foreign key(idPrestamo) references Prestamos(idPrestamo)
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
    constraint fk_Usuarios foreign key(idBibliotecario) references Bibliotecarios(idBibliotecario),
);
