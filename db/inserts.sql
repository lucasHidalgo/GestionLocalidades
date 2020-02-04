use GestionLocalidades;

-- Insert de paises
INSERT INTO Paises(Nombre)
VALUES ('Argentina');

-- Insert de provincias
insert into Provincias(Nombre, PaisId)
VALUES ('Buenos Aires', (SELECT Id FROM Paises WHERE Nombre = 'Argentina')),
		('Cordoba', (SELECT Id FROM Paises WHERE Nombre = 'Argentina'));
 
 