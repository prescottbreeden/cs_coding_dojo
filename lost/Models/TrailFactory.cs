using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using lost.Models;
 
namespace lost.Factory
{
    public class TrailFactory
    {
        private string connectionString;
        public TrailFactory()
        {
            connectionString = "server=localhost;userid=trashpanda;password=rubberbabybuggybumpers;port=3306;database=lost;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }
 
        public void Add(Trail item)
        {
            using (IDbConnection dbConnection = Connection) {
                string query =  @"

  INSERT INTO trails (name, description, length, elevation, latitude, longitude) 
  VALUES (@Name, @Description, @Length, @Elevation, @Latitude, @Longitude)
  
  ";
                dbConnection.Open();
                dbConnection.Execute(query, item);
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

    }
}
