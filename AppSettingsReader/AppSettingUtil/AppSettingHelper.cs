using System;
using System.Configuration;

namespace AppSettingsReader
{
    ///<inheritdoc cref="IAppSettingHelper"/>
    public class AppSettingHelper : IAppSettingHelper
    {
        #region .:: Property(ies) and constant(s) ::.

        /// <summary>
        /// 
        /// </summary>
        private const string ExceptionMessageArgumentEmptyOrNull = "The parameter cannot be empty or null.";

        /// <summary>
        /// 
        /// </summary>
        private const string ExceptionMessagePropertyNotFound = @"Could not find property with key ""{0}"".";

        #endregion

        #region .:: Property(ies) and constant(s) ::.

        ///<inheritdoc/>
        public T GetValues<T>(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException(ExceptionMessageArgumentEmptyOrNull);

            string appSettingsValue = ConfigurationManager.AppSettings[key]?.ToString();

            if (string.IsNullOrWhiteSpace(appSettingsValue))
                throw new SettingsPropertyNotFoundException(string.Format(ExceptionMessagePropertyNotFound, key));

            return (T)Convert.ChangeType(appSettingsValue, typeof(T));
        }

        #endregion
    }
}
