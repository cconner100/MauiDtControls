namespace MauiDtControlSample.Helpers
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    public static class LanguageResourceHelper
    {
        /// <summary>
        /// GetDisplayText
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetDisplayText(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            name = name.Replace(".", string.Empty);
            var key = name.ToLower(CultureInfo.CurrentCulture);
            try
            {
                var data = Resources.Strings.MenuResources.ResourceManager.GetString(key, CultureInfo.CurrentUICulture);
                if (data != null)
                {
                    return data;
                }

                // not found data , check for key that not case sensitive
                data = Resources.Strings.MenuResources.ResourceManager.GetString(name, CultureInfo.CurrentUICulture);
                if (data != null)
                {
                    return data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            // not have data
            var message = $"Key '{key}' not found in Language";
            Debug.WriteLine(message);
            return message;
        }
    }
}
