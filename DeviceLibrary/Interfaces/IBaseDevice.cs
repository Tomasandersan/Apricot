using System.Collections.Generic;

using DeviceLibrary.Enum;

namespace DeviceLibrary.Interfaces
{
    public interface IBaseDevice
    {
        void Restart();

        Status GetStatus();

        void RegistrationInHub();

        void UpdateParamiters(IEnumerable<string> arrayParams);

        IEnumerable<ICommand> GetCommands();
    }
}
