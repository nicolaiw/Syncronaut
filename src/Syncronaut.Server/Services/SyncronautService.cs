using Grpc.Core;
using Syncronaut.Server;

namespace Syncronaut.Server.Services
{
    public class SyncronautService : Syncronaut.SyncronautBase
    {
        private readonly ILogger<SyncronautService> _logger;
        public SyncronautService(ILogger<SyncronautService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
