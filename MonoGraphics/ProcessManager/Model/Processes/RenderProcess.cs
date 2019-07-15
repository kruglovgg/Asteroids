using MonoGraphics.ProcessManager.Interfaces;
using ProcessManager.Interfaces;
using System.Collections.Generic;

namespace MonoGraphics.ProcessManager.Model.Processes
{
    public class RenderProcess : IProcess
    {
        private List<IRenderable> targets = new List<IRenderable>();
        public bool Start()
        {
            return true;
        }

        public void Update(int time)
        {
            foreach (var target in targets)
            {
                target.Render();
            }
        }

        public void End()
        {
            //Empty
        }
    }
}
