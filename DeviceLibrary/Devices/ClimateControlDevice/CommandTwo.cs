using DeviceLibrary.Interfaces;

namespace DeviceLibrary.Devices.ClimateControlDevice
{
    public class CommandTwo : ICommand
    {
        private IClimateDevice _receiver;

        public CommandTwo(IClimateDevice r)
        {
            this._receiver = r;
        }

        public void Execute() => this._receiver.Heat();

        public void Undo()
        {
        }
    }
}
