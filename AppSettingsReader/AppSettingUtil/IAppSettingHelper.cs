using System;
using System.Configuration;

namespace AppSettingsReader
{
    /// <summary>
    /// Helper class used to obtain and manipulate a value from app setting section
    /// </summary>
    public interface IAppSettingHelper
    {
        /// <summary>
        /// Obtain and convert a value from the app setting section
        /// </summary>
        /// <typeparam name="T">The type of the value</typeparam>
        /// <param name="key">Key used to retrieve value</param>
        /// <exception cref="ArgumentException">Thrown when the key value is empty or null</exception>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ConfigurationErrorsException" />
        /// <exception cref="FormatException" />
        /// <exception cref="InvalidCastException" />
        /// <exception cref="OverflowException" />
        /// <exception cref="SettingsPropertyNotFoundException">Thrown when the key could not find</exception>
        /// <returns>Value converted to the type <typeparamref name="T"/></returns>
        T GetValues<T>(string key);
    }
}
