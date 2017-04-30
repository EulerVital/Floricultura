CREATE FUNCTION dbo.fNSplit(
	 @valor VARCHAR(MAX) 
	,@delimitador VARCHAR(MAX) = ','
)RETURNS  @resultado TABLE (Item VARCHAR(8000))
BEGIN
	DECLARE @parte VARCHAR(800)

	WHILE CHARINDEX(@delimitador,@valor,0) <> 0
	BEGIN
		SELECT
			@parte=RTRIM(LTRIM(
				SUBSTRING(@valor,1,
					CHARINDEX(@delimitador,@valor,0)-1))),
		    @valor=RTRIM(LTRIM(SUBSTRING(@valor,
				CHARINDEX(@delimitador,@valor,0) +
				LEN(@delimitador), LEN(@valor))))
	IF LEN(@valor) > 0
		INSERT INTO @resultado SELECT @parte
	END

	IF LEN(@valor) > 0
		INSERT INTO @resultado SELECT @valor

RETURN
END
GO
