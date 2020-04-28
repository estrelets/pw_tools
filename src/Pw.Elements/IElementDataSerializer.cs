using System.IO;

namespace Pw.Elements
{
    public interface IElementDataSerializer
    {
        IElementData Deserialize(Stream stream);
        void Serialize(Stream stream, IElementData elements);
    }
}
