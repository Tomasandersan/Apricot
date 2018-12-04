using DeviceLibrary.Interfaces;

namespace DeviceLibrary.Devices.HumidifierControlDevice
{
    public class CommandOne : ICommand
    {
        private IHumidifierDevice _receiver;

        public CommandOne(IHumidifierDevice r)
        {
            this._receiver = r;
        }

        public void Execute() => this._receiver.Dry();

        public void Undo()
        {
        }
    }
}
