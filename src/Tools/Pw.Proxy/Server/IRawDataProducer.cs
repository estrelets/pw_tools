using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Pw.Proxy.Server
{
    public interface IRawDataProducer
    {
        Task Produce(PipeWriter writer, CancellationToken cancellationToken);
    }
}
