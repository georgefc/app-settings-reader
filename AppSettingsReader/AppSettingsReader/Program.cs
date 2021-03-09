using AppSettingsReader;
using System;

namespace AppSettingsReaderConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IAppSettingHelper appSettingHelper = new AppSettingHelper();

                Console.WriteLine("Value: {0}\r\n", appSettingHelper.GetValues<int>("IntValue"));
                Console.WriteLine("Value: {0}\r\n", appSettingHelper.GetValues<bool>("BoolValue"));
                Console.WriteLine("Value: {0}\r\n", appSettingHelper.GetValues<string>("StringValue"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message:");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
