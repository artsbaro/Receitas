CREATE PROCEDURE [dbo].[SProc_Receita_GetById]  
(  
 @Id uniqueidentifier  
)  
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
 Where Id = @Id  
 