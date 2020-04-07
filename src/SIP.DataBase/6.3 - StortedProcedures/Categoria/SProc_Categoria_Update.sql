CREATE PROCEDURE [dbo].SProc_Categoria_Update
(
   @Id smallint ,
	@Nome varchar(128),
	@Codigo uniqueidentifier ,
	@Ativo bit ,
	@DataUltimaAlteracao datetime
)
As

UPDATE tblCategorias SET
   	Nome = @Nome,
	Codigo = @Codigo,
	Ativo = @Ativo,
	DataUltimaAlteracao = @DataUltimaAlteracao
 WHERE [Id] = @Id