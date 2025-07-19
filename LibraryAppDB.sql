
USE libraryapp;

CREATE TABLE IF NOT EXISTS users (id INT AUTO_INCREMENT PRIMARY KEY, mail VARCHAR(50) UNIQUE, pass VARCHAR(50));

CREATE TABLE IF NOT EXISTS personels (id INT AUTO_INCREMENT PRIMARY KEY, mail VARCHAR(50) UNIQUE, pass VARCHAR(50));

CREATE TABLE IF NOT EXISTS books (id INT AUTO_INCREMENT PRIMARY KEY, bookName VARCHAR(50), author VARCHAR(50), publishYear YEAR, revise BOOL, revisedBy VARCHAR(50));

USE libraryapp;
INSERT INTO users (mail, pass) VALUES
('fatmanur@example.com', 'password1'),
('irem@example.com', 'password2'),
('sarenur@example.com', 'password3'),
('melike@example.com', 'password4');

USE libraryapp;
INSERT INTO personels (mail, pass) VALUES
('personel1@example.com', 'staffpass1'),
('personel2@example.com', 'staffpass2'),
('personel3@example.com', 'staffpass3');

use libraryapp;
INSERT INTO books (bookName, author, publishYear, revise, revisedBy) VALUES
('Dönüsüm', 'Franz Kafka', 1915 , 1, 'fatmanur@example.com'),
('Satranc', 'Stafan Zweig', 1943 , 0, NULL),
('Ask', 'Elif Safak', 2009 , 1 , 'sarenur@example.com'),
('Cavdar Tarlasında Cocuklar', 'J. D. Salinger ', 1951, 0, NULL),
('Kuyucuklı Yusuf', 'Sabahattin Ali', 1937 , 1, 'irem@example.com'),
('Acımak', 'Resat Nuri Guntekin', 1928, 0, NULL),
('Anna Kareinna', 'Lev Tolstoy', 1977, 1, 'melike@example.com'),
('Gazap Uzumleri', 'John Steinbeck', 1939, 0, NULL),
('Calıkusu', 'Resat Nuri Guntekin',1922 , 0, NULL),
('Sol Ayagım', 'Christy Brown', 1954, 1, 'fatmanur@example.com'),
('Tutunamayanlar', 'Oguz Atay', 1971, 0, NULL),
('Kurk Mantolu Madonna', 'Sabahattin Ali', 1943, 1,'sarenur@example.com'),
('Eylul', 'Mehmet Rauf', 1907, 0, NULL),
('Dogu Ekspresinde Cinayet', 'Agatha Christie', 1934, 1, 'irem@example.com'),
('Bulbulu Oldurmek', 'Harper Lee', 1965, 0, NULL);