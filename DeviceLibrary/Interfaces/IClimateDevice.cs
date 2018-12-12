namespace DeviceLibrary.Interfaces
{
    public interface IClimateDevice : IBaseDevice
    {
        void Heat();

        void Cool();
    }
}
