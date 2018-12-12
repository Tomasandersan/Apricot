namespace DeviceLibrary.Interfaces
{
    public interface IHumidifierDevice : IBaseDevice
    {
        void Humidify();

        void Dry();
    }
}
