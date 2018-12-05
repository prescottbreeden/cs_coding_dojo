-- CREATE SCHEMA

CREATE SCHEMA IF NOT EXISTS lostinthewoods
DEFAULT CHARACTER SET utf8;

USE lostinthewoods;

-- CREATE TRAIL TABLE

CREATE TABLE IF NOT EXISTS trails (
  trail_id    INTEGER       NOT NULL  AUTO_INCREMENT PRIMARY KEY,
  name        VARCHAR(50)   NOT NULL,
  description VARCHAR(255)  NULL,
  length      FLOAT(1)      NOT NULL,
  elevation   INTEGER       NOT NULL,
  latitude    VARCHAR(20)   NOT NULL,
  longitude   VARCHAR(20)   NOT NULL
);

-- STARTING DATA FOR TRAILS

INSERT INTO trails (name, description, length, elevation, latitude, longitude)
VALUES  ("mailbox", "yay!", "4.2", 4000, "47.4624 N", "121.6393 W")
;