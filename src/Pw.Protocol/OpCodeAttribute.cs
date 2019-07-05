using System;

namespace Pw
{
    public class OpCodeAttribute : Attribute
    {
        public int Code { get; }

        public OpCodeAttribute(int code)
        {
            Code = code;
        }
    }
}
