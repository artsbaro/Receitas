CREATE PROCEDURE SProc_Ingrediente_GetById
(
	@Id uniqueidentifier
)
As

	SELECT	[Id]
			,[Nome]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblIngredientes] (nolock)
	WHERE	[Id] = @Id