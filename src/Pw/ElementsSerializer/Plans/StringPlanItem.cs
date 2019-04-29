using System;
using System.IO;
using System.Text;
using Pw.ElementsSerializer.ValueAccessors;

namespace Pw.ElementsSerializer.Plans
{
    public class StringPlanItem : IPlanItem
    {
        static StringPlanItem()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            ChinesEncoding = Encoding.GetEncoding("gb2312");
            UnicodeEncoding = Encoding.Unicode;
        }

        private static Encoding ChinesEncoding;
        private static Encoding UnicodeEncoding;

        public int Length { get; }
        public bool IsDynamic { get; }
        public bool IsNameChar { get; }
        public IValueAccessor Accessor { get; }
        public IPlanItem LengthPlan { get; }

        public StringPlanItem(IValueAccessor accessor, bool isNameChar, int length)
        {
            Accessor = accessor;
            IsNameChar = isNameChar;
            Length = length;
        }

        public StringPlanItem(IValueAccessor accessor, bool isNameChar)
        {
            Accessor = accessor;
            IsNameChar = isNameChar;
            IsDynamic = true;
            LengthPlan = PlanBuilder.CreateReadLengthPlan();
        }

        public void Serialize(object obj, Stream stream)
        {
            var value = (string)Accessor.Get(obj);
            var encoding = GetEncoding();
            var length = Length;

            if (IsDynamic)
            {
                length = value.Length;
                LengthPlan.Serialize(length, stream);
            }

            length = CalculateBytesLength(length);

            var textBuffer = encoding.GetBytes(value);
            Array.Resize(ref textBuffer, length);

            stream.Write(textBuffer, 0, textBuffer.Length);
        }

        public object Deserialize(object obj, Stream stream)
        {
            var encoding = GetEncoding();
            var length = Length;

            if (IsDynamic)
            {
                length = (int)LengthPlan.Deserialize(null, stream);
            }

            var bytesLength = CalculateBytesLength(length);

            var textBuffer = new byte[bytesLength];
            stream.Read(textBuffer, 0, bytesLength);

            var value = encoding.GetString(textBuffer);

            if (!IsDynamic)
                value = value.TrimEnd('\0');

            if (Accessor is IValueAssigner setter)
            {
                setter.Set(obj, value);
            }

            return value;
        }

        private Encoding GetEncoding() => !IsNameChar ? ChinesEncoding : UnicodeEncoding;
        private int CalculateBytesLength(int stringLength) => IsNameChar ? stringLength * 2 : Length;

        public override string ToString()
        {
            return $"{Accessor} => {(IsNameChar ? "W" : String.Empty)}String";
        }

        public static bool IsString(Type type)
        {
            return type == typeof(string);
        }
    }
}
