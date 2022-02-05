CREATE PROCEDURE [dbo].[Добавить_поступление]
	@nameUser nvarchar(60),
	@date datetime,
	@id_product int,
	@count int
AS
BEGIN
	SELECT @nameUser
	INSERT INTO Документ (Дата,	Id_товар, Количество) VALUES (@date, @id_product, @count);
	DECLARE @price real;
	SET @price = (SELECT Цена_закупки FROM Товар WHERE Id_товар = @id_product) * @count;
	INSERT INTO Поступление_товара(Id_документ,	Сумма, Кладовщик) VALUES ((SELECT Id_документ FROM Документ WHERE Дата = @date AND Id_товар = @id_product), @price, @nameUser);
END;

CREATE PROCEDURE [dbo].[Обновить_поступление]
	@id_document int,
	@nameUser nvarchar(60),
	@date datetime,
	@id_product int,
	@count int
AS
BEGIN
	UPDATE Документ SET Дата = @date, Id_товар = @id_product, Количество = @count WHERE Id_документ = @id_document;
	DECLARE @price real;
	SET @price = (SELECT Цена_закупки FROM Товар WHERE Id_товар = @id_product) * @count;
	UPDATE Поступление_товара SET Сумма = @price, Кладовщик = @nameUser WHERE Id_документ =  @id_document;
END;
