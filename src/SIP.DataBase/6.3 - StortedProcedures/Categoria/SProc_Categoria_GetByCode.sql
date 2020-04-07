CREATE PROCEDURE [dbo].SProc_Categoria_GetByCode
(
	@Codigo uniqueidentifier
)
As

	SELECT	[Id]
			,[Nome]
			,[Codigo]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblCategorias] (nolock)
	WHERE	[Codigo] = @Codigo