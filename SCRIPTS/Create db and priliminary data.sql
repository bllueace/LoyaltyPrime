USE master
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'LOYALTY_PRIME')
BEGIN
	CREATE DATABASE LOYALTY_PRIME;
END;
GO

USE LOYALTY_PRIME;
GO

DROP TABLE IF EXISTS Accounts
GO

DROP TABLE IF EXISTS Users
GO

CREATE TABLE Users (
    UserID int NOT NULL PRIMARY KEY,
    LastName nvarchar(50),
    FirstName nvarchar(50),
    CityAddress nvarchar(50),
);

GO

CREATE TABLE Accounts (
    AccountID int NOT NULL PRIMARY KEY,
	UserID int NOT NULL FOREIGN KEY REFERENCES Users(UserID),
	AccountName nvarchar(50),
	PointsAvailable int,
	PointsSpent int,
	AccStatus nvarchar(10)
);
GO

CREATE TABLE IDCounts (
    nextAccountID int,
	nextUserID int,
);
GO

INSERT INTO Users 
VALUES (1, 'Smolaks', 'Edgars', 'Dundee')
GO

INSERT INTO Accounts
VALUES (1, 1, 'BURGER KING', 125, 5, 'ACTIVE')
GO
