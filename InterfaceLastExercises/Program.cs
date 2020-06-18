using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLastExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            workflow.Add(new DbStatus());
            workflow.Add(new EmailService());
            workflow.Add(new UploadVideoActivity());
            var workflowengine = new WorkFlowEngine();
            workflowengine.Run(workflow);
        }
    }
}
