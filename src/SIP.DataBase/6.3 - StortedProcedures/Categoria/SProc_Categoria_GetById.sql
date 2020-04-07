CREATE PROCEDURE SProc_Categoria_GetById
(
	@Id smallint
)
As

	SELECT	[Id]
			,[Nome]
			,[Codigo]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblCategorias] (nolock)
	WHERE	[Id] = @Id