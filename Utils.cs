namespace ConsoleApp1;

public class Utils
{
    public static string ScheduleBeginning()
    {
        var scheduleBeginning = File.ReadAllText("C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\beginning.txt");
        return scheduleBeginning;
    }

    public static string FileName(short d, string m, short line, short trip)
    {
        return d + "-" + m + "-" + line + "-" + trip + ".txt";
    }

    public static string ArrivalTime(short line, short trip, int id, int random)
    {
        if (random < 10)
        {
            var randomString = '0' + random.ToString();
            var stopTimeBase = DatabaseQueries.GetStopTime(line, trip, id)!.Substring(0, 6);
            return stopTimeBase + randomString + "  ";
        }
        else
        {
            var stopTimeBase = DatabaseQueries.GetStopTime(line, trip, id)!.Substring(0, 6);
            return stopTimeBase + random + "  ";
        }
    }

    public static string ArrivalDiff(int random)
    {
        if (random < 10)
        {
            var randomString = '0' + random.ToString();
            return "00:00:" + randomString + "  ";
        }

        return "00:00:" + random + "  ";
    }

    public static string DepartureTime(short line, short trip, int id, int random)
    {
        var stopTimeBase = DatabaseQueries.GetStopTime(line, trip, id)!.Substring(0, 6);
        return stopTimeBase + random + "  ";
    }

    public static string DepartureDiff(int random)
    {
        return "00:00:" + random + "  ";
    }
}