CREATE TABLE [tblReceitas] (
    [Id] uniqueidentifier NOT NULL,
    [Titulo] varchar(150) NOT NULL DEFAULT '',
    [Descricao] varchar(256) NULL DEFAULT '',
    [ModoPreparo] varchar(MAX) NULL DEFAULT '',
	[Ativo] bit NOT NULL,
	[DataCadastro] datetime NOT NULL,
    [DataUltimaAlteracao] DATETIME NULL, 
    CONSTRAINT [PK_Receita] PRIMARY KEY ([Id])
);