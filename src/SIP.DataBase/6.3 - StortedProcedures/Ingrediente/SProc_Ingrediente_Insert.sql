CREATE PROCEDURE SProc_Ingrediente_Insert
(
	@Id					uniqueidentifier
	,@Nome              varchar(128)
    ,@Ativo				bit
    ,@DataCadastro		datetime
)
As

INSERT INTO [dbo].[tblIngredientes]
           ([Id]
           ,[Nome]
           ,[Ativo]
           ,[DataCadastro])
     VALUES
           (@Id				
			,@Nome	
			,@Ativo			
			,@DataCadastro)

            