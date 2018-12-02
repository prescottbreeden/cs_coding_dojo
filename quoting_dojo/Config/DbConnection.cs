using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace quoting_dojo.DbConfig
{
  public static class DbConnection
  {
    static string server = "localhost";
    static string db = "quoting_dojo_cs";
    static string port = "3306";
    static string user = "trashpanda";
    static string pw = "rubberbabybuggybumpers";
    internal static IDbConnection DatabaseConnection 
    {
      get {
        return new MySqlConnection($"Server={server};Port={port};Database={db};UserID={user};Password={pw};SslMode=None");
      }
    }
  }
}