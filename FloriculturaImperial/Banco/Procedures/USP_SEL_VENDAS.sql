IF EXISTS (select * from  sys.procedures where name = 'USP_SEL_VENDAS')
BEGIN
	DROP PROC USP_SEL_VENDAS
END
GO

CREATE PROC USP_SEL_VENDAS
	 @Id INT = NULL
	,@Produto VARCHAR(200) = NULL
	,@Preco MONEY = NULL
	,@QtdVendidas INT = NULL
	,@QtdEstocada INT = NULL
AS
BEGIN
	SELECT
		 Id
		,Produto
		,Preco
		,QtdVendidas
		,QtdEstocada
	INTO #TEMP1
	FROM
		TB_VENDAS		
	WHERE
		Id = COALESCE(@Id,Id)
	AND
		Produto = COALESCE(@Produto,Produto)
	AND
		QtdVendidas = COALESCE(@QtdVendidas,QtdVendidas)
	AND
		QtdEstocada = COALESCE(@QtdEstocada,QtdEstocada)
	
	SELECT DISTINCT
		 Produto
		,SUM(Preco) Preco
		,SUM(QtdVendidas) QtdVendidas
		,MIN(QtdEstocada) QtdEstocada
	INTO #TEMP2
	FROM
		#TEMP1	
	WHERE
		Id = COALESCE(@Id,Id)
	AND
		Produto = COALESCE(@Produto,Produto)
	AND
		QtdVendidas = COALESCE(@QtdVendidas,QtdVendidas)
	AND
		QtdEstocada = COALESCE(@QtdEstocada,QtdEstocada)
	GROUP BY
		 Produto

	SELECT
		 ROW_NUMBER() OVER(ORDER BY Produto  ASC) AS Codigo
		,Produto
		,Preco
		,QtdVendidas
		,CONVERT(decimal(10,1),(convert(float,QtdVendidas) * 100) / (select sum(QtdVendidas) from #TEMP2) ) PorcentVendas
		,QtdEstocada
		,CONVERT(decimal(10,1),(convert(float,QtdEstocada) * 100) / (select sum(QtdEstocada) from #TEMP2)) PorcentEstocada
	FROM
		#TEMP2
END
GO