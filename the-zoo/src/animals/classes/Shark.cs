using the_zoo.src.animals.enums;

namespace the_zoo.src.animals
{

    internal class Shark : Animal
    {

        public SharkSpecies Type { get; set; }
        public bool IsLawyer { get; set; }

        public override string Serialize() =>
            $"{'{'} \"type\": \"Shark\", {base.Serialize().TrimStart('{').TrimEnd('}')}\b, \"Type\": \"{Type}\", \"IsLawyer\": {IsLawyer} {'}'}";
    }
}
