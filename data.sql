CREATE DATABASE IF NOT EXISTS cribplan;


USE cribplan;


CREATE TABLE IF NOT EXISTS admin (
    username VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,
    PRIMARY KEY (username)
);

 


INSERT INTO admin (username, password) VALUES ('wade', '123456789');




CREATE TABLE IF NOT EXISTS users (
    username VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(255) NOT NULL,
    name VARCHAR(100),
    PRIMARY KEY (username)
);

 




INSERT INTO users (username, email, password, name) VALUES ('user1', 'user1@example.com', 'pass1', 'User One');
INSERT INTO users (username, email, password, name) VALUES ('user2', 'user2@example.com', 'pass2', 'User Two');
INSERT INTO users (username, email, password, name) VALUES ('user3', 'user3@example.com', 'pass3', 'User Three');
INSERT INTO users (username, email, password, name) VALUES ('user4', 'user4@example.com', 'pass4', 'User Four');




CREATE TABLE IF NOT EXISTS expenses ( expense_id INT AUTO_INCREMENT PRIMARY KEY, expense_type ENUM('normal', 'custom') NOT NULL, expense_name VARCHAR(100) NOT NULL, paid_by VARCHAR(255) NULL, username VARCHAR(50) NOT NULL, date DATE NOT NULL, FOREIGN KEY (username) REFERENCES users(username) );


INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (1,'normal', 'Book Purchase', NULL, 'user3', '2024-03-06');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (2,'custom', 'Tech Gadgets', 'user2', 'user3', '2024-03-07');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (3,'normal', 'Grocery Shopping', NULL, 'user4', '2024-03-08');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (4,'custom', 'Birthday Party', 'user1,user3', 'user4', '2024-03-09');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (5,'normal', 'Car Insurance', NULL, 'user1', '2024-03-10');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (6,'custom', 'Home Decor', 'user2,user4', 'user1', '2024-03-11');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (7,'normal', 'Internet Bill', NULL, 'user4', '2024-02-28');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (8,'custom', 'Concert Tickets', 'user1', 'user4', '2024-03-01');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (9,'normal', 'Electricity Bill', NULL, 'user1', '2024-03-02');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (10,'custom', 'Gym Membership', 'user2,user3', 'user4', '2024-03-03');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (11,'normal', 'Water Bill', NULL, 'user2', '2024-03-04');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (12,'custom', 'Gift Purchase', 'user1,user4', 'user2', '2024-03-05');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (13,'normal', 'Groceries', NULL, 'user1', '2024-02-22');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (14,'custom', 'Dinner', 'user2', 'user1', '2024-02-23');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES(15,'normal', 'Utilities', NULL, 'user2', '2024-02-24');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (16,'custom', 'Movie Tickets', 'user1,user3', 'user2', '2024-02-25');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (17,'normal', 'Rent', NULL, 'user3', '2024-02-26');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (18,'custom', 'Car Repair', 'user4', 'user3', '2024-02-27');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (19,'normal', 'Subscription Fee', NULL, 'user2', '2024-02-16');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (20,'custom', 'Travel Expenses', 'user3', 'user2', '2024-02-17');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (21,'normal', 'Mobile Bill', NULL, 'user3', '2024-02-18');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (22,'custom', 'Workshop Enrollment', 'user1,user4', 'user3', '2024-02-19');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (23,'normal', 'Health Insurance', NULL, 'user4', '2024-02-20');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (24,'custom', 'Online Course', 'user2,user3', 'user4', '2024-02-21');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (25,'normal', 'Book Purchase', NULL, 'user3', '2024-02-10');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (26,'custom', 'Tech Gadgets', 'user2', 'user3', '2024-02-11');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (27,'normal', 'Grocery Shopping', NULL, 'user4', '2024-02-12');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (28,'custom', 'Birthday Party', 'user1,user3', 'user4', '2024-02-13');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (29,'normal', 'Car Insurance', NULL, 'user1', '2024-02-14');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (30,'custom', 'Home Decor', 'user2,user4', 'user1', '2024-02-15');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (31,'normal', 'Internet Bill', NULL, 'user4', '2024-02-04');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (32,'custom', 'Concert Tickets', 'user1', 'user4', '2024-02-05');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (33,'normal', 'Electricity Bill', NULL, 'user1', '2024-02-06');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (34,'custom', 'Gym Membership', 'user2,user3', 'user4', '2024-02-07');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (35,'normal', 'Water Bill', NULL, 'user2', '2024-02-08');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (36,'custom', 'Gift Purchase', 'user1,user4', 'user2', '2024-02-09');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (37,'normal', 'Groceries', NULL, 'user1', '2024-01-29');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (38,'custom', 'Dinner', 'user2', 'user1', '2024-01-30');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (39,'normal', 'Utilities', NULL, 'user2', '2024-01-31');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (40,'custom', 'Movie Tickets', 'user1,user3', 'user2', '2024-02-01');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (41,'normal', 'Rent', NULL, 'user3', '2024-02-02');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (42,'custom', 'Car Repair', 'user4', 'user3', '2024-02-03');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (43,'normal', 'Subscription Fee', NULL, 'user2', '2024-01-23');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (44,'custom', 'Travel Expenses', 'user3', 'user2', '2024-01-24');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (45,'normal', 'Mobile Bill', NULL, 'user3', '2024-01-25');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (46,'custom', 'Workshop Enrollment', 'user1,user4', 'user3', '2024-01-26');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (47,'normal', 'Health Insurance', NULL, 'user4', '2024-01-27');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (48,'custom', 'Online Course', 'user2,user3', 'user4', '2024-01-28');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (49,'normal', 'Internet Bill', NULL, 'user4', '2024-01-11');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (50,'custom', 'Concert Tickets', 'user1', 'user4', '2024-01-12');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (51,'normal', 'Electricity Bill', NULL, 'user1', '2024-01-13');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (52,'custom', 'Gym Membership', 'user2,user3', 'user4', '2024-01-14');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (53,'normal', 'Water Bill', NULL, 'user2', '2024-01-15');
INSERT INTO expenses (expense_id, expense_type, expense_name, paid_by, username, date) VALUES (54,'custom', 'Gift Purchase', 'user1,user4', 'user2', '2024-01-16');