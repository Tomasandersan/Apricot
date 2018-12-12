using System.Collections.Generic;
using System.Linq;

using DeviceLibrary.Interfaces;
using DeviceLibrary.Enum;

namespace DeviceLibrary.BaseDevices
{
    public abstract class BaseDevice : IBaseDevice
    {
        private Status _status;
        private List<string> _params;

        public BaseDevice() { }

        public virtual void RegistrationInHub() => this._status = Status.Regested;

        public virtual void Restart() => this._status = Status.Restarted;

        public virtual Status GetStatus() => this._status;

        public virtual void UpdateParamiters(IEnumerable<string> arrayParams) => this._params = arrayParams.ToList();

        public abstract IEnumerable<ICommand> GetCommands();
    }
}
