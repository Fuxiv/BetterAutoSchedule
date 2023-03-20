using System.Data.SQLite;

namespace ConsoleApp1;

public class Asdf
{
    static SQLiteConnection CreateConnection()
    {
        SQLiteConnection sqliteConn;
        sqliteConn = new SQLiteConnection("Data Source=baza.db;Version=3;New=True;Compress=True;");
        try
        {
            sqliteConn.Open();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        return sqliteConn;
    }
    
    static void GetStop(SQLiteConnection conn)
    {
        SQLiteDataReader sqLiteDataReader;
        SQLiteCommand sqLiteCommand;
        sqLiteCommand = conn.CreateCommand();
        sqLiteCommand.CommandText = "select * from linia813";
        sqLiteDataReader = sqLiteCommand.ExecuteReader();
        while (sqLiteDataReader.Read())
        {
            string myreader = sqLiteDataReader.GetString(0);
            Console.WriteLine(myreader);
        }
    }
    
    public static void GetStopandTime()
    {
        GetStop(CreateConnection());
    }
}