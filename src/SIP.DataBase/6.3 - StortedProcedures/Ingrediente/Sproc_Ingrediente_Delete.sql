CREATE PROCEDURE Sproc_Ingrediente_Delete
(
	@Id uniqueidentifier
)
As
	DELETE 
	FROM	[dbo].[tblIngredientes]
	WHERE	[Id] = @Id