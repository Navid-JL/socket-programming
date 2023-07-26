using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP.Library;

public class Client
{
    public void RunClient()
    {
        using (var client = new TcpClient())
        {
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            int serverPort = 5000;
            client.Connect(serverIP, serverPort);
            Console.Write("Enter a line of characters: ");
            string input = Console.ReadLine() ?? "";
            byte[] data = Encoding.ASCII.GetBytes(input);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            byte[] receivedData = new byte[client.ReceiveBufferSize];
            int bytesRead = stream.Read(receivedData, 0, client.ReceiveBufferSize);
            string modifiedData = Encoding.ASCII.GetString(receivedData, 0, bytesRead);
            Console.WriteLine("Modified data: " + modifiedData);
        }
    }
}
