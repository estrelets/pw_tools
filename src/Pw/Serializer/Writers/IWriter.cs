using System.IO;
using Pw.Serializer.Plans;

namespace Pw.Serializer.Writers
{
    public interface IWriter
    {
        void Write(PrimitivePlanItem primitivePlanItem, object value, Stream stream);
        void Write(StringPlanItem plan, string value, int length, Stream stream);
    }
}
