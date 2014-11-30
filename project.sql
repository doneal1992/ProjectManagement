
USE master
GO

IF EXISTS(select * from sys.databases where name='Project_Tracking_System')
DROP DATABASE Project_Tracking_System
GO

CREATE DATABASE Project_Tracking_System
GO

USE Project_Tracking_System
GO


CREATE TABLE Project_Manager
(
  id int,
  FName varchar(25) NOT NULL,
  LName varchar(25) NOT NULL,
  PRIMARY KEY (id)
)
GO

CREATE TABLE Project
(
  projectID int UNIQUE,
  projectName varchar(30),
  description varchar(2000),
  
  PRIMARY KEY(projectName),
  FOREIGN KEY(projectID) REFERENCES Project_Manager(id)
 
)
GO

CREATE TABLE Employee
(
  currProjID int,
  Fname varchar(25),
  Lname varchar(25),
  position varchar(25),

)
GO

CREATE TABLE Requirements
(
  requirementID int,
  type varchar(20),
  description varchar(500),
 
)
GO

CREATE TABLE Risks
(
  risksID int,
  description varchar(500),
  riskStatus varchar(25),

)
GO

CREATE TABLE Effort
(
  effortProjID int,
  designHours int,
  codeHours int,
  reqAnalysis int,
  testingHours int,
  projManagementHours int,
 
)
GO

CREATE TABLE Archived_Projects
(
   projectID int,
   projectName varchar(25),
   projectDescription varchar(5000),
)
GO


SELECT * FROM EMPLOYEE;
SELECT * FROM Project_Manager;
