	IF EXISTS(select * from sys.procedures where name = 'USP_SEL_PLANTAS')
	BEGIN
		DROP PROC USP_SEL_PLANTAS
	END
	GO

	CREATE PROCEDURE USP_SEL_PLANTAS
		 @Nome VARCHAR(200) = NULL
		,@Id INT = NULL
	AS
	BEGIN
		SELECT
			 Id
			,Nome
			,CONVERT(DECIMAL(10,2),Preco) Preco
			,Qtd
			,case when Especial = 0 then  'Não' else 'Sim' end EspecialNome
			,Especial
			,Status
		FROM
			TB_PLANTAS
		WHERE
			Nome = COALESCE(@Nome,Nome)
		AND
			Id = COALESCE(@Id,Id)
		AND
			Status = 1
	END
