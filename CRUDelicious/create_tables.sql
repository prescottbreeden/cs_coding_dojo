-- Do yo thang
DROP SCHEMA crudelicious;

CREATE SCHEMA crudelicious
CHARACTER SET utf8;

USE crudelicious;

CREATE TABLE dishes (
  dish_id     INTEGER     NOT NULL  AUTO_INCREMENT PRIMARY KEY,
  name        VARCHAR(45) NOT NULL,
  chef        VARCHAR(45) NOT NULL,
  tastiness   INTEGER(11) NOT NULL,
  calories    INTEGER(11) NOT NULL,
  description TEXT        NOT NULL,
  created_at  DATETIME    NOT NULL  DEFAULT NOW(),
  updated_at  DATETIME    NOT NULL  DEFAULT NOW()   ON UPDATE NOW()
);

-- INSERT DATA

INSERT INTO dishes (name, chef, tastiness, calories, description)
VALUES  ('Tastee Burger', 'Moose Phillips', 8, 800, 'Have to eat it to believe it!')
;