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
}