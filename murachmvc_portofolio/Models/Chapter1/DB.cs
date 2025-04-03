namespace murachmvc_portofolio.Models.Chapter1
{
    public class DB
    {
        public static List<Module> GetModules()
        {
            List<Module> modules = new List<Module>
            {
                new Module
                {
                    Id = 1,
                    Name="Rifling Reinforcement",
                    Rarity="Standard",
                  
                    Socket="Malachite"

                },

                new Module
                {
                    Id = 2,
                    Name="Chill Enhancement",
                    Rarity="Standard",

                    Socket="Cerulean"

                },

                new Module
                {
                    Id = 3,
                    Name="Lethal Finish",
                    Rarity="Ultimate",

                    Socket="Almandine"

                },

                new Module
                {
                    Id = 4,
                    Name="Absolute Zero",
                    Rarity="Descendant",

                    Socket="Xantic"

                },

            };
            return modules;
        }
        public static Module GetModule(int id)
        {
            List<Module> modules = DB.GetModules();
            foreach (Module p in modules)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return new Module(); // return empty Product if not in list
        }


        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    Name = "Fender Stratocaster",
                    Price = (decimal)699.00
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Gibson Les Paul",
                    Price = (decimal)1199.00
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Gibson SG",
                    Price = (decimal)2517.00
                },
                new Product
                {
                    ProductID = 4,
                    Name = "Yamaha FG700S",
                    Price = (decimal)489.99
                },
                new Product
                {
                    ProductID = 5,
                    Name = "Washburn D10S",
                    Price = (decimal)299.00
                },
                new Product
                {
                    ProductID = 6,
                    Name = "Rodriguez Caballero 11",
                    Price = (decimal)415.00
                },
                new Product
                {
                    ProductID = 7,
                    Name = "Fender Precision",
                    Price = (decimal)799.99
                },
                new Product
                {
                    ProductID = 8,
                    Name = "Hofner Icon",
                    Price = (decimal)499.99
                },
                new Product
                {
                    ProductID = 9,
                    Name = "Ludwig 5-piece Drum Set with Cymbals",
                    Price = (decimal)699.99
                },
                new Product
                {
                    ProductID = 10,
                    Name = "Tama 5-Piece Drum Set with Cymbals",
                    Price = (decimal)799.99
                }
            };
            return products;
        }

        public static Product GetProduct(int id)
        {
            List<Product> products = DB.GetProducts();
            foreach (Product p in products)
            {
                if (p.ProductID == id)
                {
                    return p;
                }
            }
            return new Product(); // return empty Product if not in list
        }
    }
}