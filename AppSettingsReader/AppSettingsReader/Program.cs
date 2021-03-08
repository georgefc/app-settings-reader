using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSettingUtil;

namespace AppSettingsReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value: {0}", AppSettingUtil.AppSettingUtil.GetValues<int>("IntValue"));
            Console.WriteLine("Value: {0}", AppSettingUtil.AppSettingUtil.GetValues<bool>("BoolValue"));
            Console.WriteLine("Value: {0}", AppSettingUtil.AppSettingUtil.GetValues<string>("StringValue"));
            Console.ReadKey();
        }
    }
}
