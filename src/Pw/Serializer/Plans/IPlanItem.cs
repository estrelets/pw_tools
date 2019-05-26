using System.IO;
using Pw.Serializer.Readers;
using Pw.Serializer.ValueAccessors;
using Pw.Serializer.Writers;

namespace Pw.Serializer.Plans
{
    public interface IPlanItem
    {
        IValueAccessor Accessor { get; }
        void Serialize(object obj, IWriter writer, Stream stream);
        object Deserialize(object obj, IReader reader, Stream stream);
    }
}
