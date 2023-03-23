using ConsoleApp1;

short line = short.Parse(Console.ReadLine());
short trip = short.Parse(Console.ReadLine());
var scheduleWriter = new ScheduleWriter();

for (int i = trip; i > 0; i++)
    {
        try
        {
        scheduleWriter.WriteScheduleToFile(22,"03", line,(short)i);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            i = -1;
        }
    }
