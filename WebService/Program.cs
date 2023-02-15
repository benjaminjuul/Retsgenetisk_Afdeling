using DataClass;
using Newtonsoft.Json;


//string url = "myendpoint";

    List<Fruit> Fruits = new List<Fruit>()
            {
                new Fruit { Id = 1, Name = "Apple", Color = "Red", Type = "Fruit", ImageUrl = "apple.jpg" },
                new Fruit { Id = 2, Name = "Banana", Color = "Yellow", Type = "Fruit", ImageUrl = "banana.jpg" },
                new Fruit { Id = 3, Name = "Cherry", Color = "Darkred", Type = "Fruit", ImageUrl = "cherry.jpg" },
                new Fruit { Id = 4, Name = "Dragon fruit", Color = "Red", Type = "Fruit", ImageUrl = "dragon-fruit.jpg" },
                new Fruit { Id = 5, Name = "Figs", Color = "Brown", Type = "Fruit", ImageUrl = "figs.jpg" }
            };

    var json = JsonConvert.SerializeObject(Fruits);

    Console.WriteLine(json);


