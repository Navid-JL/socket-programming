using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDP.Library;

public class Client
{
    public void RunClient()
    {
        using (var client = new UdpClient())
        {
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            int serverPort = 5000;

            Console.Write("Enter a line of characters: ");
            string input = Console.ReadLine() ?? "";

            byte[] data = Encoding.ASCII.GetBytes(input);
            client.Send(data, data.Length, serverIP.ToString(), serverPort);
        }
    }
}
