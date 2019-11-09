using System;
using DemoAutofac.Interfaces;

namespace DemoAutofac.Droid.Services
{
    public class DeviceInfo : IDeviceInfo
    {
        public string GetUniqueIdentifier()
        {
            return Android.Provider.Settings.Secure.GetString(Xamarin.Forms.Forms.Context.ContentResolver,
                                                              Android.Provider.Settings.Secure.AndroidId);
        }
    }
}
