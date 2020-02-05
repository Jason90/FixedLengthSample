using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Jason.Util.Helper
{
    public class BaseHelper
    {
        public delegate bool PollingDelegate();

        public static bool PollingCheck(PollingDelegate pollingMethod, TimeSpan sleepTime, int retryTimes)
        {
            for (int i = 0; i < retryTimes; i++)
            {
                if (pollingMethod())
                    return true;
                else
                    System.Threading.Thread.Sleep(sleepTime);//System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(sleepTime.TotalMilliseconds * Math.Pow(2, i)));
            }

            return false;
        }



        //public static Int32 RepleasePlaceholderToZero(string input)
        //{
        //    string placeholder = "65535";
        //    if (string.IsNullOrEmpty(input) == false)
        //    {
        //        if (StringHelper.IsNumeric(input) == false || (placeholder.Length >= input.Length && input == placeholder.Substring(placeholder.Length - input.Length)))
        //            return 0;
        //        else
        //            return Convert.ToInt32(input.Trim());
        //    }
        //    return 0;
        //}

        //public static string RepleasePlaceholderToEmpty(string input)
        //{
        //    string placeholder = "65535";
        //    if (string.IsNullOrEmpty(input) == false)
        //    {
        //        if (placeholder.Length >= input.Length && input == placeholder.Substring(placeholder.Length - input.Length))
        //            return string.Empty;
        //        else
        //            return input;
        //    }
        //    return string.Empty;
        //}

        //public static T ParseFixedLengthString<T>(string input) where T : new()
        //{
        //    if (string.IsNullOrEmpty(input)) return default(T);

        //    T obj = (T)Activator.CreateInstance(typeof(T));

        //    int position = 0;
        //    foreach (PropertyInfo pi in typeof(T).GetProperties())
        //    {
        //        object[] cas = pi.GetCustomAttributes(typeof(MaxLengthAttribute), true);

        //        if (cas != null && cas.Length > 0)
        //        {
        //            if (cas[0] is MaxLengthAttribute)
        //            {
        //                MaxLengthAttribute pa = (MaxLengthAttribute)cas[0];
        //                int maxLength = pa.MaxLength;
        //                if (maxLength > 0 && input.Length > position)
        //                {
        //                    string value = "";
        //                    if (input.Length >= position + maxLength)
        //                        value = input.Substring(position, maxLength);
        //                    else
        //                        value = input.Substring(position);
        //                    if (pi.PropertyType == typeof(string))
        //                    {
        //                        pi.SetValue(obj, RepleasePlaceholderToEmpty(value), null);
        //                    }
        //                    else
        //                    {
        //                        if (StringHelper.IsNumeric(value))
        //                        {
        //                            pi.SetValue(obj, RepleasePlaceholderToZero(value), null);
        //                        }
        //                    }
        //                }
        //                position += maxLength;
        //                //break;
        //            }
        //        }

        //        //foreach (var attr in pi.GetCustomAttributes(typeof(MaxLengthAttribute), true))
        //        //{
        //        //    if (attr.AttributeType == typeof(System.ComponentModel.DataAnnotations.MaxLengthAttribute) && attr.ConstructorArguments.Count > 0)
        //        //    {
        //        //        int maxLength = Convert.ToInt32(attr.ConstructorArguments[0].Value);
        //        //        if (maxLength > 0 && input.Length > position)
        //        //        {
        //        //            string value = "";
        //        //            if (input.Length >= position + maxLength)
        //        //                value = input.Substring(position, maxLength);
        //        //            else
        //        //                value = input.Substring(position);
        //        //            if (pi.PropertyType == typeof(string))
        //        //            {
        //        //                pi.SetValue(obj, RepleasePlaceholderToEmpty(value));
        //        //            }
        //        //            else
        //        //            {
        //        //                if (StringHelper.IsNumeric(value))
        //        //                {
        //        //                    pi.SetValue(obj, RepleasePlaceholderToZero(value));
        //        //                }
        //        //            }
        //        //        }
        //        //        position += maxLength;
        //        //        break;
        //        //    }
        //        //}
        //    }

        //    return obj;
        //}

        //public static object ParseFixedLengthStringRecursion(string input, Type type)
        //{
        //    if (string.IsNullOrEmpty(input)) return null;

        //    object obj = Activator.CreateInstance(type);

        //    int position = 0;
        //    foreach (PropertyInfo pi in type.GetProperties())
        //    {
        //        object[] cas = pi.GetCustomAttributes(typeof(MaxLengthAttribute), true);

        //        if (cas != null && cas.Length > 0)
        //        {
        //            if (cas[0] is MaxLengthAttribute)
        //            {
        //                MaxLengthAttribute pa = (MaxLengthAttribute)cas[0];
        //                int maxLength = pa.MaxLength;
        //                if (maxLength > 0 && input.Length > position)
        //                {

        //                    string value = "";
        //                    if (input.Length >= position + maxLength)
        //                        value = input.Substring(position, maxLength);
        //                    else
        //                        value = input.Substring(position);
        //                    if (pa.IsComplexType)
        //                    {
        //                        pi.SetValue(obj, ParseFixedLengthStringRecursion(value, pi.PropertyType), null);
        //                    }
        //                    else
        //                    {
        //                        if (pi.PropertyType == typeof(string))
        //                        {
        //                            pi.SetValue(obj, RepleasePlaceholderToEmpty(value), null);
        //                        }
        //                        else
        //                        {
        //                            if (StringHelper.IsNumeric(value))
        //                            {
        //                                pi.SetValue(obj, RepleasePlaceholderToZero(value), null);
        //                            }
        //                        }
        //                    }
        //                    position += maxLength;
        //                }
        //            }
        //        }
        //    }

        //    return obj;
        //}

        //public static string GetPropertyValue(object obj, string propertyName)
        //{
        //    PropertyInfo pi = obj.GetType().GetProperty(propertyName);
        //    if (pi != null)
        //        return pi.GetValue(obj, null).ToString();
        //    else
        //        return string.Empty;

        //}

    }
}
