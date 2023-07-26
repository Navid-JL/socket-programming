using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP.Library;

public class Server
{
    public void RunServer()
    {
        int serverPort = 5000;

        TcpListener server = new TcpListener(IPAddress.Any, serverPort);
        server.Start();

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();

            NetworkStream stream = client.GetStream();
            byte[] receivedData = new byte[client.ReceiveBufferSize];
            int bytesRead = stream.Read(receivedData, 0, client.ReceiveBufferSize);

            string inputData = Encoding.ASCII.GetString(receivedData, 0, bytesRead);
            string modifiedData = inputData.ToUpper();

            byte[] responseData = Encoding.ASCII.GetBytes(modifiedData);
            stream.Write(responseData, 0, responseData.Length);

            client.Close();
        }
    }
}
