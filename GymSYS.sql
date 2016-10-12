-- Christopher Cunningham GD
-- GymSYS.sql
-- This script builds the database for the gym system
DROP TABLE PLANS;
DROP TABLE FITNESS_HISTORY;

DROP TABLE FITNESS_PROFILE;
DROP TABLE MEMBERS;

CREATE TABLE MEMBERS(
MemberID numeric(5) NOT NULL,
Surname char (15)NOT NULL,
Forename char (15)NOT NULL,
Gender char (6) NOT NULL,
Address char(25)NOT NULL,
Date_Of_Birth char(20)NOT NULL,
Phone numeric(10)NOT NULL,
Email char(30)NOT NULL,
Plan char(40)NOT NULL,
Date_Registered char(15),
CONSTRAINT pk_MembersId Primary Key(MemberID));

CREATE TABLE FITNESS_PROFILE(
ProfileID numeric(5)NOT NULL,
MemberID numeric(5)NOT NULL,
Weight numeric(3)NOT NULL,
Height numeric (3),
Heart_Rate numeric(3)NOT NULL,
Illness char(100),
Injurys char(100),
Blood_Pressure numeric(5)NOT NULL,
BMI numeric(2)NOT NULL,
Body_Fat numeric(2)NOT NULL,
Diet_Plan char(20),
Exercise_Plan char(20),
Reg_Date char(15),
CONSTRAINT pk_ProfilesId Primary Key(ProfileID),
CONSTRAINT fk_FP_Members FOREIGN KEY (MemberID) REFERENCES Members);



CREATE TABLE FITNESS_HISTORY(

ProfileID numeric(5)NOT NULL,
MemberID numeric(5)NOT NULL,
Weight numeric (5)NOT NULL,
Heart_Rate numeric(5)NOT NULL,
Blood_Pressure numeric(5)NOT NULL,
BMI numeric(2)NOT NULL,
Body_Fat numeric(2)NOT NULL,
Amend_Date char (15),

CONSTRAINT fk_Profiles FOREIGN KEY(ProfileID) REFERENCES Fitness_Profile,
CONSTRAINT fk_Members FOREIGN KEY (MemberID) REFERENCES Members);


CREATE TABLE PLANS(
Plan_Code numeric(10)NOT NULL, 
Price numeric(10) NOT NULL,
Plan_Duration char(20) NOT NULL,
Profile_Included char (4),
CONSTRAINT pk_Plans PRIMARY KEY (Plan_Code));









