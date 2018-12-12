using DeviceLibrary.Interfaces;

namespace DeviceLibrary.Devices.HumidifierControlDevice
{
    public class CommandTwo : ICommand
    {
        private IHumidifierDevice _receiver;

        public CommandTwo(IHumidifierDevice r)
        {
            this._receiver = r;
        }

        public void Execute() => this._receiver.Humidify();

        public void Undo()
        {
        }
    }
}
