﻿--create table Сотрудник
--	(ФИО nvarchar (60),
--	Логин nvarchar (20) Primary Key,
--	Пароль nvarchar (20),
--	ID_должность int Not Null)
--create table Должность
--	(ID_должность int Not Null Primary Key Identity(1,1),
--	Наименование nvarchar (60) Not Null)
--create table Товар
--	(Id_товар int Not Null Primary Key Identity(1,1),
--	Название nvarchar (60) Not Null,
--	Id_изготовитель int,
--	Категория nvarchar (60),
--	Цена_закупки real,
--	Цена_продажи real)
--create table Изготовитель
--	(Id_изготовитель int Not Null Primary Key Identity(1,1),
--	Название nvarchar (60) Not Null,
--	Страна nvarchar (60))
--create table Склад
--	(Id_товар int Not Null,
--	Количество int Not Null)
--create table Документ
--	(Id_документ int Not Null Primary Key Identity(1,1),
--	Дата datetime,
--	Id_товар int Not Null,
--	Количество int)
--create table Поступление_товара
--	(Id_поступление int Not Null Primary Key Identity(1,1),
--	Id_документ int,
--	Сумма real,
--	Кладовщик nvarchar (60))
--create table Реализация_товара
--	(Id_поступление int Not Null Primary Key Identity(1,1),
--	Id_документ int,
--	Сумма real,
--	Продавец nvarchar (60))

----связи между таблицами
--ALTER TABLE Сотрудник
--	ADD CONSTRAINT FK_Сотрудник_Должность
--	FOREIGN KEY (ID_должность) 
--	REFERENCES Должность (ID_должность);
--ALTER TABLE Склад
--	ADD CONSTRAINT FK_Склад_Товар
--	FOREIGN KEY (Id_товар) 
--	REFERENCES Товар (Id_товар);
--ALTER TABLE Товар
--	ADD CONSTRAINT FK_Товар_Изготовитель
--	FOREIGN KEY (Id_изготовитель) 
--	REFERENCES Изготовитель (Id_изготовитель);
--ALTER TABLE Документ
--	ADD CONSTRAINT FK_Документ_Товар
--	FOREIGN KEY (Id_товар) 
--	REFERENCES Товар (Id_товар);
--ALTER TABLE Поступление_товара
--	ADD CONSTRAINT FK_Поступление_товара_Документ
--	FOREIGN KEY (Id_документ) 
--	REFERENCES Документ (Id_документ);
--ALTER TABLE Реализация_товара
--	ADD CONSTRAINT FK_Реализация_товара_Документ
--	FOREIGN KEY (Id_документ) 
--	REFERENCES Документ (Id_документ);

--INSERT INTO Должность (Наименование) VALUES (N'Администратор');
--INSERT INTO Должность (Наименование) VALUES (N'Кладовщик');
--INSERT INTO Должность (Наименование) VALUES (N'Продавец');

--INSERT INTO Сотрудник (ФИО, Логин, Пароль, ID_должность) VALUES (N'Иванов И.И.', N'admin',  N'admin123', 1);
--INSERT INTO Сотрудник (ФИО, Логин, Пароль, ID_должность) VALUES (N'Кузнецов В.И.', N'kuz',  N'kuz123', 2);
--INSERT INTO Сотрудник (ФИО, Логин, Пароль, ID_должность) VALUES (N'Калинин К.К.', N'kkk',  N'15kk7k', 3);

--INSERT INTO Изготовитель(Название, Страна) VALUES (N'ООО Любимый город', N'Россия');
--INSERT INTO Изготовитель(Название, Страна) VALUES (N'ООО Казьминский молочный комбинат', N'Россия');

--INSERT INTO Товар (Название, Id_изготовитель, Категория, Цена_закупки, Цена_продажи) VALUES (N'Мое Любимое лето', 1,  N'Твогор', 80, 130);
--INSERT INTO Товар (Название, Id_изготовитель, Категория, Цена_закупки, Цена_продажи) VALUES (N'Молочная легенда Сметана 15%', 2,  N'Сметана', 45, 67);

--INSERT INTO Склад(Id_товар, Количество) VALUES (1, 30);
--INSERT INTO Склад(Id_товар, Количество) VALUES (2, 51);

--INSERT INTO Документ(Дата, Id_товар, Количество) VALUES ('15.1.2022', 1, 20);
--INSERT INTO Документ(Дата, Id_товар, Количество) VALUES ('20.1.2022', 2, 32);

--INSERT INTO Поступление_товара(Id_документ,	Сумма, Кладовщик) VALUES (1, 1600, 'Кузнецов В.И.');
--INSERT INTO Поступление_товара(Id_документ,	Сумма, Кладовщик) VALUES (2, 1440, 'Кузнецов В.И.');