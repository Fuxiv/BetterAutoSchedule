using Npgsql;
namespace ConsoleApp1;

public static class DatabaseQueries
{
    public static string? GetStopName(short line, short trip)
    {
        using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1234;Database=vgzm");
        conn.Open();
        var command = new NpgsqlCommand("select rpad(substring(stop_name, 1, 30), 32, ' ') from line"+line+"trip"+trip, conn);
        var output = command.ExecuteScalar();
        conn.Close();
        return (string)output!;
    }
    public static string? GetStopTime(short line, short trip)
    {
        using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1234;Database=vgzm");
        conn.Open();
        object? output = null;
        for (int i = 1; i < 5; i++)
        {
            var command = new NpgsqlCommand("select stop_time from line"+line+"trip"+trip+" where id="+i, conn);
            output = command.ExecuteScalar();
            Console.WriteLine(output);
        }
        conn.Close();
        return (string)output!;
    }
    // Console.WriteLine("{0}{1}\n",output[0], output[1]);
    // File.AppendAllText("C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\one.txt", string.Format("{0}{1}", "  "+output[0], Environment.NewLine));
}