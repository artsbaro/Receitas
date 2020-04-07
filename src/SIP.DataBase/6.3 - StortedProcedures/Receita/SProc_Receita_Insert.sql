CREATE PROCEDURE [dbo].SProc_Receita_Insert
(
    @Codigo uniqueidentifier,
    @Titulo varchar(150) ,
    @Descricao varchar(256),
    @ModoPreparo varchar(MAX),
    @CategoriaId smallint,
	@Ativo bit ,
	@DataCadastro datetime 
)
As

INSERT INTO [dbo].[tblReceitas]
           (    
                [Codigo],
                [Titulo],
                [Descricao] ,
                [ModoPreparo] ,
                [CategoriaId] ,
	            [Ativo],
	            [DataCadastro] )
     VALUES
           (    
                @Codigo,
                @Titulo ,
                @Descricao ,
                @ModoPreparo ,
                @CategoriaId,
	            @Ativo ,
	            @DataCadastro )