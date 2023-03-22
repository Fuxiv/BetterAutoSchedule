using Npgsql.Internal.TypeHandlers.GeometricHandlers;

namespace ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Utils
{
    public static string ScheduleBeginning()
    {
        string scheduleBeginning = File.ReadAllText("C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\beginning.txt");
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
            string randomString = '0' + random.ToString();
            string stopTimeBase = DatabaseQueries.GetStopTime(line, trip, id)!.Substring(0, 6); 
            return stopTimeBase + randomString + "  ";
        }
        else
        {
            string stopTimeBase = DatabaseQueries.GetStopTime(line, trip, id)!.Substring(0, 6); 
            return stopTimeBase + random + "  ";
        }
    }
    public static string ArrivalDiff(short line, short trip, int id, int random)
    {
        if (random<10)
        {
            string randomString = '0' + random.ToString();
            return "00:00:" + randomString;
        }
        else
        {
            return "00:00:" + random;
        }
    }
}