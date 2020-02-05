using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedLengthSample
{
    public abstract  class BaseModel
    {
     
        /// <summary>
        /// eg:04abcd
        /// data=abcd ,herder=len(abcd)=04
        /// </summary>
        /// <param name="headerLength">add length for eatch data row</param>
        /// <returns></returns>
        public string ToFixedLengthString(int headerLength)
        {
            int length = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var pi in this.GetType().GetProperties())
            {
                FixedLengthAttribute attribute = FixedLengthHelper.GetCustomAttribute<FixedLengthAttribute>(pi);
                if (attribute != null && attribute.Length > 0)
                {
                    if (attribute.Type == FixedLengthType.A)
                    {
                        sb.Append(HandleFixedString(pi.GetValue(this, null), attribute.Length));
                    }
                    else
                    {
                        sb.Append(HandleFixedNumber(pi.GetValue(this, null), attribute.Length));
                    }
                    length += attribute.Length;
                }
            }

            if (headerLength>0)
                sb.Insert(0, HandleFixedNumber(length.ToString(),headerLength));

            return sb.ToString();
        }
        public string ToFixedLengthString()
        {
            return ToFixedLengthString(0);
        }
        public static T FromFixedLengthString<T>(string input, int headerLength)
        {
            T obj = Activator.CreateInstance<T>();
            string value = "";

              int startIndex = 0;
            if (headerLength > 0)
                startIndex=headerLength;
 
            StringBuilder sb = new StringBuilder();
            foreach (var pi in obj.GetType().GetProperties())
            {
                FixedLengthAttribute attribute = FixedLengthHelper.GetCustomAttribute<FixedLengthAttribute>(pi);
                if (attribute != null && attribute.Length > 0)
                {
                    if(input.Length <= startIndex)
                    {
                        break;
                    }
                    else if(input.Length > startIndex && input.Length < startIndex + attribute.Length )
                    {
                        //value = input.Substring(startIndex);
                        value = SubstringWide(input, startIndex);
                    }
                    else 
                    {
                        //value = input.Substring(startIndex, attribute.Length);
                        value = SubstringWide(input, startIndex, attribute.Length);
                    }
                    pi.SetValue(obj, value, null);
                    startIndex += attribute.Length;
                }
            }

            return obj;
        }
        public static T FromFixedLengthString<T>(string input)
        {
            return FromFixedLengthString<T>(input,0);
        }

        public static string SubstringWide(string input, int startIndex)
        {

            if (string.IsNullOrEmpty(input))
                return string.Empty;

            byte[] bytes = Encoding.GetEncoding(936).GetBytes(input);
            if (bytes.Length < startIndex + 1)
                return string.Empty;

            int length = bytes.Length - startIndex;
            byte[] bytesTarget = new byte[length];
            Array.Copy(bytes, startIndex, bytesTarget, 0, length);

            string target = Encoding.GetEncoding(936).GetString(bytesTarget);

            return target;

        }
        /// <summary>
        /// 全角字符占两个字节，半角占一个
        /// </summary>
        /// <param name="input"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string SubstringWide(string input, int startIndex,int length)
        {
            if(string.IsNullOrEmpty(input))
                return string.Empty;

            byte[] bytes = Encoding.GetEncoding(936).GetBytes(input);
            if (bytes.Length < startIndex + 1)
                return string.Empty;


            byte[] bytesTarget=new byte[length];
            Array.Copy(bytes,startIndex,bytesTarget,0,length);

            string target = Encoding.GetEncoding(936).GetString(bytesTarget);

            return target;
        }



        private static string HandleFixedString(object input, int length)
        {
            string output = String.Empty;
            string inputString = String.Empty;
            if (input != null)
                inputString = input.ToString();

            if (String.IsNullOrEmpty(inputString))
            {
                output = output.PadRight(length, ' ');
            }
            else if (inputString.Length > length)
            {
                //output = inputString.Substring(0, length);
                output = SubstringWide(inputString, 0, length);
            }
            else
            {
               // output = inputString.PadRight(length, ' ').Substring(0, length);
                output = SubstringWide(inputString.PadRight(length, ' '), 0, length);
            }

            return output;
        }

        private static string HandleFixedNumber(object input, int length)
        {
            string output = String.Empty;
            string inputString = String.Empty;
            if (input != null)
                inputString = input.ToString();

            if (String.IsNullOrEmpty(inputString))
            {
                output = output.PadLeft(length, '0');
            }
            else if (inputString.Length > length)
            {
                output = inputString.Substring(inputString.Length - length, length);
            }
            else
            {
                output = inputString.PadLeft(length, '0').Substring(0, length);
            }

            return output;
        }
    }
}
