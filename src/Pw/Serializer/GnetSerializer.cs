using Pw.Serializer.Readers;
using Pw.Serializer.Writers;

namespace Pw.Serializer
{
    public class GnetSerializer : BaseSerializer
    {
        private static readonly IReader GnetReader = new GnetReader();
        private static readonly IWriter GnetWriter = new GnetWriter();
        
        public GnetSerializer() 
            : base(GnetReader, GnetWriter)
        {
        }
    }
}
