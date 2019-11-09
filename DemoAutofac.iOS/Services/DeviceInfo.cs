using System;
using DemoAutofac.Interfaces;
using UIKit;

namespace DemoAutofac.iOS.Services
{
    public class DeviceInfo : IDeviceInfo
    {
        public string GetUniqueIdentifier()
        {
            return UIDevice.CurrentDevice.IdentifierForVendor.AsString();
        }
    }
}
