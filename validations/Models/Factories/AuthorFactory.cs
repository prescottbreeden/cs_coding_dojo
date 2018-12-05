using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using validations.Models;

namespace validations.Factory
{
  public static class AuthorFactory
  {
    public static IEnumerable<Author> AllAuthors = new List<Author>();
    private static string connectionString;
    static AuthorFactory()
    {
      connectionString = "server=localhost;userid=trashpanda;password=rubberbabybuggybumpers;port=3306;database=quoting_dojo;SslMode=None";
    }
    internal static IDbConnection Connection
    {
      get
      {
        return new MySqlConnection(connectionString);
      }
    }
    public static void NewAuthor(Author user)
    {
      using (IDbConnection dbConnection = Connection)
      {
        string query = @"
          INSERT INTO authors (name, created_at, updated_at) 
          VALUES (@Name, NOW(), NOW())
        ";
        dbConnection.Open();
        dbConnection.Execute(query, user);
      }
    }
    public static IEnumerable<Author> FindAll()
    {
      using (IDbConnection dbConnection = Connection)
      {
        dbConnection.Open();
        return dbConnection.Query<Author>("SELECT * FROM authors");
      }
    }
    public static Author FindByID(int id)
    {
      using (IDbConnection dbConnection = Connection)
      {
        dbConnection.Open();
        return dbConnection.Query<Author>(
          "SELECT * FROM authors WHERE id = @author_id", 
          new { author_id = id }).FirstOrDefault();
      }
    }

  }
}