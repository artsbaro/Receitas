CREATE PROCEDURE [dbo].SProc_Receita_Delete
(
	@Id int
)
AS

	Delete 
	from	tblReceitas
	Where	Id = @Id