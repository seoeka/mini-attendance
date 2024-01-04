-- Membuat Database
CREATE DATABASE db_attendance;

USE db_attendance;

-- Membuat Tabel Mahasiswa
CREATE TABLE mahasiswa (
  mhsID INT,
  namaMhs VARCHAR(100),
  nimMhs VARCHAR(30) UNIQUE,
  emailMhs VARCHAR(55) UNIQUE,
  password VARCHAR(20),
  CONSTRAINT PK_mahasiswa PRIMARY KEY (mhsID)
);

-- Membuat Tabel Event
CREATE TABLE event (
  eventID INT,
  namaEvent VARCHAR(100),
  lokasiEvent VARCHAR(100),
  tglEvent DATE,
  CONSTRAINT PK_event PRIMARY KEY (eventID)
);

-- Membuat Tabel Administrator
CREATE TABLE administrator (
  adminID INT,
  username VARCHAR(55) UNIQUE,
  password VARCHAR(20),
  CONSTRAINT PK_administrator PRIMARY KEY (adminID)
);

-- Membuat Tabel Dosen
CREATE TABLE dosen (
  dosenID INT,
  namaDosen VARCHAR(100),
  nipDosen VARCHAR(30) UNIQUE,
  emailDosen VARCHAR(55) UNIQUE,
  password VARCHAR(20),
  CONSTRAINT PK_dosen PRIMARY KEY (dosenID)
);

-- Membuat Tabel Kelas
CREATE TABLE kelas (
  kelasID INT,
  namaKelas VARCHAR(100),
  tglKelas DATE,
  dosenID INT,
  CONSTRAINT PK_kelas PRIMARY KEY (kelasID),
  CONSTRAINT FK_kelas_dosen FOREIGN KEY (dosenID) REFERENCES dosen(dosenID)
);

-- Membuat Tabel Kehadiran
CREATE TABLE kehadiran (
  kehadiranID INT,
  mhsID INT,
  kelasID INT,
  tglKehadiran DATE,
  status VARCHAR(20),
  CONSTRAINT PK_kehadiran PRIMARY KEY (kehadiranID),
  CONSTRAINT FK_kehadiran_mahasiswa FOREIGN KEY (mhsID) REFERENCES mahasiswa(mhsID),
  CONSTRAINT FK_kehadiran_kelas FOREIGN KEY (kelasID) REFERENCES kelas(kelasID)
);

-- Menambahkan data Dosen
INSERT INTO dosen (dosenID, namaDosen, nipDosen, emailDosen, password)
VALUES
  (1, 'Dr. Budi Santoso', 'NIP123', 'dosen1@example.com', '123456'),
  (2, 'Prof. Dewi Arifah', 'NIP456', 'dosen2@example.com', '123456');

-- Menambahkan data Mahasiswa
INSERT INTO mahasiswa (mhsID, namaMhs, nimMhs, emailMhs, password)
VALUES
  (1, 'Ekasari Amalia', 'NIM123', 'mahasiswa1@example.com', '123456'),
  (2, 'Muhammad Raafi', 'NIM456', 'mahasiswa2@example.com', '123456');

-- Menambahkan data Administrator
INSERT INTO administrator (adminID, username, password)
VALUES
  (1, 'admin', '12345678');