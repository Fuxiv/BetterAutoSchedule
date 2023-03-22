namespace ConsoleApp1;

public class ScheduleWriter
{
    public void WriteScheduleToFile(short d, string m, short line, short trip)
    {
        File.WriteAllText("C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\"+Utils.FileName(d,m,line,trip), Utils.ScheduleBeginning());
        for (int i = 1; i < DatabaseQueries.GetHighestId(line,trip); i++)
        {
            Random r = new Random();
            int randomArrivalSeconds = r.Next(0, 59);
            File.AppendAllText("C:\\Users\\Jackobe\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\NewDirectory1\\"+Utils.FileName(d,m,line,trip), DatabaseQueries.GetStopName(line,trip,i)+DatabaseQueries.GetStopTime(line,trip,i)+Utils.ArrivalTime(line,trip,i,randomArrivalSeconds)+Utils.ArrivalDiff(line,trip,i,randomArrivalSeconds)+Environment.NewLine);
        }
    }
}