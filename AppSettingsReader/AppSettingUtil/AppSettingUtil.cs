using System;
using System.Configuration;

namespace AppSettingUtil
{
    /// <summary>
    /// 
    /// </summary>
    public class AppSettingUtil
    {
        #region .:: Property(ies) and constant(s) ::.

        /// <summary>
        /// 
        /// </summary>
        private const string ExceptionMessageInvalidParamenter = @"The ""key"" can not be null or empty. ";

        #endregion

        #region .:: Property(ies) and constant(s) ::.

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetValues<T>(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(ExceptionMessageInvalidParamenter);

            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[key], typeof(T));
        }

        #endregion
    }
}
