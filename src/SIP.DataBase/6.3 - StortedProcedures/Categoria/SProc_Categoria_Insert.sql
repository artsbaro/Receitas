CREATE PROCEDURE SProc_Categoria_Insert
(
	@Id					uniqueidentifier
	,@Nome              varchar(128)
    ,@Codigo            smallint
    ,@Ativo				bit
    ,@DataCadastro		datetime
)
As

INSERT INTO [dbo].[tblCategorias]
           ([Id]
           ,[Nome]
           ,[Codigo]
           ,[Ativo]
           ,[DataCadastro])
     VALUES
           (@Id				
			,@Nome	
            ,@Codigo
			,@Ativo			
			,@DataCadastro)

            