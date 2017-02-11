IF EXISTS(select * from sys.procedures where name = 'USP_INS_VENDAS_PRODUTOS')
BEGIN
	DROP PROC USP_INS_VENDAS_PRODUTOS
END
GO

CREATE PROC USP_INS_VENDAS_PRODUTOS
	 @Id INT = NULL
	,@Produto VARCHAR(200) = NULL
	,@Preco MONEY = NULL
	,@QtdVendidas INT = NULL
	,@QtdEstocadas INT = NULL
AS
BEGIN
	IF @Id IS NULL
	BEGIN
		INSERT INTO TB_VENDAS
		(
			 Produto
			,Preco
			,QtdVendidas
			,QtdEstocada
			,Data
		)SELECT
			 @Produto
			,@Preco
			,@QtdVendidas
			,@QtdEstocadas
			,GETDATE()
	END
	ELSE
	BEGIN
		UPDATE TB_VENDAS SET
			 Produto = @Produto
			,Preco = @Preco
			,QtdVendidas = @QtdVendidas
			,QtdEstocada = @QtdEstocadas
		WHERE
			Id = @Id
	END
END
GO