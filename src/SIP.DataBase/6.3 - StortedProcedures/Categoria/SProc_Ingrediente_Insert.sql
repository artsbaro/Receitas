CREATE PROCEDURE SProc_Categoria_Insert
(
	@Id					uniqueidentifier
	,@Nome              varchar(128)
    ,@Ativo				bit
    ,@DataCadastro		datetime
)
As

INSERT INTO [dbo].[tblCategorias]
           ([Id]
           ,[Nome]
           ,[Ativo]
           ,[DataCadastro])
     VALUES
           (@Id				
			,@Nome	
			,@Ativo			
			,@DataCadastro)

            