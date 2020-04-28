using System.IO;
using Pw.Serializer.Plans;

namespace Pw.Serializer.Readers
{
    public interface IReader
    {
        object Read(PrimitivePlanItem primitivePlanItem, Stream stream);
        object Read(StringPlanItem plan, int length, Stream stream);
    }
}
