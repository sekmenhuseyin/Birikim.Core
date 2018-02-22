using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

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
        /// Propertisi olan nesnelerin propertisini default değerler verir.
        /// </summary>
        /// <param name="istisnalar">Default değeri set edilmeyecek propertyleri belirtmek gerekiyor.</param>
        public static void DefaultValueSet(this object value, params string[] istisnalar)
        {

            foreach (var pi in value.GetType().GetProperties())
            {
                try
                {
                    if (istisnalar.Contains(pi.Name))
                        continue;

                    if (!pi.CanWrite)
                        continue;

                    if (pi.PropertyType.Namespace == "System.Collections.Generic")
                        continue;

                    if (!pi.PropertyType.IsGenericType)
                    {
                        if (pi.PropertyType == typeof(string))
                            pi.SetValue(value, "", null);
                        else if (pi.PropertyType == typeof(decimal))
                            pi.SetValue(value, 0.0m, null);
                        else if (pi.PropertyType == typeof(int) ||
                                 pi.PropertyType == typeof(short) ||
                                 pi.PropertyType == typeof(Single) ||
                                 pi.PropertyType == typeof(double) ||
                                 pi.PropertyType == typeof(byte))
                            pi.SetValue(value, (short)0, null);
                    }
                    else
                    {
                        if (pi.PropertyType.GetGenericArguments()[0] == typeof(string))
                            pi.SetValue(value, "", null);
                        else if (pi.PropertyType.GetGenericArguments()[0] == typeof(decimal))
                            pi.SetValue(value, 0.0m, null);
                        else if (pi.PropertyType.GetGenericArguments()[0] == typeof(int) ||
                                 pi.PropertyType.GetGenericArguments()[0] == typeof(double))
                            pi.SetValue(value, 0, null);
                        else if (pi.PropertyType.GetGenericArguments()[0] == typeof(Single))
                            pi.SetValue(value, 0.0f, null);
                        else if (pi.PropertyType.GetGenericArguments()[0] == typeof(short))
                            pi.SetValue(value, (short)0, null);
                        else if (pi.PropertyType.GetGenericArguments()[0] == typeof(byte))
                            pi.SetValue(value, (byte)0, null);
                    }
                }
                catch (Exception)
                {
                    //ignored
                }
            }
        }

        /// <summary>
        /// Propertisi olan nesnelerin propertisini default değerler verir.
        /// </summary>
        public static void GunesValueSet(this object value)
        {
            foreach (var pi in value.GetType().GetProperties())
            {
                try
                {
                    if (!pi.CanWrite)
                        continue;

                    if (pi.PropertyType == typeof(string))
                        pi.SetValue(value, "", null);
                    else if (pi.PropertyType == typeof(decimal))
                        pi.SetValue(value, 0.0m, null);
                    else if (pi.PropertyType == typeof(short))
                        pi.SetValue(value, (short)-1, null);
                    else if (pi.PropertyType == typeof(int) ||
                             pi.PropertyType == typeof(Single) ||
                             pi.PropertyType == typeof(double) ||
                             pi.PropertyType == typeof(byte))
                        pi.SetValue(value, (short)0, null);
                }
                catch
                {
                    throw new Exception(pi.Name + " alanına değer atılamıyor !");
                }
            }
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
        /// null ise false döner
        /// </summary>
        public static bool IsNotNullEmpty(this object value)
        {
            if (value == null) return false;
            if (value == DBNull.Value) return false;
            if (value.ToString().Trim() == string.Empty) return false;
            return true;
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
        /// Null ise true döner
        /// </summary>
        public static bool IsNullEmpty(this object value)
        {
            if (value == null) return true;
            if (value == DBNull.Value) return true;
            if (value.ToString().Trim() == string.Empty) return true;
            return false;
        }

        /// <summary>
        /// Aynı tipteki nesnenin değerlerini kendine set eder
        /// <para>Kullanım şekli : nesne1.Set(nesne2);  nesne2 nin değerleri nesne1'e atandı. </para>
        /// </summary>
        public static void Set(this object obj, object value, params string[] istisnalar)
        {
            foreach (PropertyInfo pi in value.GetType().GetProperties())
            {
                if (istisnalar.Contains(pi.Name))
                    continue;

                try
                {
                    obj.GetType().GetProperty(pi.Name)?.SetValue(obj, pi.GetValue(value, null), null);
                }
                catch
                {
                    // ignored
                }
            }
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
        /// <para>Gelen değeri DateTime türüne dönüştürür.</para>
        /// <para> Hata olursa "01.01.1970" değeri döner.</para>
        /// format değerini 1 gönderirseniz saat kısmını o anki saat olarak set eder.
        /// </summary>
        public static DateTime ToDatetime(this object value, int format = 0)
        {
            DateTime mDeger;
            try
            {
                if (format == 1)
                {
                    mDeger = DateTime.Parse(value.ToString());
                    mDeger = new DateTime(mDeger.Year, mDeger.Month, mDeger.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                }
                else
                {
                    mDeger = DateTime.Parse(value.ToString());
                }
            }
            catch
            {
                mDeger = new DateTime();
            }
            return mDeger;
        }

        /// <summary>
        /// <para>Gelen değeri Decimal türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static decimal ToDecimal(this object value)
        {
            try { return Convert.ToDecimal(value); }
            catch { return 0; }
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

        /// <summary>
        /// <para>Gelen değeri Double türüne dönüştürür.</para>
        /// </summary>
        public static double ToDouble(this object value)
        {
            try { return Convert.ToDouble(value); }
            catch { return 0; }
        }

        /// <summary>
        /// <para>Gelen değeri Float türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static float ToFloat(this object value)
        {
            try { return Convert.ToSingle(value); }
            catch { return 0; }
        }

        /// <summary>
        /// yuvarlama işlemleri için bir extension
        /// </summary>
        public static decimal ToRound(this decimal value, int ondalikBasamak)
        {
            return Math.Round(value.ToDecimal(), ondalikBasamak);
        }

        /// <summary>
        /// yuvarlama işlemleri için bir extension
        /// </summary>
        public static decimal ToRound(this decimal? value, int ondalikBasamak)
        {
            return Math.Round(value.ToDecimal(), ondalikBasamak);
        }

        /// <summary>
        /// <para>Gelen değeri Short (Int16) türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static short ToShort(this object value)
        {
            try { return Convert.ToInt16(value); }
            catch { return 0; }
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
    }
}