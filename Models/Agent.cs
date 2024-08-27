namespace MossadMVC.Models
{
    public class Agent
    {
        public Guid? Id { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public string? Status { get; set; }
        public int? kills { get; set; } = 0;
    }
}
