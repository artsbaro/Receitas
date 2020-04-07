CREATE PROCEDURE Sproc_Categoria_Delete
(
	@Id smallint
)
As
	DELETE 
	FROM	[dbo].[tblCategorias]
	WHERE	[Id] = @Id