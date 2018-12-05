-- CREATE SCHEMA

CREATE SCHEMA IF NOT EXISTS lost
DEFAULT CHARACTER SET utf8;

USE lost;

-- CREATE TABLES

CREATE TABLE IF NOT EXISTS trails (
  trail_id    INTEGER       NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name        VARCHAR(50)   NOT NULL,
  description VARCHAR(255)  NOT NULL,
  length      FLOAT(2)      NOT NULL,
  elevation   INTEGER       NOT NULL,
  latitude    VARCHAR(20)   NOT NULL,
  longitude   VARCHAR(20)   NOT NULL
);

-- STARTING DATA
INSERT INTO trails (name, description, length, elevation, latitude, longitude)
VALUES  ('Mailbox', 'Not a mailbox', 8.2, 5500, '65.1234 N', '180.1234 W');
