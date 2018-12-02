-- CREATE SCHEMA

CREATE SCHEMA IF NOT EXISTS quoting_dojo_cs
DEFAULT CHARACTER SET utf8;

USE quoting_dojo_cs;

-- CREATE QUOTE TABLE

CREATE TABLE IF NOT EXISTS quotes (
  quote_id      INTEGER     NOT NULL  AUTO_INCREMENT PRIMARY KEY,
  author        VARCHAR(50) NOT NULL,
  content       TEXT        NOT NULL,
  created_date  DATETIME    NOT NULL  DEFAULT NOW(),
  updated_date  DATETIME    NOT NULL  DEFAULT NOW() ON UPDATE NOW()
);

-- STARTING DATA FOR AUTHORS

INSERT INTO quotes (author, content)
VALUES  ("Robert Mueller", "I'm commin to getcha..."),
        ("Stephen Colbert", "Huge treason fans in the audience tonight...")
;