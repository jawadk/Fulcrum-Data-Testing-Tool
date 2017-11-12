CREATE DATABASE FulcrumTempData

GO 

USE FulcrumTempData

CREATE TABLE [dbo].[Fulcrum_XML_Data] (
    ID int NOT NULL,
    MessageID varchar(255),
    IF_Tag varchar(255),
    IF_Data varchar(255),
	Expected_data varchar(255),
);

GO 

Alter table Fulcrum_XML_Data 
ADD PRIMARY KEY (ID);

