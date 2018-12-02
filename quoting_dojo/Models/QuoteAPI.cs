using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using quoting_dojo.DbConfig;
using quoting_dojo.Models;

namespace quoting_dojo.Models
{
  public static class QuoteAPI
  {
    public static List<Quote> AllQuotes = new List<Quote>();
    private static IDbConnection dbConnection = DbConnection.DatabaseConnection;

    static QuoteAPI()
    {
      FindAll(); 
    }
    public static void FindAll()
    {
      var quotes = dbConnection.Query<Quote>("Select * from quotes");
      AllQuotes.Clear();
      foreach (Quote quote in quotes)
      {
        AllQuotes.Add(quote);
      }
    }

    public static Quote FindByID(int id)
    {
      return dbConnection.Query<Quote>(
          @"
            SELECT * 
              FROM quotes 
              WHERE id = @Id
          ", 
        new { Id = id}).FirstOrDefault();
    }

    public static void Add(Quote item)
    {
      AllQuotes.Add(item);
      string query = @"
        INSERT INTO quotes (content, author, created_at, updated_at)
        VALUES (@Quote, @Author, NOW(), NOW())";
      dbConnection.Open();
      dbConnection.Execute(query, item);
    }
  }
}