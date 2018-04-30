Create Database CodingChallenge;
Go
Create Schema Challenge
Go

Use CodingChallenge
Go

Create Table Customers(ID int NOT NULL, FirstName nvarchar(20), LastName nvarchar(20), CardNumber nvarchar(10), primary key(ID));
Create Table Products(ID int NOT NULL, ProductName nvarchar(20), Price int, primary key(ID));
Create Table Orders(ID int not null, ProductId int, CustomerId int, primary key(id), foreign key(productid) references Products(id), foreign key (customerid) references Customers(id));

Insert Into Customers( Id,FirstName, LastName, CardNumber) Values (1,'Adam', 'Jones', '8423121645');
Insert Into Customers( Id,FirstName, LastName, CardNumber) Values (2,'John', 'Madison', '8421645872');
Insert Into Customers( Id,FirstName, LastName, CardNumber) Values (3,'Alice', 'Potter', '3164946285');

Insert Into Products(Id, ProductName,Price) Values (1,'Gum',3);
Insert Into Products(Id, ProductName,Price) Values (2,'Shoes',100);
Insert Into Products(Id, ProductName,Price) Values (3,'Computer',600);

Insert Into Orders(ProductId, CustomerId) Values()

Insert Into Products(Id,ProductName,Price) Values (4,'IPhone',200);
Insert Into Customers(FirstName,LastName) Values ('Tina','Smith');

Insert Into Orders(ProductId, CustomerId) Where

Select Customers.FirstName, Customers.LastName, Orders.ProductId From Customers, Orders
Where Customers.FirstName = 'Tina' AND Customers.LastName = 'Smith' And Customers.ID = Orders.CustomerId;

Oders

Update Products Set Price = 250 Where ProductName = 'IPhone';