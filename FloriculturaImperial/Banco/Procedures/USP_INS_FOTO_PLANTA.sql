	IF EXISTS(select * from sys.procedures where name = 'USP_INS_FOTO_PLANTA')
	BEGIN
		DROP PROC USP_INS_FOTO_PLANTA
	END
	GO

	CREATE PROC USP_INS_FOTO_PLANTA
		 @Id INT = NULL
		,@Caminho VARCHAR(2000) = NULL
		,@Status BIT = 1
		,@IdPlanta INT = NULL
	AS
	BEGIN
		IF @Id IS NULL
		BEGIN
			INSERT INTO TB_FOTOS_PLANTA
			(
				 Caminho
				,Status
				,IdPlanta
			)
			SELECT
				@Caminho
			   ,@Status
			   ,@IdPlanta
		END
		ELSE
		BEGIN
			UPDATE TB_FOTOS_PLANTA SET
				 Caminho = @Caminho
				,Status = @Status
			WHERE
				Id = @Id
			AND
				IdPlanta = @IdPlanta
		END
	END