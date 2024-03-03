namespace WorkflowEngineApp;

//Concrete implementation of the interface IActivity
public class Activity3 : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Executing Activity 3");
    }
}