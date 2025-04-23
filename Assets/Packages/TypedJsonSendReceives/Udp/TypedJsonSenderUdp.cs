using System.Net;
using UnityEngine;

namespace TypedJsonSendReceives.Udp
{
    public class TypedJsonSenderUdp : AbstractTypedJsonSender
    {
        protected override string GetJsonString<T>(T instance)
        {
            return JsonUtility.ToJson(instance);
        }

        protected override void Send(IPEndPoint iPEndPoint, byte[] data)
        {
            AsyncUdpSender.Send(iPEndPoint, data);
        }
    }
}