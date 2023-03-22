using ConsoleApp1;

short line = 813;
short trip = 101;
Console.WriteLine(DatabaseQueries.GetStopName(line,trip));
Console.WriteLine(DatabaseQueries.GetStopTime(line,trip));
Utils.ScheduleBeginning();