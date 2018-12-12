using System.Collections.Generic;
using System.Linq;

using DeviceLibrary.Interfaces;
using DeviceLibrary.Enum;

namespace DeviceLibrary.BaseDevices
{
    public class BaseHubDevice : IHub
    {
        private readonly List<IBaseDevice> _devices = new List<IBaseDevice>();
        
        public BaseHubDevice() { }

        public virtual void RegisterDevice(IBaseDevice device) => this._devices.Add(device);
        
        public virtual Status GetDeviceStatus(IBaseDevice device) => this._devices.FirstOrDefault(x => x.Equals(device)).GetStatus();
        
        public virtual void RestartDevice(IBaseDevice device) => this._devices.FirstOrDefault(x => x.Equals(device)).Restart();

        public virtual void UpdateDeviceParamiters(IBaseDevice device, IEnumerable<string> arrayParams) => this._devices.FirstOrDefault(x => x.Equals(device)).UpdateParamiters(arrayParams);

        public virtual void ExecuteDeviceCommands(IBaseDevice device) => this._devices.FirstOrDefault(x => x.Equals(device)).GetCommands().ToList().ForEach(x => x.Execute());
    }
}
