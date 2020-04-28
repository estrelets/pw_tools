using System.IO;
using Pw.Serializer.Plans;

namespace Pw.Serializer.Writers
{
    public class ElementsWriter : IWriter
    {
        public void Write(PrimitivePlanItem primitivePlanItem, object value, Stream stream)
        {
            Shared.Write(primitivePlanItem, value, stream);
        }

        public void Write(StringPlanItem plan, string value, int length, Stream stream)
        {
            Shared.Write(plan, value, length, stream);
        }
    }
}
