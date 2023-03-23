namespace StreetApi.Models
{
    public class StreetItem
    {
        public int Id { get; set; }
        public short KommuneKode { get; set; }
        public short VejKode { get; set; }
        public string? VejNavn { get; set; }
    }
}
