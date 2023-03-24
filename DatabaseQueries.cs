using Npgsql;

namespace ConsoleApp1;

public static class DatabaseQueries
{
    public static string? GetStopName(short line, short trip, int databaseId)
    {
        using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1234;Database=vgzm");
        conn.Open();
        var command = new NpgsqlCommand("select rpad(substring(stop_name, 1, 30), 32, ' ') from line" + line + "trip" + trip + " where id=" + databaseId, conn);
        var output = command.ExecuteScalar();
        conn.Close();
        return "  " + (string)output!;
    }

    public static string? GetStopTime(short line, short trip, int databaseId)
    {
        using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1234;Database=vgzm");
        conn.Open();
        var command = new NpgsqlCommand("select stop_time from line" + line + "trip" + trip + " where id=" + databaseId, conn);
        var output = command.ExecuteScalar();
        conn.Close();
        return (string)output! + "  ";
    }

    public static byte GetHighestId(short line, short trip)
    {
        using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1234;Database=vgzm");
        conn.Open();
        var command = new NpgsqlCommand("select id from line" + line + "trip" + trip + " order by id desc limit 1", conn);
        var output = command.ExecuteScalar();
        conn.Close();
        return (byte)output!;
    }

    // Console.WriteLine("{0}{1}\n",output[0], output[1]);
    // File.AppendAllText("C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\one.txt", string.Format("{0}{1}", "  "+output[0], Environment.NewLine));
}