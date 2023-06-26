using the_zoo.src.animals;
using the_zoo.src.misc.enums;
using the_zoo.src.animals.enums;
using the_zoo.src.misc;
using the_zoo.src.fileWriters;
using the_zoo.src.misc.classes;

namespace the_zoo.src.main
{
    internal class TheZoo
    {
        public void Start()
        {
            var root = Directory.GetCurrentDirectory();
            var dotenv = Path.Combine(root, ".env");
            DotEnv.Load(dotenv);

            List<ISerializableObject> animals = CreateZoo();
            var jsonSerializer = new JsonSerializer();
            var csvSerializer = new CsvSerializer();

            string animalsJson = jsonSerializer.Serialize(animals);
            string animalsCsv = csvSerializer.Serialize(animals);

            var jsonWriter = new JsonWriter();
            var csvWriter = new CsvWriter();

            string jsonFilePath = Environment.GetEnvironmentVariable("JSON_FILE_PATH");
            string csvFilePath = Environment.GetEnvironmentVariable("CSV_FILE_PATH");

            jsonWriter.WriteToFile(jsonFilePath, animalsJson);
            csvWriter.WriteToFile(csvFilePath, animalsCsv);
        }

        private List<ISerializableObject> CreateZoo() => new List<ISerializableObject>
            {
                new Chameleon {CurrentColor = "Blue", Name = "Lizi", Age = 12, Gender = Gender.Male, FavoriteHumanName = "Liron" },
                new Elephant {Name = "Pili", Age = 100, Gender = Gender.Female, FavoriteHumanName = "Piron", TrunkLength = 10, Tusks = 1 },
                new Ostrich {Name = "Osti", Age = 40, Gender = Gender.Female, FavoriteHumanName = "Osnat", IsHeadInGround = true},
                new Otter {Name = "Moshe", Age = 10, Gender = Gender.Male, FavoriteHumanName = "Mike", FavoriteRock = new Rock { Weight = 3 } },
                new Shark {Name = "Amnon", Age = 30, Gender = Gender.Female, FavoriteHumanName = "Amit", IsLawyer = true, Type = SharkSpecies.Loan},
                new Tiger {Name = "Tigi", Age = 23, Gender = Gender.Male, FavoriteHumanName = "Tom", Stripes = 50, HumansEaten = 3},
            };

    }
}
