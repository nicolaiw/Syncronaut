using Grpc.Net.Client;
using Syncronaut.Core.Services;

namespace Syncronaut.Client.Console;

internal class Program
{
    static async Task Main(string[] args)
    {
        //using(var fileStream = File.Create(@"E:\temp\test_smaller.txt"))
        //{
        //    await fileStream.WriteAsync([1, 2, 3, 4, 5], 0, 5);
        //}

        //using (var fileStream = File.Create(@"E:\temp\test_bigger.txt"))
        //{
        //    await fileStream.WriteAsync([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14], 0, 14);
        //}

        //using (var fileStream = File.Create(@"E:\temp\test_diff.txt"))
        //{
        //    await fileStream.WriteAsync([2, 1, 3, 4, 5, 6, 8, 7, 9, 11], 0, 10);
        //}

        //var fileBytes = await File.ReadAllBytesAsync(@"E:\temp\test.txt");

        //var fileChunkInfos = FileService.CalculateFileChunkInfos(fileBytes, 4).ToList();

        /*
         
            1. File changed
            2. Send FileChunkInfos of the changed file to the server
            3. Send back the FileChunkInfos which changed so the client knows
               which file parts needs do be send to the server
            4. Client sends changed/deleted/new parts to the server
         
         */

        //;
        //using var channel = GrpcChannel.ForAddress("https://localhost:7278");

        //var client = new Syncronaut.SyncronautClient(channel);

        //var result = await client.SayHelloAsync(new HelloRequest { Name = "client" });

        //System.Console.WriteLine(result.Message);

        System.Console.ReadKey();
    }
}
