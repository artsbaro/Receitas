CREATE PROCEDURE SProc_Receita_Insert
(
    @Id uniqueidentifier ,
    @Titulo varchar(150) ,
    @Descricao varchar(256),
    @ModoPreparo varchar(MAX),
	@Ativo bit ,
	@DataCadastro datetime 
)
As

INSERT INTO [dbo].[tblReceitas]
           (    [Id],
                [Titulo],
                [Descricao] ,
                [ModoPreparo] ,
	            [Ativo],
	            [DataCadastro] )
     VALUES
           (    @Id ,
                @Titulo ,
                @Descricao ,
                @ModoPreparo ,
	            @Ativo ,
	            @DataCadastro )