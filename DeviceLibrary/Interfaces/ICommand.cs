namespace DeviceLibrary.Interfaces
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
