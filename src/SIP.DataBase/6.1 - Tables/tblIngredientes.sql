CREATE TABLE [tblIngredientes] (
    [Id] uniqueidentifier NOT NULL,
	[Nome] varchar(128),
	[Ativo] bit NOT NULL,
	[DataCadastro] datetime NOT NULL,
	[DataUltimaAlteracao] datetime NULL, 
    CONSTRAINT [PK_Ingrediente] PRIMARY KEY ([Id]),
);