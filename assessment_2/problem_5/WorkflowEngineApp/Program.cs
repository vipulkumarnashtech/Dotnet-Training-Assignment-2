using System.Collections.Generic;

namespace WorkflowEngineApp;

class Program
{
    static void Main(string[] args)
    {
        // Create a workflow
        var workflow = new List<IActivity>
        {
            new Activity1(),
            new Activity2(),
            new Activity3(),
            new Activity1()
        };

        // Create a workflow engine and run the workflow
        WorkflowEngine engine = new WorkflowEngine();
        engine.Run(workflow);
    }
}
