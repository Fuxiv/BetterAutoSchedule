using ConsoleApp1;

var line = short.Parse(Console.ReadLine());
var trip = short.Parse(Console.ReadLine());
var scheduleWriter = new ScheduleWriter();

for (var i = trip; true; i++)
    try
    {
        scheduleWriter.WriteScheduleToFile(22, "03", line, i);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        break;
    }