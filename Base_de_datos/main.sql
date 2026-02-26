CREATE DATABASE Practica_Extra
USE Practica_Extra;

CREATE TABLE Habitaciones (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    CodigoDeHabitacion VARCHAR(7) NOT NULL UNIQUE,
    NombreDeHabitacion VARCHAR(30) NOT NULL,
    CantidadDeHuespedesPermitidos INT NOT NULL,
    CantidadDeCamas INT NOT NULL,
    CantidadDeBanos INT NOT NULL,
    Ubicacion VARCHAR(10) NOT NULL,
    EncargadoDeLimpieza VARCHAR(100) NOT NULL,
    TipoDeHabitacion VARCHAR(20) NOT NULL, -- Junior, Superior, Suite
    CostoDeLimpieza DECIMAL(10,2) NOT NULL,
    CostoDeReserva DECIMAL(10,2) NOT NULL,
    FechaDeRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    FechaDeModificacion DATETIME NULL,
    Estado BIT NOT NULL DEFAULT 1
);

INSERT INTO Habitaciones (
    CodigoDeHabitacion,
    NombreDeHabitacion,
    CantidadDeHuespedesPermitidos,
    CantidadDeCamas,
    CantidadDeBanos,
    Ubicacion,
    EncargadoDeLimpieza,
    TipoDeHabitacion,
    CostoDeLimpieza,
    CostoDeReserva,
    FechaDeModificacion
)
VALUES 
('HAB002', 'Junior Vista Jardín', 2, 1, 1, 'Piso 2', 'María López', 'Junior', 15.00, 80.00, NULL),
('HAB003', 'Superior Ejecutiva', 3, 2, 1, 'Piso 3', 'Luis Gómez', 'Superior', 20.00, 120.00, NULL),
('HAB004', 'Suite Presidencial', 5, 3, 3, 'Piso 4', 'Ana Martínez', 'Suite', 40.00, 300.00, NULL);