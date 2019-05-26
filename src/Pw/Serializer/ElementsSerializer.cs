using Pw.Serializer.Readers;
using Pw.Serializer.Writers;

namespace Pw.Serializer
{
    public class ElementsSerializer : BaseSerializer
    {
        private static readonly IReader ElementsReader = new ElementsReader();
        private static readonly IWriter ElementsWriter = new ElementsWriter();
        
        public ElementsSerializer() 
            : base(ElementsReader, ElementsWriter)
        {
        }
    }
}
