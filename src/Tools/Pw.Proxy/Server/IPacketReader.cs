using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Pw.Proxy.Server
{
    public interface IPacketReader
    {
        Task<Packet> Read(PipeReader reader, CancellationToken cancellationToken);
    }
}
