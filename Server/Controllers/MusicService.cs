using System.Threading.Tasks;
using Grpc.Core;
namespace Server
{
    public sealed class MusicImpl : MusicService.MusicServiceBase
    {
        private MusicData _musicData;

        public MusicImpl(){}

        public override Task<AlbumDetails> GetAlbumDetails(AlbumRequest request, ServerCallContext context)
        {
            this._musicData = new MusicData(new AlbumDetails());
            return Task.FromResult(_musicData.GetAlbumDetails(request));
        }
    }
}