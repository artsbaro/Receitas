CREATE PROCEDURE [dbo].[SProc_Receita_GetAll]
As

 SELECT 
    [Id] 
    ,[Titulo] 
    ,[Descricao] 
    ,[ModoPreparo] 
	,[Ativo] 
	,[DataCadastro] 
    ,[DataUltimaAlteracao] 
 FROM dbo.tblReceitas (nolock) 