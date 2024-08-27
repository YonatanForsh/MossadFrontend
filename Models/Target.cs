namespace MossadMVC.Models
{
    public class Target
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string? Picture { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Status { get; set; }
    }
}
