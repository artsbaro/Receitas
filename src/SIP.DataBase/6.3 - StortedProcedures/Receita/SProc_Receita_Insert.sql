CREATE PROCEDURE SProc_Receita_Insert
(
    @Id uniqueidentifier ,
    @Titulo varchar(150) ,
    @Descricao varchar(256),
    @ModoPreparo varchar(MAX),
    @CategoriaId uniqueidentifier,
	@Ativo bit ,
	@DataCadastro datetime 
)
As

INSERT INTO [dbo].[tblReceitas]
           (    [Id],
                [Titulo],
                [Descricao] ,
                [ModoPreparo] ,
                [CategoriaId] ,
	            [Ativo],
	            [DataCadastro] )
     VALUES
           (    @Id ,
                @Titulo ,
                @Descricao ,
                @ModoPreparo ,
                @CategoriaId,
	            @Ativo ,
	            @DataCadastro )