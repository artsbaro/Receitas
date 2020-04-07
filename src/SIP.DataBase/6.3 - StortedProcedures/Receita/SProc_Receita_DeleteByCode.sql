CREATE PROCEDURE [dbo].SProc_Receita_DeleteByCode
(
	@Codigo uniqueidentifier
)
AS

	Delete 
	from	tblReceitas
	Where	Codigo = @Codigo