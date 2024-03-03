namespace WorkflowEngineApp;

//Concrete implementation of the interface IActivity
public class Activity1 : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Executing Activity 1");
    }
}