using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using validations.Models;

namespace validations.Factory
{
  public static class QuoteFactory
  {
    private static string connectionString;
    static QuoteFactory()
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
    public static void NewQuote(Quote author)
    {
      using (IDbConnection dbConnection = Connection)
      {
        string query = @"
          INSERT INTO quotes (content, author_id, created_at, updated_at) 
          VALUES (@Content, @Author, NOW(), NOW())
        ";
        dbConnection.Open();
        dbConnection.Execute(query, author);
      }
    }
    public static IEnumerable<Quote> FindAll()
    {
      using (IDbConnection dbConnection = Connection)
      {
        dbConnection.Open();
        string query = @"
           SELECT *
             FROM quotes as q
             JOIN authors as a
                  ON a.author_id = q.author_id
          ";

        var all_quotes = dbConnection.Query<Quote, Author, Quote>(query, 
          (q, a) => { q.author = a; return q; }, splitOn: "author_id");

        return all_quotes;
      }
    }
    public static Quote FindByID(int id)
    {
      using (IDbConnection dbConnection = Connection)
      {
        dbConnection.Open();
        return dbConnection.Query<Quote>(
          "SELECT * FROM quotes WHERE id = @Id", 
          new { Id = id }).FirstOrDefault();
      }
    }

  }
}