DROP SCHEMA IF EXISTS todos_api;
CREATE SCHEMA todos_api;
USE todos_api;

CREATE TABLE IF NOT EXISTS Todos(
  todo_id   INTEGER       NOT NULL  AUTO_INCREMENT PRIMARY KEY,
  title     VARCHAR(255)  NOT NULL,
  is_done   BOOLEAN       NOT NULL  DEFAULT 0
);

INSERT INTO Todos (title)
VALUES ('rubber'),
        ('baby'),
        ('buggy'),
        ('bumpers');