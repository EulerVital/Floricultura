	IF EXISTS(select * from sys.procedures where name = 'USP_SEL_FOTO_PLANTA')
	BEGIN
		DROP PROC USP_SEL_FOTO_PLANTA
	END
	GO

	CREATE PROCEDURE USP_SEL_FOTO_PLANTA
		@IdPlanta INT = NULL
	AS
	BEGIN
		SELECT
			 Id
			,Caminho
			,Status
			,IdPlanta
		FROM
			TB_FOTOS_PLANTA
		WHERE
			IdPlanta = COALESCE(@IdPlanta,IdPlanta)
	END