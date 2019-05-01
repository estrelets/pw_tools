namespace Pw.Proxy
{
    public class Packet
    {
        public int OpCode { get; set; }
        public byte[] Data { get; set; }
        public Direction Direction { get; set; }
    }
}
