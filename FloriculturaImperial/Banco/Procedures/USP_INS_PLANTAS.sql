IF EXISTS(select * from sys.procedures where name = 'USP_INS_PLANTAS')
BEGIN
	DROP PROC USP_INS_PLANTAS
END
GO

CREATE PROCEDURE USP_INS_PLANTAS 
	 @Id INT = NULL
	,@Nome VARCHAR(200) = NULL
	,@Preco MONEY = NULL
	,@Qtd INT = NULL
	,@Especial BIT = 0
	,@Status BIT = 1
	,@Id_Retorno INT OUTPUT
AS
BEGIN

	DECLARE @Existi INT = (select count(Id) from TB_PLANTAS where Id = @Id)

	IF @Id IS NULL AND @Existi = 0
	BEGIN
		INSERT INTO TB_PLANTAS
		(
			 Nome
			,Preco
			,Qtd
			,Especial
			,Status
		)
		SELECT
			 @Nome
			,@Preco
			,@Qtd
			,@Especial
			,@Status

		SELECT @Id_Retorno = SCOPE_IDENTITY()
		RETURN @Id_Retorno
	END
	ELSE
	BEGIN
		UPDATE TB_PLANTAS SET
			 Nome = @Nome
			,Preco = @Preco
			,Qtd = @Qtd
			,Especial = @Especial
			,Status = @Status
		WHERE
			Id = @Id
	END

END
GO
