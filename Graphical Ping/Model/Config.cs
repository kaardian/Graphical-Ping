namespace Graphical_Ping.Model
{
    public class Config
    {
        public int Seconds { get; set; }
        public string HostOrIP { get; set; }
        public int ChartHistory { get; set; }
        public Config()
        {
            Seconds = 1;
            HostOrIP = "8.8.8.8";
            ChartHistory = 30;
        }
    }
}
