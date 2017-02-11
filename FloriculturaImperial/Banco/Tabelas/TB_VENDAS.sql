IF NOT EXISTS(select * from  sys.tables where name = 'TB_VENDAS')
BEGIN
	CREATE TABLE TB_VENDAS
	(
		 Id INT PRIMARY KEY IDENTITY(1,1)
		,Produto VARCHAR(200) 
		,Preco MONEY
		,QtdVendidas INT
		,QtdEstocada INT
		,Data Date
	)
END
GO