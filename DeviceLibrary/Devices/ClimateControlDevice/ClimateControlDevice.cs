using System.Collections.Generic;

using DeviceLibrary.BaseDevices;
using DeviceLibrary.Interfaces;

namespace DeviceLibrary.Devices.ClimateControlDevice
{
    public class ClimateControlDevice : BaseDevice, IClimateDevice
    {
        public ClimateControlDevice() { }

        public override IEnumerable<ICommand> GetCommands() => new List<ICommand>
        {
            new CommandOne(this),
            new CommandTwo(this)
        };

        public void Cool()
        {
            //do something
        }
        
        public void Heat()
        {
            //do something
        }

    }
}
