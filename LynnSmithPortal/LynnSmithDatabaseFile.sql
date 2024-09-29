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

-- Application Table
CREATE TABLE users.[Application] (
    ApplicationId INT IDENTITY(1,1) PRIMARY KEY,
    ApplicationDate DATE NOT NULL,
    [Status] NVARCHAR(50) NOT NULL CHECK (Status IN ('Pending', 'Accepted', 'Rejected')), -- Application status
    PersonalStatement NVARCHAR(1000), -- Example field for a personal statement or essay
    DesiredMajor NVARCHAR(100), -- Major the applicant wants to pursue
    [References] NVARCHAR(500) -- Example field for references or letters of recommendation
);

-- Student Table (Includes applicants, linked to an application)
CREATE TABLE users.Student (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    HashedPassword NVARCHAR(255) NOT NULL,
    AccessLevel INT NOT NULL CHECK (AccessLevel BETWEEN 1 AND 2), -- 1 for Applicant, 2 for Real Student
    EnrollmentDate DATE, -- Nullable for applicants (since they aren't enrolled yet)
    Major NVARCHAR(100), -- Nullable for applicants (since they may not have declared a major yet)
    ApplicationId INT UNIQUE FOREIGN KEY REFERENCES users.[Application](ApplicationId) -- Links to the Application table
);

-- Insert sample data
SET IDENTITY_INSERT users.[Admin] ON;
INSERT INTO users.Admin (Id, [Name], Email, HashedPassword, AccessLevel, AdminLevel, IsSuperAdmin)
VALUES (1, 'Admin', 'admin@admin.com', 'hashedpassword', 4, 1, 1);
SET IDENTITY_INSERT users.[Admin] OFF;

SET IDENTITY_INSERT users.Faculty ON;
INSERT INTO users.Faculty (Id, [Name], Email, HashedPassword, AccessLevel, Department, HireDate)
VALUES (2, 'Dr. John', 'johnb@lsu.com', 'hashedpassword', 3, 'Computer Science', '2020-08-15');
SET IDENTITY_INSERT users.Faculty OFF;

-- Insert Application and Student Data
SET IDENTITY_INSERT users.[Application] ON;
INSERT INTO users.[Application] (ApplicationId, ApplicationDate, [Status], PersonalStatement, DesiredMajor, [References])
VALUES (1, '2022-12-01', 'Pending', 'I love studying technology.', 'Computer Science', 'Prof. A, Prof. B');
SET IDENTITY_INSERT users.[Application] OFF;

SET IDENTITY_INSERT users.Student ON;
-- Real student (No application)
INSERT INTO users.Student (Id, [Name], Email, HashedPassword, AccessLevel, EnrollmentDate, Major, ApplicationId)
VALUES (3, 'Jane Doe', 'jane@student.com', 'hashedpassword', 2, '2021-09-01', 'Engineering', NULL);

-- Applicant (Linked to application)
INSERT INTO users.Student (Id, [Name], Email, HashedPassword, AccessLevel, EnrollmentDate, Major, ApplicationId)
VALUES (4, 'Mark Smith', 'mark@applicant.com', 'hashedpassword', 1, NULL, NULL, 1);
SET IDENTITY_INSERT users.Student OFF;

-- View all Admins
SELECT * FROM users.[Admin];

-- View all Faculty
SELECT * FROM users.Faculty;

-- View all Students (including applicants)
SELECT * FROM users.Student;

-- View Applications
SELECT * FROM users.[Application];