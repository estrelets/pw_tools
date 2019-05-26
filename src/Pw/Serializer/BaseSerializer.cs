using System.IO;
using Pw.Serializer.Readers;
using Pw.Serializer.Writers;

namespace Pw.Serializer
{
    public abstract class BaseSerializer
    {
        protected readonly IReader Reader;
        protected readonly IWriter Writer;

        protected BaseSerializer(IReader reader, IWriter writer)
        {
            Reader = reader;
            Writer = writer;
        }

        public virtual void Serialize<TObject>(TObject obj, Stream stream)
        {
            var plan = PlansCache.Instance.GetPlan<TObject>();
            plan.Serialize(obj, Writer, stream);
        }

        public virtual  TObject DeSerialize<TObject>(Stream stream)
        {
            var plan = PlansCache.Instance.GetPlan<TObject>();
            return (TObject) plan.Deserialize(null, Reader, stream);
        }
    }
}
