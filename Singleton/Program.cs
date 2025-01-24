
using Singleton;

Console.WriteLine("Hello, World!");


var tasks = new Task[5];

for (int i = 0; i < tasks.Length; i++)
{
    int taskNumber = i + 1;
    tasks[i] = Task.Run(() => LogMessage(taskNumber));
}

await Task.WhenAll(tasks);

Console.ReadKey();

static void LogMessage(int taskNumber)
{
    for (int i = 0; i < 10; i++)
    {
        Logger.Instance.LogMessage(DateTime.Now, taskNumber.ToString());
        Task.Delay(1000);
    }
}