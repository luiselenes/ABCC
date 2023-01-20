create database ABCC;

create table Departamentos(
    id primary key,
    descripcion varchar(50)
)
go

create table Clases(
    id primary key,
    descripcion varchar(50),
    idDepartamento int,
    FOREIGN KEY (idDepartamento) REFERENCES Departamento(id)
)
go
create table Familias(
    id primary key,
    idClase int;
    descripcion varchar(50),
    FOREIGN KEY (idClase) REFERENCES Clase(id)

)
go

create table Articulos(
    sku int primary key,
    articulo varchar(50),
    marca varchar(50);
    modelo varchar(50);
    idDepartamento int,
    idClase int,
    idFamilia int,
    fecha_alta datetime;
    stock float,
    cantidad float,
    descontinuado bit,
    fecha_baja datetime,
    
    FOREIGN KEY (idDepartamento) REFERENCES Departamento(id),
    FOREIGN KEY (idClase) REFERENCES Clase(id),
    FOREIGN KEY (idFamilia) REFERENCES Familia(id)
)
go

