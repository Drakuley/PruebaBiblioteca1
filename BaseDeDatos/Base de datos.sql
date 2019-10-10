create table Autores(
    idAutor numeric(5) not null,
    nombre varchar(40) not null,
    constraint pk_autores primary key(idAutor)
);

create table Usuarios(
    idUsuario numeric(5) not null,
    nombre varchar(40) not null,
    direccion varchar(50) not null,
    telefono varchar(10) not null,
    genero varchar(1) not null,
    constraint pk_usuarios primary key (idUsuario),
    constraint ch_genero check (genero = 'F' or genero = 'M')
);

create table Bibliotecarios(
    idBibliotecario numeric(5) not null,
    nombre varchar(40) not null,
    turno varchar(1) not null,
    constraint pk_bibliotecarios primary key(idBibliotecario),
    constraint ch_turno check (turno = 'M' or turno = 'V')

);
