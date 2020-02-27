CREATE PROCEDURE SProc_Receita_Delete
(
	@Id uniqueidentifier
)
AS

	Delete 
	from	tblReceitas
	Where	Id = @Id