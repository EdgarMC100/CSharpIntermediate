using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLastExercises
{

    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (ITask task in workFlow.GetTasks())
            {
                try
                {
                    task.Execute(); 
                }
                catch (System.Exception)
                {

                    throw;
                }
                
            }
        }


    }
}
