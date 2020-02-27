CREATE PROCEDURE SProc_Ingrediente_GetAll
As


	SELECT	[Id]
			,[Nome]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblIngredientes] (nolock)