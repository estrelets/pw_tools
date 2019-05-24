using System.IO;
using Pw.Serializer.Readers;
using Pw.Serializer.Writers;

namespace Pw.Serializer
{
    public class ElementsSerializer
    {
        private static IReader _elementsReader = new ElementsReader();
        private static IWriter _elementsWriter = new ElementsWriter();
        
        public void Serialize<TObject>(TObject obj, Stream stream)
        {
            var plan = PlansCache.Instance.GetPlan<TObject>();
            plan.Serialize(obj, _elementsWriter, stream);
        }

        public TObject DeSerialize<TObject>(Stream stream)
        {
            var plan = PlansCache.Instance.GetPlan<TObject>();
            return (TObject)plan.Deserialize(null, _elementsReader, stream);
        }
    }
}
