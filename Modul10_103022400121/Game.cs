namespace Modul10_103022400121
{
    public class Game
    {
        public int id {  get; set; }
        public string nama { get; set; }
        public string developer { get; set; }
        public int tahunRilis {  get; set; }
        public string genre {  get; set; }
        public double rating { get; set; }
        public string[] platform { get; set; }
        public string[] mode { get; set; }
        public Boolean isOnline {  get; set; }
        public int harga { get; set; }


        public Game(int id, string nama, string developer, int tahunRilis, string genre, double rating, string[] platform, string[] mode, bool isOnline, int harga)
        {
            this.id = id;
            this.nama = nama;
            this.developer = developer;
            this.tahunRilis = tahunRilis;
            this.genre = genre;
            this.rating = rating;
            this.platform = platform;
            this.mode = mode;
            this.isOnline = isOnline;
            this.harga = harga;
        }
    }
}
