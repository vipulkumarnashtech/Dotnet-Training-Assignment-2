namespace WorkflowEngineApp;

public class WorkflowEngine
{
    //Function that takes list of activities and run the Execute function on them
    public void Run(List<IActivity> workflow)
    {
        foreach (var activity in workflow)
        {
            activity.Execute();
        }
    }
}