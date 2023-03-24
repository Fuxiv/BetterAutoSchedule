using Ardalis.Extensions.StringManipulation;

namespace ConsoleApp1;

public class ScheduleWriter
{
    public void WriteScheduleToFile(short d, string m, short line, short trip)
    {
        var highestId = DatabaseQueries.GetHighestId(line, trip);
        File.WriteAllText("C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\" + Utils.FileName(d, m, line, trip), Utils.ScheduleBeginning());
        for (var i = 1; i < highestId; i++)
        {
            var r = new Random();
            var randomArrivalSeconds = r.Next(0, 43);
            var randomDepartureSeconds = r.Next(15, 59);
            if (randomDepartureSeconds < randomArrivalSeconds) randomArrivalSeconds = r.Next(0, randomDepartureSeconds - 10);
            if (i == 1)
                File.AppendAllText("C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\" + Utils.FileName(d, m, line, trip),
                    DatabaseQueries.GetStopName(line, trip, i)
                    + " ".Repeat(30)
                    + DatabaseQueries.GetStopTime(line, trip, i) + Utils.DepartureTime(line, trip, i, randomDepartureSeconds) + Utils.DepartureDiff(randomDepartureSeconds)
                    + "ok"
                    + Environment.NewLine);
            else if (i == DatabaseQueries.GetHighestId(line, trip) - 1)
                File.AppendAllText("C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\" + Utils.FileName(d, m, line, trip),
                    DatabaseQueries.GetStopName(line, trip, i) + DatabaseQueries.GetStopTime(line, trip, i)
                                                               + Utils.ArrivalTime(line, trip, i, randomArrivalSeconds) + Utils.ArrivalDiff(randomArrivalSeconds)
                                                               + " ".Repeat(30)
                                                               + "ok"
                                                               + Environment.NewLine);
            else
                File.AppendAllText(
                    "C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\" +
                    Utils.FileName(d, m, line, trip),
                    DatabaseQueries.GetStopName(line, trip, i) + DatabaseQueries.GetStopTime(line, trip, i)
                                                               + Utils.ArrivalTime(line, trip, i,
                                                                   randomArrivalSeconds) +
                                                               Utils.ArrivalDiff(randomArrivalSeconds)
                                                               + DatabaseQueries.GetStopTime(line, trip, i) +
                                                               Utils.DepartureTime(line, trip, i,
                                                                   randomDepartureSeconds) +
                                                               Utils.DepartureDiff(randomDepartureSeconds)
                                                               + "ok"
                                                               + Environment.NewLine);
        }
    }
}