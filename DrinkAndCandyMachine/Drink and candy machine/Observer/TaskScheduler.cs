namespace DrinkAndCandyMachine.Drink_and_candy_machine.Observer;

internal class TaskScheduler
{
    private static TaskScheduler _instance = new();
    private readonly List<System.Threading.Timer> timers = new();
    public static TaskScheduler Instance => _instance ??= new TaskScheduler();

    public void ScheduleTask(int hour, int min, double intervalInHour, Action task)
    {
        DateTime now = DateTime.Now;
        DateTime firstRun = new(now.Year, now.Month, now.Day, hour, min, 0, 0);
        if (now > firstRun)
        {
            firstRun = firstRun.AddDays(1);
        }

        TimeSpan timeToGo = firstRun - now;
        if (timeToGo <= TimeSpan.Zero)
        {
            timeToGo = TimeSpan.Zero;
        }

        var timer = new System.Threading.Timer(x =>
        {
            task.Invoke();
        }, null, timeToGo, TimeSpan.FromHours(intervalInHour));

        timers.Add(timer);
    }
}

