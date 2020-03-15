CREATE PROCEDURE Sproc_Categoria_Delete
(
	@Id uniqueidentifier
)
As
	DELETE 
	FROM	[dbo].[tblCategorias]
	WHERE	[Id] = @Id