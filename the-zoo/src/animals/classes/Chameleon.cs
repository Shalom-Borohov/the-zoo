namespace the_zoo.src.animals
{
    internal class Chameleon : Animal
    {
        public string CurrentColor { get; set; }

        public override string Serialize() =>
            $"{'{'} \"type\": \"Chameleon\", {base.Serialize().TrimStart('{').TrimEnd('}')}\b, \"CurrentColor\": \"{CurrentColor}\" {'}'}";

    }
}
