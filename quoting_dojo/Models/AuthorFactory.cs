using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using quoting_dojo.DbConfig;
using quoting_dojo.Models;

namespace quoting_dojo.Models
{
  public static class AuthorFactory
  {
    public static List<Author> AllAuthors = new List<Author>();
    private static IDbConnection dbConnection = DbConnection.DatabaseConnection;

    static AuthorFactory()
    {
      FindAll(); 
    }
    public static void FindAll()
    {
      dbConnection.Open();
      var authors = dbConnection.Query<Author>("Select * from authors");
      foreach (Author auth in authors)
      {
        AllAuthors.Add(auth);
      }
    }

    public static Author FindByID(int id)
    {
      dbConnection.Open();
      return dbConnection.Query<Author>(
          @"
            SELECT * 
              FROM authors 
              WHERE id = @Id
          ", 
        new { Id = id}).FirstOrDefault();
    }

    public static void Add(Author item)
    {
      string query = @"
      INSERT INTO authors (name, quote, created_at, updated_at)
      VALUES (@Name, @Quote, NOW(), NOW())";
      dbConnection.Open();
      dbConnection.Execute(query, item);
    }
  }
}