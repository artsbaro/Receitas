CREATE PROCEDURE SProc_Ingrediente_Update
(
   @Id uniqueidentifier ,
	@Nome varchar(128),
	@Ativo bit ,
	@DataUltimaAlteracao datetime
)
As

UPDATE tblIngredientes SET
   	Nome = @Nome,
	Ativo = @Ativo,
	DataUltimaAlteracao = @DataUltimaAlteracao
 WHERE [Id] = @Id