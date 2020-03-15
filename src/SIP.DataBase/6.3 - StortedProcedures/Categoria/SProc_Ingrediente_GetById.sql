CREATE PROCEDURE SProc_Categoria_GetById
(
	@Id uniqueidentifier
)
As

	SELECT	[Id]
			,[Nome]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblCategorias] (nolock)
	WHERE	[Id] = @Id