using System.Collections.Generic;

using DeviceLibrary.BaseDevices;
using DeviceLibrary.Interfaces;

namespace DeviceLibrary.Devices.LightingControlDevice
{
    public class LightingControlDevice : BaseDevice, ILightingDevice
    {
        public LightingControlDevice() { }

        public override IEnumerable<ICommand> GetCommands() => new List<ICommand>
        {
            new CommandOne(this),
            new CommandTwo(this)
        };
        
        public void IncreaseBrightness()
        {
            //do something
        }

        public void ReduceBrightness()
        {
            //do something
        }
    }
}
