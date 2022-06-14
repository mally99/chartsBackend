namespace MyWebApi.Models
{
    public class ChartValues
    {
        public string x { get; set; }
        public int y { get; set; }
        public ChartValues(string x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}