CREATE TABLE comentario
(
	[id] INT NOT NULL PRIMARY KEY, 
    [cif] VARCHAR(9) NOT NULL PRIMARY KEY, 
    [descripcion] VARCHAR(35) NULL, 
    [valoracion] INT NULL, 
    [nif] VARCHAR(9) NOT NULL FOREIGN KEY (Particular),
)
