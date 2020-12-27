CREATE TABLE [dbo].[Patient]
(
	[cin_p] INT NOT NULL PRIMARY KEY, 
    [nom_p] VARCHAR(50) NOT NULL, 
    [prenom_p] VARCHAR(50) NOT NULL, 
    [sexe_p] CHAR(1) NOT NULL, 
    [age_p] INT NOT NULL, 
    [poids] FLOAT NOT NULL, 
    [adress_p] VARCHAR(255) NOT NULL, 
    [tel_p] INT NOT NULL
)
