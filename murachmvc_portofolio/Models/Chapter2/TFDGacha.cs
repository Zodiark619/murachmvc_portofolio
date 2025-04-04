namespace murachmvc_portofolio.Models.Chapter2
{
    public class TFDGacha
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;



        public List<string> Items { get; set; } = new List<string>();
        public List<int> Rarities { get; set; } = new List<int>();

        }

    
}
