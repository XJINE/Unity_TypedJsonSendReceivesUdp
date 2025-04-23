using System.Net.Sockets;

namespace TypedJsonSendReceives.Udp
{
    public class TypedJsonReceiverUdp : TypedJsonReceiver
    {
        public void OnReceive(UdpReceiveResult result)
        {
            base.OnReceive(result.Buffer);
        }
    }
}