using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace FixedLengthSample
{
    public class FixedLengthHelper
    {
        public static T GetCustomAttribute<T>(PropertyInfo pi) where T : Attribute
        {
            object[] cas = pi.GetCustomAttributes(typeof(T), true);
            if (cas != null && cas.Length > 0)
            {
                return (T)cas[0];
            }

            return default(T);
        }


        /// <summary>
        /// Check whether a string is numeric
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>whether numeric</returns>
        public static bool IsNumeric(string input)
        {
            return (!string.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^-?\d+(\.\d+)?$"));
        }


        public static T ParseFixedLengthStringWithChecking<T>(string input, int length) where T : new()
        {
            T obj = (T)Activator.CreateInstance(typeof(T));

            return ParseFixedLengthStringWithChecking<T>(obj, input, length);
        }
        public static T ParseFixedLengthStringWithChecking<T>(T obj, string input, int length) where T : new()
        {
            if (string.IsNullOrEmpty(input) == false && input.Length == length)
            {
                return ParseFixedLengthString<T>(obj, input);
            }
            else
            {
                //Logger.Log.Write(Severity.Warning, "Invalid response data. The Length of response data should be {0}", length);
                return default(T);
            }
        }
        public static T ParseFixedLengthString<T>(string input) where T : new()
        {
            T obj = (T)Activator.CreateInstance(typeof(T));

            return ParseFixedLengthString<T>(obj, input);
        }

        public static T ParseFixedLengthString<T>(T obj, string input) where T : new()
        {
            if (string.IsNullOrEmpty(input)) return default(T);

            int position = 0;
            foreach (PropertyInfo pi in typeof(T).GetProperties())
            {
                if (pi.Name == "Response")
                {
                    pi.SetValue(obj, input, null);
                }

                FixedLengthAttribute maxLength = GetCustomAttribute<FixedLengthAttribute>(pi);
                if (maxLength != null && maxLength.Length > 0 && input.Length > position)
                {
                    string value = "";
                    if (input.Length >= position + maxLength.Length)
                        value = input.Substring(position, maxLength.Length);
                    else
                        value = input.Substring(position);
                    if (pi.PropertyType == typeof(string))
                    {
                        pi.SetValue(obj, value, null);
                    }
                    else
                    {
                        if (IsNumeric(value))
                        {
                            pi.SetValue(obj, value, null);
                        }
                    }
                    position += maxLength.Length;
                }
            }

            return obj;
        }


        //public static string DecimalToHex(decimal? input)
        //{
        //    return input.HasValue ? (Convert.ToInt32(input.Value)).ToString("X4") : null;
        //}

        //public static decimal HexToDecimal(string input)
        //{
        //    return Convert.ToDecimal(HexToInt(input));
        //}
        //public static int HexToInt(string input)
        //{
        //    return Convert.ToInt32(input, 16);
        //}
        //public static string IntToHex(int input, int length)
        //{
        //    string pattern = "X";
        //    if (length > 0) pattern = pattern + length;
        //    return input.ToString(pattern);
        //}
        //public static string IntToHex(int input)
        //{
        //    return input.ToString("X");
        //}

        //public static decimal IntToDecimal(int input, int precision)
        //{
        //    return Convert.ToDecimal(input * 1.0 / (Math.Pow(10, precision)));
        //}
        ////public static decimal IntToDecimalByUnit(int input, int precision, int unitId)
        ////{
        ////    //HL,HB,HV,SMG 不保留小数，不进位
        ////    if (unitId == 0 || unitId == 3 || unitId == 4 || unitId == 8)
        ////        return Math.Truncate(IntToDecimal(input, precision));
        ////    else
        ////        return IntToDecimal(input, precision);
        ////}
        //private MaxLengthAttribute GetMaxLengthAttribute(PropertyInfo pi)
        //{
        //    object[] cas = pi.GetCustomAttributes(typeof(MaxLengthAttribute), true);
        //    if (cas != null && cas.Length > 0)
        //    {
        //        return (MaxLengthAttribute)cas[0];
        //    }

        //    return null;
        //}

        public static object ParseFixedLengthStringRecursion(string input, Type type)
        {
            if (string.IsNullOrEmpty(input)) return null;

            object obj = Activator.CreateInstance(type);

            int position = 0;
            foreach (PropertyInfo pi in type.GetProperties())
            {
                if (pi.Name == "Response")
                {
                    pi.SetValue(obj, input, null);
                }

                FixedLengthAttribute maxLength = GetCustomAttribute<FixedLengthAttribute>(pi);
                if (maxLength != null && maxLength.Length > 0 && input.Length > position)
                {
                    string value = "";
                    if (input.Length >= position + maxLength.Length)
                        value = input.Substring(position, maxLength.Length);
                    else
                        value = input.Substring(position);
                    if (maxLength.Type == FixedLengthType.X)
                    {
                        pi.SetValue(obj, ParseFixedLengthStringRecursion(value, pi.PropertyType), null);
                    }
                    else
                    {
                        if (pi.PropertyType == typeof(string))
                        {
                            pi.SetValue(obj, value, null);
                        }
                        else
                        {
                            if (IsNumeric(value))
                            {
                                pi.SetValue(obj, value, null);
                            }
                        }
                    }
                    position += maxLength.Length;
                }
            }

            return obj;
        }

        public static string GetPropertyValue(object obj, string propertyName)
        {
            PropertyInfo pi = obj.GetType().GetProperty(propertyName);
            if (pi != null)
                return pi.GetValue(obj, null).ToString();
            else
                return string.Empty;

        }

        //public static BindingList<T> ToBindingList<T>(IEnumerable<T> range)
        //{
        //    BindingList<T> items = new BindingList<T>();
        //    foreach (var item in range)
        //    {
        //        items.Add(item);
        //    }

        //    return items;
        //}

        //public static BindingList<T> ObjectToBindingList<T>(T item)
        //{
        //    BindingList<T> items = new BindingList<T>();
        //    items.Add(item);

        //    return items;
        //}

        //public static T ListToObject<T>(IList<T> lists)
        //{
        //    if (lists != null && lists.Count > 0)
        //        return (T)lists[0];
        //    else
        //        return default(T);
        //}

        //public static T ListToObject<T>(object lists)
        //{
        //    if (lists != null && lists is IList<T>)
        //    {
        //        return ListToObject<T>((IList<T>)lists);
        //    }
        //    else
        //        return default(T);
        //}

        //public static T BindingListToObject<T>(object obj)
        //{
        //    if (obj != null && obj is BindingList<T>)
        //    {
        //        BindingList<T> items = obj as BindingList<T>;
        //        if (items != null && items.Count > 0)
        //        {
        //            return items[0];
        //        }
        //        else
        //            return default(T);
        //    }
        //    else
        //        return default(T);
        //}

        //public static List<T> ToList<T>(IEnumerable<T> range)
        //{
        //    List<T> items = new List<T>();
        //    foreach (var item in range)
        //    {
        //        items.Add(item);
        //    }

        //    return items;
        //}
    }


}
