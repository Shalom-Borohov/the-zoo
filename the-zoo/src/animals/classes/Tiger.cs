namespace the_zoo.src.animals
{
    internal class Tiger : Animal
    {
        public int Stripes { get; set; }
        public int HumansEaten { get; set; }

        public override string Serialize() =>
            $"{'{'} \"type\": \"Tiger\", {base.RemoveBrackets(base.Serialize())}, \"Stripes\": {Stripes}, \"HumansEaten\": {HumansEaten} {'}'}";
    }
}
