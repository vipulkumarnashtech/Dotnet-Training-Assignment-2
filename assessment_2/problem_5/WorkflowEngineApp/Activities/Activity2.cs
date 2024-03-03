namespace WorkflowEngineApp;

//Concrete implementation of the interface IActivity
public class Activity2 : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Executing Activity 2");
    }
}