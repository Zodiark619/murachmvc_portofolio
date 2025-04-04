namespace murachmvc_portofolio.Models.Chapter2
{
    public class DB
    {
        public static string TFDGacha_Execute(TFDGacha gacha)
        {
            string result = "";
            int a = gacha.Rarities[0];
            int b = gacha.Rarities[1];
            int c = gacha.Rarities[2];
            int d = gacha.Rarities[3];
            int e = gacha.Rarities[4];
            var random = new Random().Next(1, 101);
            int checkpoint1 = a;
            int checkpoint2 = checkpoint1 + b;
            int checkpoint3 = c + checkpoint2;
            int checkpoint4 = checkpoint3 + d;
            int checkpoint5 = e + checkpoint4;



            if (random <= checkpoint1)
            {
                result = $"You received {gacha.Items[0]}";
            }
            else if (random <= checkpoint2)
            {
                result = $"You received {gacha.Items[1]}";

            }
            else if (random <= checkpoint3)
            {
                result = $"You received {gacha.Items[2]}";

            }
            else if (random <= checkpoint4)
            {
                result = $"You received {gacha.Items[3]}";

            }
            else if (random <= checkpoint5)
            {
                result = $"You received {gacha.Items[4]}";

            }
            return result;
        }



        public static List<TFDGacha> GetTFDGachas()
        {
            List<TFDGacha> gachas = new List<TFDGacha>
            {
                new TFDGacha
                {
                    Id = 1,
                    Name="Season 2 Weapons Gacha",
                    Items={ "A-TAMS","Divine Knight","Crystallization Catalyst","Mixed Energy Residue","Advanced Neural Circuit"},
                    Rarities={ 1,1,8,45,45}

                },
                new TFDGacha
                {
                    Id = 2,
                    Name="Season 2 Descendant Gacha",
                    Items={ "Serena","Ultimate Blair","Crystallization Catalyst","Mixed Energy Residue","Advanced Neural Circuit"},
                    Rarities={ 1,1,8,45,45}

                },


            };
            return gachas;
        }
        public static TFDGacha GetTFDGacha(int id)
        {
            List<TFDGacha> modules = DB.GetTFDGachas();
            foreach (TFDGacha p in modules)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return new TFDGacha(); 
        }

    }
}