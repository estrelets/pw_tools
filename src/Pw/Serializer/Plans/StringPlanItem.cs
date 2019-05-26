using System;
using System.IO;
using System.Text;
using Pw.Serializer.Readers;
using Pw.Serializer.ValueAccessors;
using Pw.Serializer.Writers;

namespace Pw.Serializer.Plans
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

        public void Serialize(object obj, IWriter writer, Stream stream)
        {
            var value = (string)Accessor.Get(obj);
            var length = Length;

            if (IsDynamic)
            {
                length = value.Length;
                LengthPlan.Serialize(length, writer, stream);
            }

            writer.Write(this, value, length, stream);
        }

        public object Deserialize(object obj, IReader reader, Stream stream)
        {
            var length = Length;

            if (IsDynamic)
            {
                length = (int)LengthPlan.Deserialize(null, reader, stream);
            }

            var value = reader.Read(this, length, stream);

            if (Accessor is IValueAssigner setter)
            {
                setter.Set(obj, value);
            }

            return value;
        }

        public Encoding GetEncoding() => !IsNameChar ? ChinesEncoding : UnicodeEncoding;
        public int CalculateBytesLength(int stringLength) => IsNameChar ? stringLength * 2 : stringLength;

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
