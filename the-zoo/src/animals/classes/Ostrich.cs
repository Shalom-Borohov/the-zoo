using System.Text.RegularExpressions;

namespace the_zoo.src.animals
{
    internal class Ostrich : Animal
    {
        public bool IsHeadInGround { get; set; }

        public override string Serialize() =>
            $"{'{'} \"type\": \"Ostrich\", {Regex.Replace(base.Serialize(), "({| })", "")}, \"IsHeadInGround\": \"{IsHeadInGround}\" {'}'}";
    }
}
