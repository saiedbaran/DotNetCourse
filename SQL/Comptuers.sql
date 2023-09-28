CREATE DATABASE DotNetCourseDatabase
GO

USE DotNetCourseDatabase
GO

CREATE SCHEMA DotNetCourseSchema
GO

CREATE TABLE DotNetCourseSchema.Computer
(
    ComputerId INT IDENTITY(1,1) PRIMARY KEY,
    ComputerName NVARCHAR(50),
    HasWifi BIT,
    HasLTE BIT,
    ReleaseDate DATE,
    Price DECIMAL(18,2),
    VideoCard NVARCHAR(50)
);

SELECT *
FROM DotNetCourseSchema.Computer