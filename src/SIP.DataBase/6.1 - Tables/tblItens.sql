CREATE TABLE [tblItens] (
    [Id] uniqueidentifier NOT NULL,
	[Quantidade] decimal(5,2) NOT NULL,
	[IngredienteId] uniqueidentifier  NOT NULL,
	[ReceitaId] uniqueidentifier  NOT NULL,
	[Obs] varchar(256) NULL,
	[Ativo] bit NOT NULL,
	[DataCadastro] datetime NOT NULL,
	[DataUltimaAlteracao] datetime NULL, 
    CONSTRAINT [PK_Item] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Itens_Ingredientes] FOREIGN KEY ([IngredienteId]) REFERENCES [tblIngredientes]([Id]),
	CONSTRAINT [FK_Itens_Receitas] FOREIGN KEY ([ReceitaId]) REFERENCES [tblReceitas]([Id]),
);