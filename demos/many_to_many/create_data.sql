INSERT INTO Persons (Name) 
       VALUES ("Bugs Bunny"), 
              ("Elmer Fud"), 
              ("Wile E. Coyote"),
              ("Road Runner");

INSERT INTO Magazines (Title) 
       VALUES ("Acme Weekly"), 
              ("Cartoon Mechanics"),
              ("Cross Dressing Digest"),
              ("Rhotacism and You");

INSERT INTO Subscriptions (PersonId, MagazineId)
       VALUES (3, 1),
              (4, 2),
              (4, 1),
              (1, 3),
              (2, 4);