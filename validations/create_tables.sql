-- CREATE SCHEMA

CREATE SCHEMA IF NOT EXISTS quoting_dojo
DEFAULT CHARACTER SET utf8;

USE quoting_dojo;

-- CREATE TABLES

CREATE TABLE IF NOT EXISTS authors (
  author_id       INTEGER       NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name            VARCHAR(50)   NOT NULL,
  created_at      DATETIME      NOT NULL  DEFAULT NOW(),
  updated_at      DATETIME      NOT NULL  DEFAULT NOW() ON UPDATE NOW()
);

CREATE TABLE IF NOT EXISTS quotes (
  quote_id        INTEGER       NOT NULL AUTO_INCREMENT PRIMARY KEY,
  author_id       INTEGER       NOT NULL,
  content         VARCHAR(90)   NOT NULL,
  created_at      DATETIME      NOT NULL  DEFAULT NOW(),
  updated_at      DATETIME      NOT NULL  DEFAULT NOW() ON UPDATE NOW(),

  FOREIGN KEY (author_id)
    REFERENCES authors(author_id)
);

-- INSERT DATA

INSERT INTO authors (name)
VALUES  ('Chuck Norris'),
        ('Bugs Bunny'),
        ('Elmer Fud')
;

INSERT INTO quotes (content, author_id)
VALUES  ("I don't sleep... I wait...", 1),
        ("What's up doc?", 2),
        ("Wabbit Twacks!", 3)
;