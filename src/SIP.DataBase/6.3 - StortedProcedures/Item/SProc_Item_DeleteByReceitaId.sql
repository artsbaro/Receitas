CREATE PROCEDURE [dbo].[SProc_Item_DeleteByReceitaId]  
(  
	@ReceitaId uniqueidentifier  
)  
As  
  
 DELETE FROM	dbo.tblItens 
 WHERE	[ReceitaId] = @ReceitaId  