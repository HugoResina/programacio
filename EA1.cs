using System;
using System.Net.WebSockets;
using EA1_M6_Persistencia;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Program
{
    public static void Main()
    {
       
        LLegirProd1();
        EscriureProd1();
    }
    public static void LLegirProd1()
    {
        string path = "FitxersJSON\\products1.json";
        using (StreamReader jsonStream = File.OpenText(path))
        {
            string product;
            while((product = jsonStream.ReadLine()) != null)
            {
                Product product1 = JsonConvert.DeserializeObject<Product>(product);
                string json = JsonConvert.SerializeObject(product1);
                Console.WriteLine(json);
            }
        }
    }
    public static void EscriureProd1()
    {
        string path = "FitxersJSON\\products1.json";
        var product1 = new Product
        {
            Name = "Soccer Ball",
            Price = 10,
            Stock = 150,
            Picture = "SoccerBall.img",
            Categories = new[] { "Sports Ball", "Soccer" }
        };

        var product2 = new Product
        {
            Name = "Jumping rope",
            Price = 5,
            Stock = 20,
            Picture = "JumpingRope.img",
            Categories = new[] { "Sports"}
        };
        var product3 = new Product
        {
            Name = "Baseball bat",
            Price = 45,
            Stock = 200,
            Picture = "BaseballBat.img",
            Categories = new[] { "Sports Bat", "Wooden Bat" }
        };
        var product4 = new Product
        {
            Name = "Basketball",
            Price = 25,
            Stock = 75,
            Picture = "Basketball.img",
            Categories = new[] { "Sports Ball", "Basketball" }
        };
        var product5 = new Product
        {
            Name = "Rugby ball",
            Price = 20,
            Stock = 50,
            Picture = "RugbyBall.img",
            Categories = new[] { "Sports Ball", "Rugby" }
        };


        string json1 = JsonConvert.SerializeObject(product1);
        string json2 = JsonConvert.SerializeObject(product2);
        string json3 = JsonConvert.SerializeObject(product3);
        string json4 = JsonConvert.SerializeObject(product4);
        string json5 = JsonConvert.SerializeObject(product5);

        FileStream file = new FileStream("FitxersJSON/products1.json", FileMode.Open, FileAccess.Write);
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.BaseStream.Seek(file.Length, SeekOrigin.Current);

            sw.WriteLine(json1);
            sw.WriteLine(json2);
            sw.WriteLine(json3);
            sw.WriteLine(json4);
            sw.WriteLine(json5);
        }

    }
    public static void LLegirProd2()
    {
        string path = "FitxersJSON\\products1.json";
        using (StreamReader jsonStream = File.OpenText(path))
        {
            string product;
            while ((product = jsonStream.ReadLine()) != null)
            {
                Product2 product2 = JsonConvert.DeserializeObject<Product2>(product);
                string json = JsonConvert.SerializeObject(product2);
                
                Console.WriteLine(json);
            }
        }
    }
    public static void EscriureProd2()
    {
        string path = "FitxersJSON\\products1.json";
        var product1 = new Product2
        {
            Name = "Soccer Ball",
            Price = 10,
            Stock = 150,
            Picture = "SoccerBall.img",
            Categories = new Category[] {new Category { id = 6, name = "soccer Ball"}, new Category { id = 7, name = "SportsBall"} } 
        };

        var product2 = new Product2
        {
            Name = "Jumping rope",
            Price = 5,
            Stock = 20,
            Picture = "JumpingRope.img",
            Categories = new Category[] {new Category { id = 8, name = "jumping rope"} }
        };
        var product3 = new Product2
        {
            Name = "Baseball bat",
            Price = 45,
            Stock = 200,
            Picture = "BaseballBat.img",
            Categories = new Category[] {new Category { id = 9, name = "baseball bat"}, new Category{id = 10, name = "wooden bat" } }
        };
        var product4 = new Product2
        {
            Name = "Basketball",
            Price = 25,
            Stock = 75,
            Picture = "Basketball.img",
            Categories = new Category[] {new Category { id = 11, name = "basket Ball"}, new Category { id = 12, name = "sportsBall"} }
        };
        var product5 = new Product2
        {
            Name = "Rugby ball",
            Price = 20,
            Stock = 50,
            Picture = "RugbyBall.img",
            Categories = new Category[] { new Category { id = 13,name = "rugby ball"}, new Category {id = 14, name = "sportsBall" } }
        };


        string json1 = JsonConvert.SerializeObject(product1);
        string json2 = JsonConvert.SerializeObject(product2);
        string json3 = JsonConvert.SerializeObject(product3);
        string json4 = JsonConvert.SerializeObject(product4);
        string json5 = JsonConvert.SerializeObject(product5);

        FileStream file = new FileStream(@"/FitxersJSON/products1.json", FileMode.Open, FileAccess.Write);
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.BaseStream.Seek(file.Length, SeekOrigin.Current);

            sw.WriteLine(json1);
            sw.WriteLine(json2);
            sw.WriteLine(json3);
            sw.WriteLine(json4);
            sw.WriteLine(json5);
        }

    }
}