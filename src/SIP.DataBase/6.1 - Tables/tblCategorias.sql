﻿CREATE TABLE [tblCategorias] (
    [Id] smallint NOT NULL,
	[Codigo] uniqueidentifier NOT NULL,
	[Nome] varchar(128),
	[Ativo] bit NOT NULL,
	[DataCadastro] datetime NOT NULL,
	[DataUltimaAlteracao] datetime NULL, 
    CONSTRAINT [PK_Categoria] PRIMARY KEY ([Id]),
);

GO

CREATE INDEX [NC_tblCategorias_Codigo] ON [dbo].[tblCategorias] ([Codigo])
