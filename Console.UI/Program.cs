Console.WriteLine("Choose 'TCP' or 'UDP':");
string choice = Console.ReadLine() ?? "";

switch (choice.ToLower().Trim())
{
    case "tcp":
        Console.WriteLine("Choose 'Client' or 'Server':");
        choice = Console.ReadLine() ?? "";
        if (choice.ToLower() == "client")
        {
            var clientLogic = new TCP.Library.Client();
            while (true)
            {
                clientLogic.RunClient();
            }
        }
        else if (choice.ToLower() == "server")
        {
            var serverLogic = new TCP.Library.Server();
            while (true)
            {
                serverLogic.RunServer();
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            break;
        }
    case "udp":
        Console.WriteLine("Choose 'Client' or 'Server':");
        choice = Console.ReadLine() ?? "";
        if (choice.ToLower() == "client")
        {
            var clientLogic = new UDP.Library.Client();
            while (true)
            {
                clientLogic.RunClient();
            }
        }
        else if (choice.ToLower() == "server")
        {
            var serverLogic = new UDP.Library.Server();
            while (true)
            {
                serverLogic.RunServer();
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            break;
        }

    default:
        Console.WriteLine("Invalid choice.");
        break;
}
