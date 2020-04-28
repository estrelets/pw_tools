using System.IO;
using Pw.Serializer.Plans;

namespace Pw.Serializer.Readers
{
    public class ElementsReader : IReader
    {
        public object Read(PrimitivePlanItem primitivePlanItem, Stream stream)
        {
            return Shared.Read(primitivePlanItem, stream);
        }

        public object Read(StringPlanItem plan, int length, Stream stream)
        {
            return Shared.Read(plan, length, stream);
        }
    }
}
