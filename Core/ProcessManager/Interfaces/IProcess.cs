namespace Core.ProcessManager.Interfaces
{
    public interface IProcess
    {
        bool Start();

        void Update(int number);

        void End();

    }
}
