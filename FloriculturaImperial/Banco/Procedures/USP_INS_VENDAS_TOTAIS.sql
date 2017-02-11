IF EXISTS(select * from sys.procedures where name = 'USP_INS_VENDAS_TOTAIS')
BEGIN
	DROP PROC USP_INS_VENDAS_TOTAIS
END
GO

CREATE PROC USP_INS_VENDAS_TOTAIS
	 @Id INT = NULL
	,@Produto XML = NULL
	,@PrecoTotal MONEY = NULL
	,@QtdProdutos INT = NULL
AS
BEGIN
	IF @Id IS NULL
	BEGIN
		INSERT INTO TB_VENDAS_TOTAL
		(
			 Produtos
			,PrecoTotal
			,QtdProdutos
		)SELECT
			 @Produto
			,@PrecoTotal
			,@QtdProdutos
	END
	ELSE
	BEGIN
		UPDATE TB_VENDAS_TOTAL SET
			 Produtos = @Produto
			,PrecoTotal = @PrecoTotal
			,QtdProdutos = @QtdProdutos
		WHERE
			Id = @Id
	END
END

