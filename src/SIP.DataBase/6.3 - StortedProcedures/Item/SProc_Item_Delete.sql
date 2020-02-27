CREATE PROCEDURE SProc_Item_Delete
(
    @Id uniqueidentifier
)
As


DELETE FROM tblItens   
WHERE Id = @Id