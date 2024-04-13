namespace GraphAPI.Models
{
    public class Serie
    {
        public int Id { get; set; }
        public List<SeriesA> SeriesAnime {get; set;}
        public DateTime ReleaseDate {get; set;}
        public List<Plataform> plataform {get; set;}
    }
}