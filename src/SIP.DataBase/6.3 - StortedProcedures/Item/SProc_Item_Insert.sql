CREATE PROCEDURE SProc_Item_Insert
(
    @Id uniqueidentifier,
	@Quantidade decimal(5,2),
	@IngredienteId uniqueidentifier ,
	@ReceitaId uniqueidentifier,
	@Obs varchar(256),
	@Ativo bit,
	@DataCadastro datetime 
)
As

INSERT INTO [dbo].[tblItens]
           (    [Id],
                [Quantidade],
                [IngredienteId],
                [ReceitaId] ,
				[Obs] ,
	            [Ativo],
	            [DataCadastro])
     VALUES
           (    @Id,
				@Quantidade,
				@IngredienteId ,
				@ReceitaId ,
				@Obs ,
				@Ativo ,
				@DataCadastro )