using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDP.Library;

public class Server
{
    public void RunServer()
    {
        int serverPort = 5000;

        using (var server = new UdpClient(serverPort))
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                byte[] receivedData = server.Receive(ref clientEndPoint);

                string inputData = Encoding.ASCII.GetString(receivedData);
                string modifiedData = inputData.ToUpper();

                byte[] responseData = Encoding.ASCII.GetBytes(modifiedData);
                server.Send(responseData, responseData.Length, clientEndPoint);
            }
        }
    }
}
