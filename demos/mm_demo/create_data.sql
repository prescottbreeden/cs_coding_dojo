INSERT INTO Persons (Name)
       VALUES ("Bugs Bunny"),
              ("Elmer Fud"),
              ("Wile E. Coyote"),
              ("Road Runner");

INSERT INTO Magazines (Title)
       VALUES ("Looney Tunes Weekly"),
              ("Acme Daily Discounts"),
              ("Cartoon Physics"),
              ("Speech impediments and you"),
              ("Carrots Digest"),
              ("101 recipes for a road runner");

INSERT INTO Subscriptions (PersonId, MagazineId)
       VALUES (1, 5),
              (1, 1),
              (1, 3),
              (2, 4),
              (3, 2),
              (3, 6),
              (4, 3),
              (4, 4);