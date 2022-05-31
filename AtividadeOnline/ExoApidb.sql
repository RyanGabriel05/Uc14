CREATE DATABASE ExoApidb
GO

USE ExoApidb
GO

CREATE TABLE Projetos
(
	Id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(100) NOT NULL,
	Andamento VARCHAR(50) NOT NULL,
	DataInicio DATE NOT NULL,
	Tecnologias VARCHAR(150) NOT NULL,
	Requisitos VARCHAR(50),
	Area VARCHAR(50)
);
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL,
	Tipo CHAR(1) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@email.com', '1234', '0')
GO

INSERT INTO Projetos
(Titulo, Andamento, DataInicio, Tecnologias, Requisitos, Area)
VALUES
('Livraria-API', 'Concluído', '2022-04-21', 'C#', '.Net', 'TI'),
('ExoApi-Projetos', 'Em Andamento', '2022-05-10', 'C#', '.Net', 'TI'),
('Chapter', 'Concluído', '2022-04-21', 'C#', '.Net', 'TI')

SELECT * FROM Usuarios


