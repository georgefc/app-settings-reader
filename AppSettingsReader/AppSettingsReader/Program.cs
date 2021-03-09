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

                Console.WriteLine("Value: {0}", appSettingHelper.GetValues<int>("IntValue"));
                Console.WriteLine("Value: {0}", appSettingHelper.GetValues<bool>("BoolValue"));
                Console.WriteLine("Value: {0}", appSettingHelper.GetValues<string>("StringValue"));
                Console.WriteLine("Value: {0}", appSettingHelper.GetValues<string>("kkk"));
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
