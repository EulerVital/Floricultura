IF NOT EXISTS(select * from  sys.tables where name = 'TB_VENDAS_TOTAL')
BEGIN
	CREATE TABLE TB_VENDAS_TOTAL
	(
		 Id INT PRIMARY KEY IDENTITY(1,1)
		,Produtos XML 
		,PrecoTotal MONEY
		,QtdProdutos INT
	)
END
GO