CREATE TABLE Cars(
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	Descriptions nvarchar(30),
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId)

)

CREATE TABLE Colors(
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(30),
)

CREATE TABLE Brands(
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(30),
)

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	(1,1,2018,500,'Orta segment'),
	(2,2,2018,700,'Orta segment'),
	(3,3,2019,1000,'Orta-Üst segment'),
	(4,4,2017,550,'Orta segment'),
	(5,4,2020,2000,'Üst segment');

INSERT INTO Colors(ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Kırmızı'),
	('Lacivert');

INSERT INTO Brands(BrandName)
VALUES
	('Mercedes'),
	('Audi'),
	('BMW'),
	('Opel'),
	('Renault');

SELECT * FROM Cars
SELECT * FROM Brands
SELECT * FROM Colors