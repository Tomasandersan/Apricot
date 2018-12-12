using System.Collections.Generic;

using DeviceLibrary.BaseDevices;
using DeviceLibrary.Interfaces;

namespace DeviceLibrary.Devices.HumidifierControlDevice
{
    public class HumidifierControlDevice : BaseDevice, IHumidifierDevice
    {
        public HumidifierControlDevice() { }
        
        public override IEnumerable<ICommand> GetCommands() => new List<ICommand>
        {
            new CommandOne(this),
            new CommandTwo(this)
        };

        public void Dry()
        {
            //do something
        }

        public void Humidify()
        {
            //do something
        }
    }
}
