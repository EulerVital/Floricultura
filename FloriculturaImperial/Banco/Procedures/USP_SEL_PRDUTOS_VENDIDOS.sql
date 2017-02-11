IF EXISTS (select * from  sys.procedures where name = 'USP_SEL_PRDUTOS_VENDIDOS')
BEGIN
	DROP PROC USP_SEL_PRDUTOS_VENDIDOS
END
GO

CREATE PROC USP_SEL_PRDUTOS_VENDIDOS
	 @Id INT = NULL
	,@Produto VARCHAR(200) = NULL
AS
BEGIN
	SELECT DISTINCT
		 Id Codigo
		,Produto
		,Preco
		,QtdVendidas
		,QtdEstocada
		,Data
	FROM 
		TB_VENDAS
	WHERE 
		Id = COALESCE(@Id,Id)
	AND
		Produto = COALESCE(@Produto,Produto)
END
GO