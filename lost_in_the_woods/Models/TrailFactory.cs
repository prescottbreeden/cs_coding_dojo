using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using lost_in_the_woods.Models;

namespace lost_in_the_woods.Factory
{
  public class TrailFactory
  {
    private string connectionString;
    public TrailFactory()
    {
      connectionString = "server=localhost;userid=trashpanda;password=rubberbabybuggybumpers;port=3306;database=lostinthewoods;SslMode=None";
    }
    internal IDbConnection Connection
    {
      get
      {
        return new MySqlConnection(connectionString);
      }
    }

    public IEnumerable<Trail> FindAll()
    {
      using (IDbConnection dbConnection = Connection)
      {
        dbConnection.Open();
        return dbConnection.Query<Trail>("SELECT * FROM trails");
      }
    }
    public void Add(Trail item)
    {
      using (IDbConnection dbConnection = Connection)
      {
        string query = @"
                  INSERT INTO trails 
                         (name, length, elevation, description, latitude, longitude) 
                  VALUES (@Name, @Length, @Elevation, @Description, @Latitude, @Longitude)
                ";
        dbConnection.Open();
        dbConnection.Execute(query, item);
      }
    }
  }
}
