using AppSettingsReader;
using NUnit.Framework;
using System.Configuration;

namespace AppSettingsReaderUnitTests
{
    [TestFixture]
    public class AppSettingHelperSuccessCases
    {
        IAppSettingHelper appSettingHelper;

        [SetUp]
        public void Setup()
        {
            appSettingHelper = new AppSettingHelper();

            ConfigurationManager.AppSettings.Set("IntValue", "0");
            ConfigurationManager.AppSettings.Set("BoolValue", "false");
            ConfigurationManager.AppSettings.Set("StringValue", "anyString");
        }

        [Test]
        public void WhenKeyParameterIsIntValueTheValueReturnedShouldByZeroValue()
        {
            Assert.AreEqual(0, appSettingHelper.GetValues<int>("IntValue"));
        }

        [Test]
        public void WhenKeyParameterIsBoolValueTheValueReturnedShouldByFalseVAlue()
        {
            Assert.IsFalse(appSettingHelper.GetValues<bool>("BoolValue"));
        }

        [Test]
        public void WhenKeyParameterIsStringValueTheValueReturnedShouldByAnyStringValue()
        {
            Assert.AreEqual("anyString", appSettingHelper.GetValues<string>("StringValue"));
        }
    }
}
