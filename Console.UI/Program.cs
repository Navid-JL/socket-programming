Console.WriteLine("Choose 'client' or 'server':");
string choice = Console.ReadLine() ?? "";

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
}
