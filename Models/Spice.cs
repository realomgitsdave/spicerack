namespace spicerack.Models
{
    public class Spice
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public decimal? Price { get; set; }
        public decimal? OuncesTotal { get; set; }
        public decimal? OuncesRemaining { get; set; }
        public int? Rating { get; set; }
        public List<string>? Tags { get; set; }

        public virtual ICollection<Rub>? Rubs { get; set; }
    }
}