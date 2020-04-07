CREATE PROCEDURE SProc_Categoria_Update
(
   @Id uniqueidentifier ,
	@Nome varchar(128),
	@Codigo smallint,
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