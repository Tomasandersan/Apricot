namespace DeviceLibrary.Interfaces
{
    public interface ILightingDevice : IBaseDevice
    {
        void IncreaseBrightness();

        void ReduceBrightness();
    }
}
