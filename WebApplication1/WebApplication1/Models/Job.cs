namespace WebApplication1.Models
{
    public class Job
    {
        public Field Field { get; set; }
        public string Requirements { get; set; }
        public int ScopeOfHours { get; set; }
        public string Area { get; set; }
        public bool Hybrid { get; set; }
    }
    public enum Field { QA, Client, Server}
}
