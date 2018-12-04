using DeviceLibrary.Devices.ClimateControlDevice;
using DeviceLibrary.Devices.HumidifierControlDevice;
using DeviceLibrary.Devices.LightingControlDevice;
using DeviceLibrary.Hubs;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hub = new HubDevice();

            var climateDevice = new ClimateControlDevice();
            var humidifierDevice = new HumidifierControlDevice();
            var lightingDevice = new LightingControlDevice();

            hub.RegisterDevice(climateDevice);
            hub.RegisterDevice(humidifierDevice);
            hub.RegisterDevice(lightingDevice);

            hub.RestartDevice(climateDevice);
            hub.GetDeviceStatus(climateDevice);
            hub.RestartDevice(climateDevice);
            hub.GetDeviceStatus(climateDevice);
            hub.ExecuteDeviceCommands(climateDevice);
        }
    }
}
