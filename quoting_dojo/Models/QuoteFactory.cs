using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using quoting_dojo.Models;

namespace quoting_dojo.Models
{
  public class QuoteFactory
  {
    private MySqlOptions _options;
    internal IDbConnection dbConnection
    { 
      get {
        return new MySqlConnection(_options.ConnectionString);
      } 
    }
    public List<Quote> AllQuotes = new List<Quote>();

    public QuoteFactory(IOptions<MySqlOptions> config)
    {
      _options = config.Value;
      FindAll(); 
    }

    public void FindAll()
    {
      var quotes = dbConnection.Query<Quote>("Select * from quotes");
      AllQuotes.Clear();
      foreach (Quote quote in quotes)
      {
        AllQuotes.Add(quote);
      }
    }

    public Quote FindByID(int id)
    {
      return dbConnection.Query<Quote>(
          @"
            SELECT * 
              FROM quotes 
              WHERE id = @Id
          ", 
        new { Id = id}).FirstOrDefault();
    }

    public void Add(Quote item)
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