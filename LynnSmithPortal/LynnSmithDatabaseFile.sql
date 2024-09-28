USE master;
IF DB_ID(N'LynnSmithUniversityDB') IS NOT NULL DROP DATABASE LynnSmithUniversityDB;
CREATE DATABASE LynnSmithUniversityDB;
GO
USE LynnSmithUniversityDB;
GO

CREATE SCHEMA Users AUTHORIZATION dbo;
GO


 CREATE TABLE users.[Admin] (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    HashedPassword NVARCHAR(255) NOT NULL,
    AccessLevel INT NOT NULL CHECK (AccessLevel = 4), -- 4 for Admin
    AdminLevel INT NOT NULL, -- Custom field for admin-specific role
    IsSuperAdmin BIT NOT NULL DEFAULT 0 -- Admin role flag
);

 CREATE TABLE users.Faculty (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    HashedPassword NVARCHAR(255) NOT NULL,
    AccessLevel INT NOT NULL CHECK (AccessLevel = 3), -- 3 for Faculty
    Department NVARCHAR(100) NOT NULL, -- Faculty-specific field
    HireDate DATE NOT NULL -- Faculty hire date
);

CREATE TABLE users.Student (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    HashedPassword NVARCHAR(255) NOT NULL,
    AccessLevel INT NOT NULL CHECK (AccessLevel = 2), -- 2 for Student
    EnrollmentDate DATE NOT NULL, -- Student-specific field
    Major NVARCHAR(100) NOT NULL -- Major field for students
);

CREATE TABLE users.Applicant (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    HashedPassword NVARCHAR(255) NOT NULL,
    AccessLevel INT NOT NULL CHECK (AccessLevel = 1), -- 1 for Applicant
    ApplicationDate DATE NOT NULL, -- Applicant-specific field
    Status NVARCHAR(50) NOT NULL -- Application status (e.g., Pending, Accepted)
);


 

SET IDENTITY_INSERT users.Admin ON;
INSERT INTO users.Admin (Id, [Name], Email, HashedPassword, AccessLevel, AdminLevel, IsSuperAdmin)
VALUES (1, 'Admin', 'admin@admin.com', 'hashedpassword', 4, 1, 1);
SET IDENTITY_INSERT users.Admin OFF;

SET IDENTITY_INSERT users.Faculty ON;
INSERT INTO users.Faculty (Id, [Name], Email, HashedPassword, AccessLevel, Department, HireDate)
VALUES (2, 'Dr. John', 'johnb@lsu.com', 'hashedpassword', 3, 'Computer Science', '2020-08-15');
SET IDENTITY_INSERT users.Faculty OFF;

SET IDENTITY_INSERT users.Student ON;
INSERT INTO users.Student (Id, [Name], Email, HashedPassword, AccessLevel, EnrollmentDate, Major)
VALUES (3, 'Jane Doe', 'jane@student.com', 'hashedpassword', 2, '2021-09-01', 'Engineering');
SET IDENTITY_INSERT users.Student OFF;

SET IDENTITY_INSERT users.Applicant ON;
INSERT INTO users.Applicant (Id, [Name], Email, HashedPassword, AccessLevel, ApplicationDate, Status)
VALUES (4, 'Mark Smith', 'mark@applicant.com', 'hashedpassword', 1, '2022-12-01', 'Pending');
SET IDENTITY_INSERT users.Applicant OFF;

SELECT * FROM users.Admin;
