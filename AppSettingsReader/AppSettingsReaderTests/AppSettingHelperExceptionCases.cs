using AppSettingsReader;
using NUnit.Framework;
using System;
using System.Configuration;

namespace AppSettingsReaderUnitTests
{
    [TestFixture]
    public class AppSettingHelperExceptionCases
    {
        IAppSettingHelper appSettingHelper;

        [SetUp]
        public void Setup()
        {
            appSettingHelper = new AppSettingHelper();

            ConfigurationManager.AppSettings.Set("IntValue", "0");
            ConfigurationManager.AppSettings.Set("BoolValue", "false");
            ConfigurationManager.AppSettings.Set("StringValue", "AnyString");
        }

        [Test]
        public void WhenKeyParameterIsEmptyThrowArgumentException()
        {
            Exception ex = Assert.Throws(typeof(ArgumentException), () => { appSettingHelper.GetValues<int>(string.Empty); });

            Assert.That(ex.Message, Is.EqualTo("The parameter cannot be empty or null."));
        }

        [Test]
        public void WhenKeyParameterIsNullThrowArgumentException()
        {
            Exception ex = Assert.Throws(typeof(ArgumentException), () => { appSettingHelper.GetValues<int>(null); });

            Assert.That(ex.Message, Is.EqualTo("The parameter cannot be empty or null."));
        }

        [Test]
        public void WhenKeyParameterIsNotFoundThrowSettingsPropertyNotFoundException()
        {
            Exception ex = Assert.Throws(typeof(SettingsPropertyNotFoundException), () => { appSettingHelper.GetValues<int>("Lorem"); });

            Assert.That(ex.Message, Is.EqualTo(@"Could not find property with key ""Lorem""."));
        }

        [Test]
        public void WhenTheValueIsDiferentOfTypeParamThrowFormatException()
        {
            Assert.Throws(typeof(FormatException), () => { appSettingHelper.GetValues<int>("StringValue"); });
        }
    }
}
