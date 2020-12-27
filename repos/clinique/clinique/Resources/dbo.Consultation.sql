CREATE TABLE [dbo].[Consultation]
(
	[num_cons] INT NOT NULL PRIMARY KEY, 
    [date_cons] DATE NULL, 
    [specialite] VARCHAR(255) NULL, 
    [nom_doc] VARCHAR(50) NULL, 
    [rapport] VARCHAR(255) NULL, 
    [traitement] VARCHAR(255) NULL, 
    [etat_cons] CHAR(1) NULL
)
