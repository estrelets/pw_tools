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
        private static readonly Encoding ChinesEncoding;
        private static readonly Encoding UnicodeEncoding;

        static StringPlanItem()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            ChinesEncoding = Encoding.GetEncoding("gb2312");
            UnicodeEncoding = Encoding.Unicode;
        }

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

        public int Length { get; }
        public bool IsDynamic { get; }
        public bool IsNameChar { get; }
        public IPlanItem LengthPlan { get; }
        public IValueAccessor Accessor { get; }

        public void Serialize(object obj, IWriter writer, Stream stream)
        {
            var value = (string) Accessor.Get(obj);
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

            if (IsDynamic) length = (int) LengthPlan.Deserialize(null, reader, stream);

            var value = reader.Read(this, length, stream);

            if (Accessor is IValueAssigner setter) setter.Set(obj, value);

            return value;
        }

        public Encoding GetEncoding()
        {
            return !IsNameChar ? ChinesEncoding : UnicodeEncoding;
        }

        public int CalculateBytesLength(int stringLength)
        {
            return IsNameChar ? stringLength * 2 : stringLength;
        }

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
