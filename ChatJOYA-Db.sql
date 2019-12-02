CREATE DATABASE ChatJOYA;
USE ChatJOYA;
CREATE TABLE Users (
    id         int  NOT NULL identity (1,1),
    nick      varchar(20) NOT NULL,
	connec    bit NOT NULL,
    PRIMARY KEY(id)
) ;
CREATE TABLE Room (
    id         int  NOT NULL identity (1,1),
    name      varchar(20) NOT NULL,
	users      int NOT NULL
    PRIMARY KEY(id)
) ;
CREATE TABLE Message (
    id     int  NOT NULL identity (1,1),
    idUser      int  NOT NULL,
    text        varchar(100) NOT NULL,
    idRoom       int NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(idUser) REFERENCES Users(id),
	FOREIGN KEY(idRoom) REFERENCES Room(id)
) ;