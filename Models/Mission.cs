namespace MossadMVC.Models
{
    public class Mission
    {
        public Guid? Id { get; set; }
        public Agent? Agent { get; set; }
        public Target? Target { get; set; }
        public Double Time { get; set; }
        public DateTime killingTime { get; set; }
        public string? Status { get; set; }
    }
}
