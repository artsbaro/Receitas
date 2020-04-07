CREATE PROCEDURE SProc_Categoria_GetAll
As


	SELECT	[Id]
			,[Codigo]
			,[Nome]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblCategorias] (nolock)