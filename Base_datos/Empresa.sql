CREATE TABLE Empresa
(
	[cif] VARCHAR(9) NOT NULL PRIMARY KEY, 
    [nombre] VARCHAR(15) NULL, 
    [email] VARCHAR(35) NULL, 
    [telefono] INT NULL, 
    [direccion] VARCHAR(15) NULL, 
    [tamanyo] NCHAR(10) NULL, 
    [contrasenya] VARCHAR(20) NOT NULL
)
