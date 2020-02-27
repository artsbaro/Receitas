CREATE PROCEDURE SProc_Item_Update
(
    @Id                   uniqueidentifier, 
	@Quantidade            decimal(5,2) ,
	@IngredienteId         uniqueidentifier  ,
	@ReceitaId             uniqueidentifier  ,
	@Obs                   varchar(256),
	@Ativo                 bit ,
	@DataUltimaAlteracao   datetime 
)
As


UPDATE tblItens   SET 
   [Id]						= @Id                 
	,[Quantidade]         	= @Quantidade         
	,[IngredienteId]      	= @IngredienteId      
	,[ReceitaId]          	= @ReceitaId          
	,[Obs]                	= @Obs                
	,[Ativo]              	= @Ativo              
	,[DataUltimaAlteracao]  = @DataUltimaAlteracao
 WHERE Id = @Id