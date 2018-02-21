using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Birikim.Extensions
{
    /// <summary>
    /// Extension methods for all objects.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Used to simplify and beautify casting an object to a type.
        /// </summary>
        /// <typeparam name="T">Type to be casted</typeparam>
        /// <param name="obj">Object to cast</param>
        /// <returns>Casted object</returns>
        public static T As<T>(this object obj)
            where T : class
        {
            return (T)obj;
        }

        /// <summary>
        /// Check if an item is in a list.
        /// </summary>
        /// <param name="item">Item to check</param>
        /// <param name="list">List of items</param>
        /// <typeparam name="T">Type of the items</typeparam>
        public static bool IsIn<T>(this T item, params T[] list)
        {
            return list.Contains(item);
        }

        /// <summary>
        /// Converts given object to a value type using <see cref="Convert.ChangeType(object,System.TypeCode)"/> method.
        /// </summary>
        /// <param name="obj">Object to be converted</param>
        /// <typeparam name="T">Type of the target object</typeparam>
        /// <returns>Converted object</returns>
        public static T To<T>(this object obj)
            where T : struct
        {
            if (typeof(T) == typeof(Guid))
            {
                return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(obj.ToString());
            }

            return (T)Convert.ChangeType(obj, typeof(T), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// <para>Gelen değeri Bool türüne dönüştürür.</para>
        /// Hata olursa false döner.
        /// </summary>
        public static bool ToBool(this object value)
        {
            try { return Convert.ToBoolean(value); }
            catch { return false; }
        }

        /// <summary>
        /// Null ve DBNULL kontrolü yapar 
        /// </summary>
        public static bool IsNull(this object value)
        {
            if (value == DBNull.Value || value == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Null ve DBNULL değilse true döner
        /// </summary>
        public static bool IsNotNull(this object value)
        {
            if (value == DBNull.Value || value == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// <para>Gelen değeri String türüne dönüştürür.</para>
        /// Trimle boşluklar atılır. Hata olursa "" döner.
        /// </summary>
        public static string ToString2(this object value)
        {
            try { return Convert.ToString(value).Trim(); }
            catch { return ""; }
        }

        /// <summary>
        /// Genellikle decimal veya float tiplerde database tarafına kayıt
        /// atarken ondalık kısmı "," olarak gördüğünden hata verir. 
        /// Bunu önlemek için ToDot() extension metodu kullanılır.
        /// </summary>
        public static object ToDot(this object value)
        {
            return value.ToString().Replace(',', '.');
        }
    }
}