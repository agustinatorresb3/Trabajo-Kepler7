IF DB_ID('Kepler7') IS NULL
    CREATE DATABASE Kepler7;
GO

USE Kepler7;
GO

-- Progreso de la partida (una sola fila, Id = 1)
IF OBJECT_ID('Progreso') IS NULL
    CREATE TABLE Progreso (
        Id            INT PRIMARY KEY,
        XP            INT           NOT NULL,
        TutorialVisto BIT           NOT NULL,
        Derrota       BIT           NOT NULL,
        MotivoDerrota NVARCHAR(200) NULL,
        Inicio        DATETIME      NOT NULL
    );
GO

-- Logros: patrones dominados
IF OBJECT_ID('PatronesDominados') IS NULL
    CREATE TABLE PatronesDominados (
        Patron NVARCHAR(50) PRIMARY KEY
    );
GO

-- Intentos denegados de la bóveda (Proxy)
IF OBJECT_ID('AccesosDenegados') IS NULL
    CREATE TABLE AccesosDenegados (
        Id      INT IDENTITY(1,1) PRIMARY KEY,
        Fecha   DATETIME     NOT NULL,
        Rol     NVARCHAR(30) NOT NULL,
        Accion  NVARCHAR(20) NOT NULL,
        Archivo NVARCHAR(20) NOT NULL
    );
GO
