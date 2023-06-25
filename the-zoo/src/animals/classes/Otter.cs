using System.Text.RegularExpressions;
using the_zoo.src.misc;

namespace the_zoo.src.animals
{
    internal class Otter : Animal
    {
        public Rock FavoriteRock { get; set; }

        public override string Serialize() =>
            $"{'{'} \"type\": \"Otter\", {Regex.Replace(base.Serialize(), "({| })", "")}, \"FavoriteRock\": {FavoriteRock.Serialize()} {'}'}";
    }
}
