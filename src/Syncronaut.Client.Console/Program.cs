using Grpc.Net.Client;

namespace Syncronaut.Client.Console;

internal class Program
{
    static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:7278");

        var client = new Syncronaut.SyncronautClient(channel);

        var result = await client.SayHelloAsync(new HelloRequest { Name = "client" });

        System.Console.WriteLine(result.Message);

        System.Console.ReadKey();
    }
}
