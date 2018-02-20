using System;

namespace Birikim.Extensions
{
    /// <summary>
    /// Extension methods for Integer class.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Nicely formatted file size. This method will return file size with bytes, KB, MB and GB in it. You can use this alongside the Extension method named FileSize.
        /// </summary>
        public static string FormatFileSize(this int fileSize)
        {
            //declarations
            string[] suffix = { "B", "KB", "MB", "GB", "TB" };
            var j = 0;

            //loop and divide
            while (fileSize > 1024 && j < (suffix.Length - 1))
            {
                fileSize = fileSize / 1024;
                j++;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return string.Format("{0:0} {1}", fileSize, suffix[j]);
        }

        /// <summary>
        /// Convert OaDate to DateTime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime FromOaDate(this int value)
        {
            try
            {
                return DateTime.FromOADate(value).Date;
            }
            catch (Exception)
            {
                return DateTime.Today.Date;
            }
        }

        /// <summary>
        /// Convert OaDate to String date format
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string FromOaDate(this int value, string format = "")
        {
            try
            {
                return DateTime.FromOADate(value).ToString(format);
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Convert OaTime to String date format
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FromOaTime(this int value)
        {
            try
            {
                var now = new DateTime(2000, 1, 1);
                return now.AddSeconds(value).TimeOfDay.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// Conevrts object to integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt32(this object value)
        {
            try { return Convert.ToInt32(value); }
            catch { return 0; }
        }
    }
}