using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace FlightTicketManagementSystem
{
    public class Toolkit
    {
        public static T GetAppSetting<T>(string name)
        {
            try
            {
                var value = ConfigurationManager.AppSettings[name];
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
    }
}
