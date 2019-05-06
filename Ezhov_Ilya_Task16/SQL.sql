USE master
IF(db_id(N'UsersAndAwards')) IS NOT NULL
	DROP DATABASE UsersAndAwards

CREATE DATABASE UsersAndAwards
GO

DROP TABLE Users
DROP TABLE Awards
DROP TABLE UserAwardsRelation

USE UsersAndAwards

CREATE TABLE Users 
(
UserID INT IDENTITY (1,1)  PRIMARY KEY NOT NULL,
[FirstName] NVARCHAR(50) NOT NULL,
[LastName] NVARCHAR(50) NOT NULL,
[BirthDate] DATETIME2 NOT NULL
)

CREATE TABLE Awards
(
AwardID INT IDENTITY (1,1)  PRIMARY KEY NOT NULL,
[Title] NVARCHAR(50) NOT NULL,
[Description] NVARCHAR(250) NOT NULL
)

TRUNCATE TABLE Users;
INSERT INTO Users
VALUES ('Ivan','Petrov','12-02-1965');
INSERT INTO Users
VALUES ('Vasiliy','Zaytcev','09-16-1914');
INSERT INTO Users
VALUES ('John-Henry','Eden','01-12-2018');
INSERT INTO Users
VALUES ('Dani','California','05-02-1983');
INSERT INTO Users
VALUES ('Ringo','Star','05-05-1938');

TRUNCATE TABLE Awards;
INSERT INTO Awards
VALUES ('Nobel Prize','It is a set of annual international awards bestowed in several categories by Swedish and Norwegian institutions in recognition of academic, cultural, or scientific advances.');
INSERT INTO Awards
VALUES ('Oscar','The Academy Awards, also known as the Oscars, are a set of awards for artistic and technical merit in the film industry.');
INSERT INTO Awards
VALUES ('Emmy','An Emmy Award, or simply Emmy, is an American award that recognizes excellence in the television industry, and is the equivalent of an Academy Award (for film), the Tony Award (for theater), and the Grammy Award (for music).');

CREATE TABLE UserAwardsRelation
(
[UserID] INT NOT NULL,
[AwardID] INT NOT NULL,
FOREIGN KEY (UserID)  REFERENCES Users(UserID),
FOREIGN KEY (AwardID)  REFERENCES Awards(AwardID),
PRIMARY KEY (UserID, AwardID)
)

TRUNCATE TABLE UserAwardsRelation;
INSERT INTO UserAwardsRelation
VALUES (1,1);
INSERT INTO UserAwardsRelation
VALUES (1,2);
INSERT INTO UserAwardsRelation
VALUES (1,3);
INSERT INTO UserAwardsRelation
VALUES (2,2);

USE [UsersAndAwards]
GO 
CREATE PROCEDURE GetUsersWithAwardID
AS
SELECT Users.*, UserAwardsRelation.AwardID
FROM Users 
LEFT JOIN UserAwardsRelation ON Users.UserID = UserAwardsRelation.UserID;

-- common proc.es
GO 
CREATE PROCEDURE GetAllRelations
AS
SELECT UserAwardsRelation.*
FROM UserAwardsRelation

GO 
CREATE PROCEDURE InsertRelation(
@userID int,
@awardID int)
AS
INSERT INTO UserAwardsRelation(UserID, AwardID)
VALUES (@userID, @awardID)

-- WRONG LOGIC
GO 
CREATE PROCEDURE UpdateRelation(
@userID int,
@awardID int)
AS
INSERT INTO UserAwardsRelation(UserID, AwardID)
VALUES (@userID, @awardID)

GO 
CREATE PROCEDURE RemoveRelation(
@userID int,
@awardID int)
AS
AS DELETE FROM UserAwardsRelation WHERE (AwardID = @awardID AND UserID = @userID)

GO 
CREATE PROCEDURE GetAllInfo
AS
SELECT Users.*, UserAwardsRelation.AwardID, Awards.Title, Awards.[Description]
FROM Users 
LEFT JOIN UserAwardsRelation ON Users.UserID = UserAwardsRelation.UserID
LEFT JOIN Awards ON Awards.AwardID = UserAwardsRelation.AwardID;

--можно сделать 

-- user proc.es
GO 
CREATE PROCEDURE GetAllUsers
AS
SELECT Users.*
FROM Users

GO 
CREATE PROCEDURE GetUserInfo (@userID int)
AS
SELECT Users.*, UserAwardsRelation.AwardID, Awards.Title, Awards.[Description]
FROM Users 
LEFT JOIN UserAwardsRelation ON Users.UserID = UserAwardsRelation.UserID
LEFT JOIN Awards ON Awards.AwardID = UserAwardsRelation.AwardID
WHERE Users.UserID = @userID;

GO 
CREATE PROCEDURE InsertUser(
@firstName nvarchar(50),
@lastName nvarchar(50),
@birthDate datetime2)
AS
INSERT INTO [Users](FirstName, LastName, BirthDate)
OUTPUT INSERTED.UserID
VALUES(@firstName, @lastName, @birthdate)
-- можно добавить тип данных, который передает награды
-- заггулить как передать таблицу в хранимку

GO 
CREATE PROCEDURE UpdateUser(
@userID int,
@firstName nvarchar(50),
@lastName nvarchar(50),
@birthDate datetime2)
AS
UPDATE Users
SET FirstName = @firstName,
LastName @lastName, 
BirthDate = @birthdate)
WHERE UserID = @userID

GO 
CREATE PROCEDURE RemoveUser (@userID int)
AS DELETE FROM [Users] WHERE UserID = @userID;

-- award proc.es
GO 
CREATE PROCEDURE GetAllAwards
AS
SELECT Awards.*
FROM Awards

GO 
CREATE PROCEDURE GetAwardInfo (@awardID int)
AS
SELECT Awards.*
FROM Awards 
WHERE Awards.AwardID = @awardID;

GO 
CREATE PROCEDURE InsertAward(
@title nvarchar(50),
@description nvarchar(250))
AS
INSERT INTO [Awards](Title, [Description])
OUTPUT INSERTED.AwardID
VALUES(@title, @description)

GO 
CREATE PROCEDURE UpdateAward(
@awardID int,
@title nvarchar(50),
@description nvarchar(250))
AS
UPDATE Awards
SET Title = @title,
[Description] = @description)
WHERE AwardID = @awardID

GO 
CREATE PROCEDURE RemoveAward(@awardID int)
AS DELETE FROM Awards WHERE AwardID = @awardID;

DROP DATABASE UsersAndAwards;