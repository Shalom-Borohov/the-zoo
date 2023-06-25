using the_zoo.src.animals;
using the_zoo.src.misc.enums;
using the_zoo.src.animals.enums;
using the_zoo.src.misc;
using the_zoo.src.fileWriters;

namespace the_zoo.src.main
{
    internal class TheZoo
    {
        public void Start()
        {
            var animals = new List<ISerializableObject>
            {
                new Chameleon {CurrentColor = "Blue", Name = "Lizi", Age = 12, Gender = Gender.Male, FavoriteHumanName = "Liron" },
                new Elephant {Name = "Pili", Age = 100, Gender = Gender.Female, FavoriteHumanName = "Piron", TrunkLength = 10, Tusks = 1 },
                new Ostrich {Name = "Osti", Age = 40, Gender = Gender.Female, FavoriteHumanName = "Osnat", IsHeadInGround = true},
                new Otter {Name = "Moshe", Age = 10, Gender = Gender.Male, FavoriteHumanName = "Mike", FavoriteRock = new Rock { Weight = 3 } },
                new Shark {Name = "Amnon", Age = 30, Gender = Gender.Female, FavoriteHumanName = "Amit", IsLawyer = true, Type = SharkSpecies.Loan},
                new Tiger {Name = "Tigi", Age = 23, Gender = Gender.Male, FavoriteHumanName = "Tom", Stripes = 50, HumansEaten = 3},
            };

            var jsonSerializer = new JsonSerializer();
            var csvSerializer = new CsvSerializer();

            string animalsJson = jsonSerializer.Serialize(animals);
            string animalsCsv = csvSerializer.Serialize(animals);

            var jsonWriter = new JsonWriter();
            var csvWriter = new CsvWriter();

            Console.WriteLine(animalsCsv);

            jsonWriter.WriteToFile("animals.json", animalsJson);
        }
    }
}
