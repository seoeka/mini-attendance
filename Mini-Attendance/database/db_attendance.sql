-- Membuat Database
CREATE DATABASE db_attendance;

USE db_attendance;

-- Membuat Tabel Mahasiswa
CREATE TABLE Mahasiswa (
  ID INT IDENTITY(1,1) NOT NULL,
  Nama VARCHAR(100) NOT NULL,
  NIM VARCHAR(30) UNIQUE,
  Email VARCHAR(55) UNIQUE,
  Password VARCHAR(20) NOT NULL,
  CONSTRAINT PK_Mahasiswa PRIMARY KEY (ID)
);

-- Membuat Tabel Event
CREATE TABLE Event (
  ID INT IDENTITY(1,1) NOT NULL,
  Nama VARCHAR(100) NOT NULL,
  Lokasi VARCHAR(100) NOT NULL,
  Tanggal DATE NOT NULL,
  Peserta VARCHAR(20) NOT NULL,
  Gambar VARCHAR(100) NOT NULL,
  CONSTRAINT PK_Event PRIMARY KEY (ID)
);

-- Membuat Tabel Administrator
CREATE TABLE Administrator (
  ID INT IDENTITY(1,1) NOT NULL,
  Username VARCHAR(55) UNIQUE NOT NULL,
  Password VARCHAR(20) NOT NULL,
  CONSTRAINT PK_Administrator PRIMARY KEY (ID)
);

-- Membuat Tabel Dosen
CREATE TABLE Dosen (
  ID INT IDENTITY(1,1) NOT NULL,
  Nama VARCHAR(100) NOT NULL,
  NIP VARCHAR(30) UNIQUE,
  Email VARCHAR(55) UNIQUE,
  Password VARCHAR(20) NOT NULL,
  CONSTRAINT PK_Dosen PRIMARY KEY (ID)
);

-- Membuat Tabel Kelas
CREATE TABLE kelas (
  ID INT IDENTITY (1,1) NOT NULL,
  Nama VARCHAR(100) NOT NULL,
  Tanggal DATE NOT NULL,
  dosenID INT NOT NULL,
  CONSTRAINT PK_Kelas PRIMARY KEY (ID),
  CONSTRAINT FK_Kelas_Dosen FOREIGN KEY (dosenID) REFERENCES Dosen(ID)
);

-- Membuat Tabel Kehadiran
CREATE TABLE Kehadiran (
  ID INT IDENTITY (1,1),
  mhsID INT,
  kelasID INT,
  Tanggal DATE,
  status VARCHAR(20),
  CONSTRAINT PK_Kehadiran PRIMARY KEY (ID),
  CONSTRAINT FK_Kehadiran_Mahasiswa FOREIGN KEY (mhsID) REFERENCES Mahasiswa(ID),
  CONSTRAINT FK_Kehadiran_Kelas FOREIGN KEY (kelasID) REFERENCES Kelas(ID)
);

CREATE TABLE Event_Attendance (
  eventID INT,
  mhsID INT,
  dosenID INT,
  CONSTRAINT PK_Event_Attendance PRIMARY KEY (eventID, mhsID, dosenID),
  CONSTRAINT FK_Event_Attendance_Event FOREIGN KEY (eventID) REFERENCES Event(ID),
  CONSTRAINT FK_Event_Attendance_Mahasiswa FOREIGN KEY (mhsID) REFERENCES Mahasiswa(ID),
  CONSTRAINT FK_Event_Attendance_Dosen FOREIGN KEY (dosenID) REFERENCES Dosen(ID)
);

-- Menambahkan data Dosen
INSERT INTO Dosen (Nama, NIP, Email, Password)
VALUES
  ('Dr. Budi Santoso', 'NIP123', 'dosen1@example.com', '123456'),
  ('Prof. Dewi Arifah', 'NIP456', 'dosen2@example.com', '123456');

-- Menambahkan data Mahasiswa
INSERT INTO Mahasiswa (Nama, NIM, Email, Password)
VALUES
  ('Ekasari Amalia', 'NIM123', 'mahasiswa1@example.com', '123456'),
  ('Muhammad Raafi', 'NIM456', 'mahasiswa2@example.com', '123456');

-- Menambahkan data Administrator
INSERT INTO Administrator (Username, Password)
VALUES
  ('admin', '12345678');