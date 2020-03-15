CREATE TABLE [tblReceitas] (
    [Id] uniqueidentifier NOT NULL,
    [Titulo] varchar(150) NOT NULL DEFAULT '',
    [Descricao] varchar(256) NULL DEFAULT '',
    [ModoPreparo] varchar(MAX) NULL DEFAULT '',
    [CategoriaId] uniqueidentifier NULL,
	[Ativo] bit NOT NULL,
	[DataCadastro] datetime NOT NULL,
    [DataUltimaAlteracao] DATETIME NULL, 
    CONSTRAINT [PK_Receita] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_tblReceitas_tblCategorias] FOREIGN KEY ([CategoriaId]) REFERENCES [tblCategorias]([Id])
);
GO


CREATE INDEX [NC_tblReceitas_CategoriaId] ON [dbo].[tblReceitas] ([CategoriaId])
