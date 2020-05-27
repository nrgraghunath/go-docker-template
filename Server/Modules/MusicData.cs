namespace Server
{
    public sealed class MusicData 
    {
        private readonly AlbumDetails _albumDetails;
        public MusicData(AlbumDetails albumDetails)
        {
            this._albumDetails = albumDetails;
        }
        public AlbumDetails GetAlbumDetails(AlbumRequest request)
        {
            switch(request.Artist)
            {
                case "HZ":            
                    _albumDetails.AlbumName="Interstellar";
                    _albumDetails.Label="WaterTower Music";
                    _albumDetails.Year="2014";
                break;
                case "Eminem":            
                    _albumDetails.AlbumName="Kamikaze";
                    _albumDetails.Label="Interscope Records";
                    _albumDetails.Year="2018";
                break;
                default:
                break;
            }
            return _albumDetails;
        }
    }
}