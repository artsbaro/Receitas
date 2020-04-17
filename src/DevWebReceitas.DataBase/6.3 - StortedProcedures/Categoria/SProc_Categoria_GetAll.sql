CREATE PROCEDURE [dbo].SProc_Categoria_GetAll
As


	SELECT	[Id]
			,[Codigo]
			,[Titulo]
			,[Descricao]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblCategorias] (nolock)
	WHERE	[Excluido] = 0
	AND		[Ativo] = 1