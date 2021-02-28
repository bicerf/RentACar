CREATE TABLE Cars (
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY	(BrandId) REFERENCES Brands(BrandId),
	FOREIGN KEY	(ColorId) REFERENCES Colors(ColorId)
)

CREATE TABLE Colors (
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25)
)

CREATE TABLE Brands (
	BrandId int PRIMARY KEY IDENTITY (1,1),
	BrandName nvarchar(25)
)

CREATE TABLE Users(
	Id int PRIMARY KEY IDENTITY (1,1),
	FirstName nvarchar(40),
	LastName nvarchar(40),
	Email nvarchar(40),
	Passwords nvarchar(40),
	
)

CREATE TABLE Customers(
	Id int PRIMARY KEY IDENTITY (1,1),
	UserId int,
	CompanyName nvarchar(40),
	FOREIGN KEY (UserId) REFERENCES Users(Id),
)

CREATE TABLE Rentals(
	Id int PRIMARY KEY IDENTITY (1,1),
	CarId int,
	CustomerId int,
	RentDate datetime,
	ReturnDate datetime,
	FOREIGN KEY (CarId) REFERENCES Cars(Id),
	FOREIGN KEY (CustomerId) REFERENCES Customers(Id)

)

CREATE TABLE CarImages (
    Id int PRIMARY KEY IDENTITY (1,1),
    CarId int NOT NULL,
    ImagePath varchar(255) NOT NULL,
    ImageDate datetime DEFAULT GETDATE(),
    FOREIGN KEY (CarId) REFERENCES Cars(Id)
);




INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2012','100','MANUEL-TUPLU'),
	('1','3','2015','150','OTOMATIK-DIZEL'),
	('2','1','2017','200','OTOMATIK-HYBRID'),
	('3','3','2014','125','MANUEL-BENZIN');

INSERT INTO Brands(BrandName)
VALUES
	('MERCEDES'),
	('AUDI'),
	('BMW');

INSERT INTO Colors(ColorName)
VALUES
	('SIYAH'),
	('BEYAZ'),
	('KIRMIZI');

SELECT * FROM Cars
SELECT * FROM Colors
SELECT * FROM Brands
SELECT * FROM Users
SELECT * FROM Customers
SELECT * FROM Rentals
SELECT * FROM CarImages



