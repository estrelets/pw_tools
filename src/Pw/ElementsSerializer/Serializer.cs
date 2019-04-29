using System.IO;

namespace Pw.ElementsSerializer
{
    public class Serializer
    {
        public void Serialize<TObject>(TObject obj, Stream stream)
        {
            var plan = PlansCache.Instance.GetPlan<TObject>();
            plan.Serialize(obj, stream);
        }

        public TObject DeSerialize<TObject>(Stream stream)
        {
            var plan = PlansCache.Instance.GetPlan<TObject>();
            return (TObject)plan.Deserialize(null, stream);
        }
    }
}
