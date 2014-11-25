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
  projectID int,
  projectName varchar(30),
  description varchar(2000),
  PRIMARY KEY(projectID),
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

INSERT INTO Project_Manager VALUES(02123,'Danny','ONeal');
INSERT INTO Project_Manager VALUES(02124,'Seth', 'Wilhoite');
INSERT INTO Project VALUES(02124,'Project Tracking System','Project about games');
INSERT INTO Project VALUES(02123,'Sql Database','Project concerning sql databases');
INSERT INTO Employee VALUES(02123,'Jim','Brown','Coder');
INSERT INTO Employee VALUES(02124,'John','Brown','Designer');
INSERT INTO Requirements VALUES(02123,'Functional','Product shall allow user to see expended hours');
INSERT INTO Risks VALUES(02123,'Hours could be incorrect due to experiences','In progress');
INSERT INTO Effort VALUES(02123,45,34,54,34,54);

