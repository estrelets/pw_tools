using System.IO;

namespace Pw.ElementsSerializer
{
    public interface ICustomSerializer
    {
        object Deserialize(Stream stream);
        void Serialize(object value, Stream stream);
    }
}
