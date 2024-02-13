--Kelimeler
--Örnekler

CREATE DATABASE SozlukDB
GO
USE SozlukDB
GO
CREATE TABLE Kelimeler
(
ID int IDENTITY(1,1) NOT NULL,
Kelime nvarchar(50) NOT NULL,
Anlam nvarchar(100) NOT NULL,
CONSTRAINT pk_kelime PRIMARY KEY(ID)
)
GO
CREATE TABLE Ornekler
(
ID int IDENTITY(1,1) NOT NULL,
Kelime_ID int NOT NULL,
Ornek nvarchar(1000) NOT NULL,
Anlam nvarchar(1000) NOT NULL,
CONSTRAINT pk_ornek PRIMARY KEY(ID),
CONSTRAINT fk_ornekKelime FOREIGN KEY(Kelime_ID) REFERENCES Kelimeler(ID)
)
GO
CREATE TABLE Adminler
(
ID int IDENTITY(1,1) NOT NULL,
KullaniciAdi nvarchar(25) NOT NULL,
Sifre nvarchar(18) NOT NULL,
CONSTRAINT pk_admin PRIMARY KEY(ID)
)