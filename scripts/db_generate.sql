USE MASTER
GO
DROP DATABASE IF EXISTS Damera_DB
GO
CREATE DATABASE Damera_DB;
GO
USE Damera_DB;
GO
CREATE TABLE [dbo].[User] ( 
	ID int IDENTITY(1,1) PRIMARY KEY,
	Email varchar(255),
	Password varchar(255)
);
GO
CREATE TABLE [dbo].[Token](
	[TokenID] [int] IDENTITY(1,1) PRIMARY KEY,
	[UserID] [int] FOREIGN KEY REFERENCES [dbo].[User](ID) NOT NULL,
	[UserToken] [varchar](255) NULL,
	[CreateDate] [datetime] NULL DEFAULT (getdate()),
	[ExpirationDate] [datetime] NULL DEFAULT (dateadd(hour,(6),getdate()))
)
GO
INSERT INTO [dbo].[User] VALUES ('jerazmus@o2.pl', 'passwd')
INSERT INTO [dbo].[User] VALUES ('damian@o2.pl', 'passwd')
