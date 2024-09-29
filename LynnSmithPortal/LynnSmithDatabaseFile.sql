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

-- Courses Table
CREATE TABLE users.Courses (
    CourseId INT IDENTITY(1,1) PRIMARY KEY,
    CourseName NVARCHAR(100) NOT NULL,
    Credits INT NOT NULL,
    SeatsAvailable INT NOT NULL,
    StudentsEnrolled INT NOT NULL DEFAULT 0, -- Keeps track of the number of students enrolled
    DaysOfWeek NVARCHAR(50), -- For example, "Mon, Wed, Fri"
    Prerequisites NVARCHAR(255), -- List of prerequisites as a comma-separated string
    -- Additional fields for course details can be added here
);

-- Join Table: StudentCourses (many-to-many relationship)
CREATE TABLE users.StudentCourses (
    StudentId INT NOT NULL FOREIGN KEY REFERENCES users.Student(Id),
    CourseId INT NOT NULL FOREIGN KEY REFERENCES users.Courses(CourseId),
    PRIMARY KEY (StudentId, CourseId) -- Composite primary key
);

-- Join Table: CompletedCourses (Completed Courses)
CREATE TABLE users.CompletedCourses (
    StudentId INT NOT NULL FOREIGN KEY REFERENCES users.Student(Id),
    CourseId INT NOT NULL FOREIGN KEY REFERENCES users.Courses(CourseId),
    CompletionDate DATE NOT NULL,
    Grade NVARCHAR(2), -- Optional grade for the completed course
    PRIMARY KEY (StudentId, CourseId) -- Composite primary key
);

-- Insert sample data for Admin and Faculty
SET IDENTITY_INSERT users.[Admin] ON;
INSERT INTO users.[Admin] (Id, [Name], Email, HashedPassword, AccessLevel, AdminLevel, IsSuperAdmin)
VALUES (1, 'Admin', 'admin@admin.com', 'hashedpassword', 4, 1, 1);
SET IDENTITY_INSERT users.[Admin] OFF;

SET IDENTITY_INSERT users.Faculty ON;
INSERT INTO users.Faculty (Id, [Name], Email, HashedPassword, AccessLevel, Department, HireDate)
VALUES (2, 'Dr. John', 'johnb@lsu.com', 'hashedpassword', 3, 'Computer Science', '2020-08-15');
SET IDENTITY_INSERT users.Faculty OFF;

-- Insert sample data for Application and Student
SET IDENTITY_INSERT users.[Application] ON;
INSERT INTO users.[Application] (ApplicationId, ApplicationDate, [Status], PersonalStatement, DesiredMajor, [References])
VALUES (1, '2022-12-01', 'Pending', 'I love studying technology.', 'Computer Science', 'Prof. A, Prof. B');
SET IDENTITY_INSERT users.[Application] OFF;

SET IDENTITY_INSERT users.Student ON;
INSERT INTO users.Student (Id, [Name], Email, HashedPassword, AccessLevel, EnrollmentDate, Major, ApplicationId)
VALUES (3, 'Jane Doe', 'jane@student.com', 'hashedpassword', 2, '2021-09-01', 'Engineering', NULL);

INSERT INTO users.Student (Id, [Name], Email, HashedPassword, AccessLevel, EnrollmentDate, Major, ApplicationId)
VALUES (4, 'Mark Smith', 'mark@applicant.com', 'hashedpassword', 1, NULL, NULL, 1);
SET IDENTITY_INSERT users.Student OFF;

-- Insert sample data for Courses
INSERT INTO users.Courses (CourseName, Credits, SeatsAvailable, DaysOfWeek, Prerequisites)
VALUES ('Introduction to Computer Science', 3, 30, 'Mon, Wed, Fri', 'None');

INSERT INTO users.Courses (CourseName, Credits, SeatsAvailable, DaysOfWeek, Prerequisites)
VALUES ('Data Structures', 3, 25, 'Tue, Thu', 'Introduction to Computer Science');

-- Enroll Students in Courses
INSERT INTO users.StudentCourses (StudentId, CourseId)
VALUES (3, 1), (3, 2), (4, 1);

-- Insert Completed Courses for Students
INSERT INTO users.CompletedCourses (StudentId, CourseId, CompletionDate, Grade)
VALUES (3, 1, '2022-05-15', 'A');

-- View all Completed Courses for a Student
SELECT * FROM users.Student;