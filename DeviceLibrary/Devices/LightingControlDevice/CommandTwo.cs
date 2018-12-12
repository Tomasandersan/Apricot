using DeviceLibrary.Interfaces;

namespace DeviceLibrary.Devices.LightingControlDevice
{
    public class CommandTwo : ICommand
    {
        private ILightingDevice _receiver;

        public CommandTwo(ILightingDevice r)
        {
            this._receiver = r;
        }

        public void Execute() => this._receiver.ReduceBrightness();

        public void Undo()
        {
        }
    }
}
