CREATE TRIGGER [�����������]
	ON [dbo].[��������]
	FOR INSERT
	AS
	BEGIN
		DECLARE @id int, @count int;
		SET @id = (SELECT Id_����� FROM inserted);
		SET @count = (SELECT ���������� FROM inserted);
		IF EXISTS (SELECT * FROM ����� WHERE Id_����� = @id)
		BEGIN
			UPDATE �����
			SET ���������� = ���������� + @count
			WHERE Id_����� = @id
		END
		ELSE
		BEGIN
			INSERT INTO ����� (Id_�����, ����������)
			VALUES (@id, @count)
		END
		SET NOCOUNT ON
	END

--CREATE TRIGGER [��������]
--	ON [dbo].[��������]
--	AFTER DELETE
--	AS
--	BEGIN
--		DECLARE @count int, @id int;
--		SET @count = (SELECT ���������� FROM inserted);
--		SET @id = (SELECT Id_����� FROM inserted);

--		UPDATE ����� SET ���������� = ���������� - @count WHERE Id_����� =  @id;
--		SET NOCOUNT ON
--	END

CREATE TRIGGER [����������]
	ON [dbo].[��������]
	INSTEAD OF UPDATE
	AS
	BEGIN
		DECLARE @count1 int, @id1 int, @count2 int, @id2 int, @data2 datetime;
		SET @count2 = (SELECT ���������� FROM inserted);
		SET @id2 = (SELECT Id_����� FROM inserted);
		SET @data2 = (SELECT ���� FROM inserted);

		SET @count1 = (SELECT ���������� FROM �������� WHERE Id_�������� = (SELECT Id_�������� FROM inserted));
		SET @id1 = (SELECT Id_����� FROM �������� WHERE Id_�������� = (SELECT Id_�������� FROM inserted));


		UPDATE ����� SET ���������� = ���������� - @count1 WHERE Id_����� =  @id1;
		UPDATE ����� SET ���������� = ���������� + @count2 WHERE Id_����� =  @id2;

		UPDATE �������� SET  ���� = @data2, Id_����� = @id2, ���������� = @count2 WHERE Id_�������� = (SELECT Id_�������� FROM inserted);
		SET NOCOUNT ON
	END