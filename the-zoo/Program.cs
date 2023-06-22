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

JsonSerializer jsonSerializer = new JsonSerializer();
CsvSerializer csvSerializer = new CsvSerializer();

IEnumerable<List<(string, object)>> animalsJsons = animals.Select(animal => animal.Serialize());

jsonSerializer.SerializeToFile("animals.json", animalsJsons.ToList());
csvSerializer.SerializeToFile("animals.csv", animalsJsons.ToList());
