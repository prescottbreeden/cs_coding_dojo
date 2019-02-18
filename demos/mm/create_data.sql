INSERT INTO Persons (Name)
       VALUES ("Bugs Bunny"),
              ("Elmer Fud"),
              ("Road Runner"),
              ("Wile E. Coyote");

INSERT INTO Magazines (Title)
       VALUES ("Carrot Digest"),
              ("Rhotacism and You"),
              ("Acme Weekly Discounts"),
              ("Cartoon Mechanics");

INSERT INTO Subscriptions (PersonId, MagazineId)
       VALUES (1, 1),
              (2, 2),
              (3, 3),
              (3, 4),
              (4, 4);