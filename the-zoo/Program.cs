using the_zoo;

List<Animal> animals = new List<Animal>
{
    new Chameleon {CurrentColor = "Blue", Name = "Lizi", Age = 12, Gender = Gender.Male, FavoriteHumanName = "Liron" },
    new Elephant {Name = "Pili", Age = 100, Gender = Gender.Female, FavoriteHumanName = "Piron", TrunkLength = 10, Tusks = 1 },
    new Ostrich {Name = "Osti", Age = 40, Gender = Gender.Female, FavoriteHumanName = "Osnat", IsHeadInGround = true},
    new Otter {Name = "Moshe", Age = 10, Gender = Gender.Male, FavoriteHumanName = "Mike", FavoriteRock = new Rock { Weight = 3 } },
    new Shark {Name = "Amnon", Age = 30, Gender = Gender.Female, FavoriteHumanName = "Amit", IsLawyer = true, Type = SharkSpecies.Loan},
    new Tiger {Name = "Tigi", Age = 23, Gender = Gender.Male, FavoriteHumanName = "Tom", Stripes = 50, HumansEaten = 3},
};

IEnumerable<List<(string, object)>> animalsKeyValuePairsEnumerable = animals.Select(animal => animal.Serialize());
List<List<(string, object)>> animalsKeyValuePairsLists = animalsKeyValuePairsEnumerable.ToList();

JsonFormatter jsonFormatter = new JsonFormatter();
CsvFormatter csvFormatter = new CsvFormatter();

string json = jsonFormatter.Format(animalsKeyValuePairsLists);
string csv = csvFormatter.Format(animalsKeyValuePairsLists);

JsonSerializer jsonSerializer = new JsonSerializer();
CsvSerializer csvSerializer = new CsvSerializer();

jsonSerializer.SerializeToFile("animals.json", json);
csvSerializer.SerializeToFile("animals.csv", csv);
