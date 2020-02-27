CREATE PROCEDURE [dbo].[SProc_Item_GetByReceitaId]  
(  
	@ReceitaId uniqueidentifier  
)  
As  
  
 SELECT 
		I.[Id] ,
		I.[Quantidade] ,
		I.[IngredienteId] ,
		IG.Nome as [IngredienteNome] ,
		I.[ReceitaId] ,
		I.[Obs] ,
		I.[Ativo] ,
		I.[DataCadastro] ,
		I.[DataUltimaAlteracao] 
 FROM	dbo.tblItens I(nolock) 
 Join	dbo.tblIngredientes IG (Nolock) On IG.Id = I.IngredienteId
 Where	I.[ReceitaId] = @ReceitaId  