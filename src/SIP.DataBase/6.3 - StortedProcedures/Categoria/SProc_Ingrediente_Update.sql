CREATE PROCEDURE SProc_Categoria_Update
(
   @Id uniqueidentifier ,
	@Nome varchar(128),
	@Ativo bit ,
	@DataUltimaAlteracao datetime
)
As

UPDATE tblCategorias SET
   	Nome = @Nome,
	Ativo = @Ativo,
	DataUltimaAlteracao = @DataUltimaAlteracao
 WHERE [Id] = @Id