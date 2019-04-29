using System.IO;
using Pw.ElementsSerializer.ValueAccessors;

namespace Pw.ElementsSerializer.Plans
{
    public interface IPlanItem
    {
        IValueAccessor Accessor { get; }
        void Serialize(object obj, Stream stream);
        object Deserialize(object obj, Stream stream);
    }
}
