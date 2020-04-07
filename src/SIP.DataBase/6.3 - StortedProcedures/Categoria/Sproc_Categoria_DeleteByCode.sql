CREATE PROCEDURE Sproc_Categoria_DeleteByCode
(
	@Codigo uniqueidentifier
)
As
	DELETE 
	FROM	[dbo].[tblCategorias]
	WHERE	[Codigo] = @Codigo