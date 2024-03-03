namespace StopwatchSimulator;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Enter 'start' to start the stopwatch, 'stop' to stop it, or 'exit' to quit:");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "start":
                    try
                    {
                        stopwatch.Start();
                        Console.WriteLine("Stopwatch started.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "stop":
                    try
                    {
                        stopwatch.Stop();
                        Console.WriteLine("Stopwatch stopped. Duration: " + stopwatch.GetDuration());
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "exit":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}