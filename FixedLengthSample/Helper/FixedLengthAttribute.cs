using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedLengthSample
{
    public enum FixedLengthType
    {
        A = 1,  //Alphabet  可以包含所有字符（包括汉字）的字符串
        N = 2,  //Numberic  数字字符串
        X = 4   //Complex   复杂类型-实体类  
    }
    public class FixedLengthAttribute : Attribute
    {
        protected Int32 _Length = 0;
        protected FixedLengthType _type;

        public FixedLengthAttribute(Int32 length)
        {
            _Length = length;
        }

        public FixedLengthAttribute(Int32 length, FixedLengthType type)
        {
            _Length = length;
            _type = type;
        }
        public Int32 Length
        {
            get
            {
                return _Length;
            }
            set
            {
                _Length = value;
            }
        }
        public FixedLengthType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
    }
}
