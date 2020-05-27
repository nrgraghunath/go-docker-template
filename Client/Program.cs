using System;
using System.Threading.Tasks;
using Grpc.Core;
using Server;
using Grpc.Net.Client;
using Client;
namespace Client
{
    class Program
    {
       static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }
        static async Task  MainAsync(string[] args)
        {
            using var channel = GrpcChannel.ForAddress($"{Constants.Protocol}://{Constants.Host}:{Constants.Port}");
            var client =  new MusicService.MusicServiceClient(channel);
            var reply = await client.GetAlbumDetailsAsync(
            new AlbumRequest { Artist = "HZ" });
            Console.WriteLine($"Album : {reply.AlbumName}, released by : {reply.Label} on {reply.Year}");
            Console.WriteLine("Press any key to exit..."); Console.ReadKey();
        }
    }
}
