namespace AppSettingsReader
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAppSettingHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T GetValues<T>(string key);
    }
}
