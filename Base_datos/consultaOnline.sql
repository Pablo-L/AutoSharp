CREATE TABLE consultaOline
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [cif] VARCHAR(9) NOT NULL PRIMARY KEY, 
    [pregunta] VARCHAR(35) NULL, 
    [respuesta] VARCHAR(40) NULL, 
    [nif] VARCHAR(9) NOT NULL FOREIGN KEY (Particular),
)
