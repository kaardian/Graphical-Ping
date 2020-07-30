namespace Graphical_Ping.Model
{
    /// <summary>
    /// Configuration class that can be updated in runtime.
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Seconds between pings. By default 1.
        /// </summary>
        public int Seconds { get; set; }

        /// <summary>
        /// Host or IP address to ping. By defaut 8.8.8.8
        /// </summary>
        public string HostOrIP { get; set; }

        /// <summary>
        /// How many items chart holds, not realted to seconds.
        /// </summary>
        public int ChartHistory { get; set; }
        
        /// <summary>
        /// Constructor that initialized default values.
        /// </summary>
        public Config()
        {
            Seconds = 1;
            HostOrIP = "8.8.8.8";
            ChartHistory = 30;
        }
    }
}
