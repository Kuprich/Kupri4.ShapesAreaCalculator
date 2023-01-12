CREATE TABLE Products(
	Id INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL
)	


CREATE TABLE Categories(
	Id INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL
)	

CREATE TABLE Products_Categories(
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
)	

INSERT INTO Products VALUES
(1, 'Apple'), 
(2, 'Orange'), 
(3, 'Terminator T1000'), 
(4, 'Teapot'), 
(5, 'Screwdriver')

INSERT INTO Categories VALUES	
(1, 'Fruit'),
(2, 'Machine'),
(3, 'Tool'),
(4, 'Alcohol'),
(5, 'Smartphone')

INSERT INTO Products_Categories VALUES
(1, 1),
(1, 5),
(2, 1),
(3, 2),
(5, 3),
(5, 4)

SELECT Products.[Name] AS Product, Categories.[Name] AS Category
FROM Products
LEFT JOIN Products_Categories
	ON Products.Id = Products_Categories.ProductId
LEFT JOIN Categories
	ON Products_Categories.CategoryId = Categories.Id;







