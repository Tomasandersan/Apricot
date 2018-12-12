using DeviceLibrary.Interfaces;

namespace DeviceLibrary.Devices.ClimateControlDevice
{
    public class CommandOne : ICommand
    {
        private IClimateDevice _receiver;

        public CommandOne(IClimateDevice r)
        {
            this._receiver = r;
        }

        public void Execute() => this._receiver.Cool();

        public void Undo()
        {
        }
    }
}
