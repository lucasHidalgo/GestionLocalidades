
CREATE DATABASE GestionLocalidades;
GO 
USE GestionLocalidades;

CREATE TABLE [__EFMigrationsHistory] (
    [MigrationId] nvarchar(150) NOT NULL,
    [ProductVersion] nvarchar(32) NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
);


GO

CREATE TABLE [Paises] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    CONSTRAINT [PK_Paises] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Provincias] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [PaisId] int NOT NULL,
    CONSTRAINT [PK_Provincias] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Provincias_Paises_PaisId] FOREIGN KEY ([PaisId]) REFERENCES [Paises] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Localidades] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [ProvinciaId] int NOT NULL,
    CONSTRAINT [PK_Localidades] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Localidades_Provincias_ProvinciaId] FOREIGN KEY ([ProvinciaId]) REFERENCES [Provincias] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Localidades_ProvinciaId] ON [Localidades] ([ProvinciaId]);

GO

CREATE INDEX [IX_Provincias_PaisId] ON [Provincias] ([PaisId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200203032639_InitialCreate', N'2.2.6-servicing-10079');

GO