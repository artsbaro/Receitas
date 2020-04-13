CREATE PROCEDURE [dbo].SProc_Categoria_Insert
(
    @Codigo            uniqueidentifier 
	,@Nome              varchar(128)
    ,@Ativo				bit
    ,@DataCadastro		datetime
)
As

INSERT INTO [dbo].[tblCategorias]
           (
           [Codigo]
           ,[Nome]           
           ,[Ativo]
           ,[DataCadastro])
     VALUES
           (
           @Codigo
           ,@Nome	            
			,@Ativo			
			,@DataCadastro)

            