CREATE TRIGGER [Поступление]
	ON [dbo].[Документ]
	FOR INSERT
	AS
	BEGIN
		DECLARE @id int, @count int;
		SET @id = (SELECT Id_товар FROM inserted);
		SET @count = (SELECT Количество FROM inserted);
		IF EXISTS (SELECT * FROM Склад WHERE Id_товар = @id)
		BEGIN
			UPDATE Склад
			SET Количество = Количество + @count
			WHERE Id_товар = @id
		END
		ELSE
		BEGIN
			INSERT INTO Склад (Id_товар, Количество)
			VALUES (@id, @count)
		END
		SET NOCOUNT ON
	END

--CREATE TRIGGER [Удаление]
--	ON [dbo].[Документ]
--	AFTER DELETE
--	AS
--	BEGIN
--		DECLARE @count int, @id int;
--		SET @count = (SELECT Количество FROM inserted);
--		SET @id = (SELECT Id_товар FROM inserted);

--		UPDATE Склад SET Количество = Количество - @count WHERE Id_товар =  @id;
--		SET NOCOUNT ON
--	END

CREATE TRIGGER [Обновление]
	ON [dbo].[Документ]
	INSTEAD OF UPDATE
	AS
	BEGIN
		DECLARE @count1 int, @id1 int, @count2 int, @id2 int, @data2 datetime;
		SET @count2 = (SELECT Количество FROM inserted);
		SET @id2 = (SELECT Id_товар FROM inserted);
		SET @data2 = (SELECT Дата FROM inserted);

		SET @count1 = (SELECT Количество FROM Документ WHERE Id_документ = (SELECT Id_документ FROM inserted));
		SET @id1 = (SELECT Id_товар FROM Документ WHERE Id_документ = (SELECT Id_документ FROM inserted));


		UPDATE Склад SET Количество = Количество - @count1 WHERE Id_товар =  @id1;
		UPDATE Склад SET Количество = Количество + @count2 WHERE Id_товар =  @id2;

		UPDATE Документ SET  Дата = @data2, Id_товар = @id2, Количество = @count2 WHERE Id_документ = (SELECT Id_документ FROM inserted);
		SET NOCOUNT ON
	END