using MonoGraphics.ProcessManager.Model;
using ProcessManager.Interfaces;
using System.Collections.Generic;

namespace MonoGraphics.ProcessManager
{
    public class ProcessManager
    {
        private List<IProcess> processes = new List<IProcess>();

        public bool AddProcess(IProcess process, int priority)
        {
            if (process.Start())
            {
                //  processes.Add(new PrioritisedItem { Process = process, Priority = priority });
                processes.Insert(priority, process);
                return true;
            }

            return false;
        }

        public void Update(int time)
        {
            foreach (var process in processes)
            {
                process.Update(time);
            }
        }

        public void RemoveProcess(IProcess process)
        {
            process.End();
            processes.Remove(process);
        }

    }
}
