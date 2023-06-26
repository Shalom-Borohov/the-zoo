using System.Text.RegularExpressions;

namespace the_zoo.src.animals
{
    internal class Elephant : Animal
    {
        public int TrunkLength { get; set; }
        public int Tusks { get; set; }

        public override string Serialize() =>
            $"{'{'} \"type\": \"Elephant\", {base.RemoveBrackets(base.Serialize())}, \"TrunkLength\": {TrunkLength}, \"Tusks\": {Tusks} {'}'}";
    }
}
