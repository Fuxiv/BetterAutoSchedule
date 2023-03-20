namespace ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Utils
{
    static SQLiteConnection CreateConnection()
    {
        SQLiteConnection sqlite_conn;
        sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
        return sqlite_conn;
    }
}