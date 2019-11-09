using System;
using DemoAutofac.Interfaces;

namespace DemoAutofac
{
    public class MainViewModel : BaseViewModel
    {
        private string _deviceIndentifier;

        private IDeviceInfo _deviceInfo;

        public MainViewModel(IDeviceInfo deviceInfo)
        {
            _deviceInfo = deviceInfo;

            DeviceIndentifier = _deviceInfo.GetUniqueIdentifier();
        }

        public string DeviceIndentifier
        {
            get => _deviceIndentifier;
            set
            {
                _deviceIndentifier = value;
                OnPropertyChanged(nameof(DeviceIndentifier));
            }
        }
    }
}
