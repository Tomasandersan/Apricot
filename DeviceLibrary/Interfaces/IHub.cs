using System.Collections.Generic;

using DeviceLibrary.Enum;

namespace DeviceLibrary.Interfaces
{
    public interface IHub
    {
        void RegisterDevice(IBaseDevice device);

        void RestartDevice(IBaseDevice device);

        void UpdateDeviceParamiters(IBaseDevice device, IEnumerable<string> arrayParams);
        
        Status GetDeviceStatus(IBaseDevice device);

        void ExecuteDeviceCommands(IBaseDevice device);
    }
}
