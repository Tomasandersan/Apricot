using DeviceLibrary.Interfaces;

namespace DeviceLibrary.Devices.LightingControlDevice
{
    public class CommandOne : ICommand
    {
        private ILightingDevice _receiver;

        public CommandOne(ILightingDevice r)
        {
            this._receiver = r;
        }

        public void Execute() => this._receiver.IncreaseBrightness();

        public void Undo()
        {
        }
    }
}
