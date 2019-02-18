-- SELECT * FROM Persons;
-- SELECT * FROM Magazines;
-- SELECT * FROM Subscriptions;

 SELECT Persons.Name,
        Magazines.Title 
   FROM Persons
   JOIN Subscriptions
     ON Persons.PersonId = Subscriptions.PersonId
   JOIN Magazines
     ON Subscriptions.MagazineId = Magazines.MagazineId;