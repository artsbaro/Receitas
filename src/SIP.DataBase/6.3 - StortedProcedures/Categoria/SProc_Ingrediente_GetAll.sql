CREATE PROCEDURE SProc_Categoria_GetAll
As


	SELECT	[Id]
			,[Nome]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblCategorias] (nolock)