CREATE PROCEDURE SProc_Receita_Insert
(
    @Id int ,
    @Codigo uniqueidentifier,
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
                [Codigo],
                [Titulo],
                [Descricao] ,
                [ModoPreparo] ,
                [CategoriaId] ,
	            [Ativo],
	            [DataCadastro] )
     VALUES
           (    @Id ,
                @Codigo,
                @Titulo ,
                @Descricao ,
                @ModoPreparo ,
                @CategoriaId,
	            @Ativo ,
	            @DataCadastro )