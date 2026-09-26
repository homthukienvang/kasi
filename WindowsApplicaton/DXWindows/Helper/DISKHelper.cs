using DeviceId;
using log4net;
using System;
using System.Reflection;

namespace DXWindows.Helper
{
    public class DISKHelper
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// (recommended)
        /// https://github.com/MatthewKing/DeviceId
        /// </summary>
        /// <returns></returns>
        public static string GetDeviceId()
        {
            try
            {
                var deviceId = new DeviceIdBuilder()
                .AddMachineName()
                .AddOsVersion()
                .OnWindows(windows => windows
                    .AddProcessorId()
                    .AddMotherboardSerialNumber()
                    .AddSystemDriveSerialNumber()).ToString();
                _log.Debug("deviceID=" + deviceId);
                return deviceId;
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }

            return null;
        }
    }
}
