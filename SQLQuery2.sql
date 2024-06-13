CREATE TABLE [dbo].[Produto]
(--chave primaria auto encrement
[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[Nome] NVARCHAR(MAX),
[Marca] NVARCHAR(MAX),
[Quantidade] NVARCHAR(MAX)
);

INSERT INTO Produto (Nome, Marca, Quantidade) VALUES ('Blusinha', 'C&A', '2700');
INSERT INTO Produto (Nome, Marca, Quantidade) VALUES ('Baby Tee', 'Maggiela', '3333');
INSERT INTO Produto (Nome, Marca, Quantidade) VALUES ('Calça cargo', 'Joni e Joni', '989898');

SELECT * FROM Produto;

DROP TABLE Produto;