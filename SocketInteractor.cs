using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RSASignatureApplication1
{
    public class SocketInteractor
    {
        private readonly IPEndPoint _remoteEndPoint;
        private readonly TcpClient _client;

        public SocketInteractor()
        {
            var ipHostInfo = Dns.GetHostEntry("127.0.0.1");
            var ipAddress = ipHostInfo.AddressList[0];
            _remoteEndPoint = new IPEndPoint(ipAddress, 11000);
            _client = new TcpClient(ipAddress.AddressFamily);
        }

        public void Connect()
        {
            _client.Connect(_remoteEndPoint);
        }

        public void Send(string text)
        {
            var msg = Encoding.ASCII.GetBytes(text);
            _client.GetStream().Write(msg, 0, msg.Length);
        }

        public void Close()
        {
            _client.Close();
        }
    }
}