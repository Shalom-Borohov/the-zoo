using System.Text.RegularExpressions;
using the_zoo.src.animals.enums;

namespace the_zoo.src.animals
{

    internal class Shark : Animal
    {

        public SharkSpecies Type { get; set; }
        public bool IsLawyer { get; set; }

        public override string Serialize() =>
            $"{'{'} \"type\": \"Shark\", {Regex.Replace(base.Serialize(), "({| })", "")}, \"Type\": \"{Type}\", \"IsLawyer\": {IsLawyer} {'}'}";
    }
}
