 SELECT Persons.Name, Magazines.Title
   FROM Persons
   JOIN Subscriptions
     ON Subscriptions.PersonId = Persons.PersonId
   JOIN Magazines
     ON Subscriptions.MagazineID = Magazines.MagazineId;