CREATE PROCEDURE SProc_Receita_Update
(
    @Id int,
    @Codigo uniqueidentifier,
    @Titulo varchar(150) ,
    @Descricao varchar(256),
    @ModoPreparo varchar(MAX),
    @CategoriaId uniqueidentifier,
	@Ativo bit ,
    @DataUltimaAlteracao DATETIME 
)
As


UPDATE tblReceitas   SET 
       [Codigo] =               @Codigo
      ,[Titulo]  =              @Titulo
      ,[Descricao] =            @Descricao
      ,[ModoPreparo] =          @ModoPreparo
      ,[CategoriaId] =          @CategoriaId
      ,[Ativo] =				@Ativo
      ,[DataUltimaAlteracao] =	@DataUltimaAlteracao
 WHERE Id = @Id
