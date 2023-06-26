using the_zoo.src.misc;

namespace the_zoo.src.animals
{
    internal class Otter : Animal
    {
        public Rock FavoriteRock { get; set; }

        public override string Serialize() =>
            $"{'{'} \"type\": \"Otter\", {base.RemoveBrackets(base.Serialize())}, \"FavoriteRock\": {FavoriteRock.Serialize()} {'}'}";
    }
}
