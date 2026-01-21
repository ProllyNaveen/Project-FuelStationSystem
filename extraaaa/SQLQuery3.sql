CREATE DATABASE FuelStationDB

CREATE TABLE USERS(
Admin int,
Userid int PRIMARY KEY,
Username VARCHAR(40) NOT NULL,
Password VARCHAR(255) NOT NULL,

);

drop table users

CREATE TABLE Admins(
adminid int PRIMARY KEY,
adminname VARCHAR(40) NOT NULL,
Password VARCHAR(255) NOT NULL,

);

CREATE TABLE Cashier(
Cashierid int PRIMARY KEY,
Cashiername VARCHAR(40) NOT NULL,
Password VARCHAR(255) NOT NULL,

);

Insert INTO Admins(adminid,adminname,Password)
VALUES(1,'admin','admin123');

Insert INTO Cashier(Cashierid,Cashiername,Password)
VALUES(1,'cashier','cashier123');

ALTER TABLE Admins
DROP COLUMN adminid;

ALTER TABLE Admins
ADD admin_id INT IDENTITY(1,1);


ALTER TABLE Admins
DROP COLUMN adminid;
ALTER TABLE Admins
DROP CONSTRAINT PK__Admin__AD040D7E3D93BD13;

ALTER TABLE Admins
ADD CONSTRAINT PK_Admin PRIMARY KEY (admin_id);

ALTER TABLE Cashier
DROP CONSTRAINT PK__Cashier__C58C28BE08625447;
ALTER TABLE Cashier
DROP COLUMN Cashierid;

ALTER TABLE Cashier
ADD Cashierid INT IDENTITY(1,1);

ALTER TABLE Cashier
ADD CONSTRAINT PK_Cashier PRIMARY KEY (Cashierid);


CREATE TABLE FuelTypes (
    FuelID INT IDENTITY(1,1) PRIMARY KEY,
    FuelName NVARCHAR(50) NOT NULL,
    PricePerLiter DECIMAL(10, 2) NOT NULL
);

SELECT * FROM FuelTypes

CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    FuelID INT FOREIGN KEY REFERENCES FuelTypes(FuelID),
    Liters DECIMAL(10, 2) NOT NULL,
    TotalPrice DECIMAL(10, 2) NOT NULL,
    TransactionDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE FuelInventory (
    InventoryID INT IDENTITY(1,1) PRIMARY KEY,
    FuelID INT FOREIGN KEY REFERENCES FuelTypes(FuelID),
    StockLevel DECIMAL(10, 2) NOT NULL
);
INSERT INTO FuelInventory (FuelID, StockLevel) 
VALUES ((SELECT FuelID FROM FuelTypes WHERE FuelName = 95), 500);
INSERT INTO FuelInventory (FuelID, StockLevel) 
VALUES ((SELECT FuelID FROM FuelTypes WHERE FuelName = 92), 300);
INSERT INTO FuelInventory (FuelID, StockLevel) 
VALUES ((SELECT FuelID FROM FuelTypes WHERE FuelName = 90), 400);

DELETE FROM FuelTypes WHERE FuelID = 7;