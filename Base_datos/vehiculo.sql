CREATE TABLE vehiculo
(
	[matricula] VARCHAR(7) NOT NULL PRIMARY KEY, 
    [modelo] VARCHAR(10) NULL, 
    [marca] VARCHAR(10) NULL, 
    [color] VARCHAR(15) NULL, 
    [anyo] INT NULL, 
    [combustible] NCHAR(10) NULL, 
    [potencia] INT NULL, 
    [km] INT NULL, 
    [precio] INT NULL, 
    [cif] VARCHAR(9) NULL FOREIGN KEY (Empresa),
    [nif] VARCHAR(9) NULL FOREIGN KEY (Particular),
)
