namespace the_zoo.src.misc
{
    internal class Rock : ISerializableObject
    {
        public int Weight { get; set; }

        public string Serialize() =>
            $"{'{'} \"Weight\": {Weight} {'}'}";
    }
}
