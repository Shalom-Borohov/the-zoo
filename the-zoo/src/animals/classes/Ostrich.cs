namespace the_zoo.src.animals
{
    internal class Ostrich : Animal
    {
        public bool IsHeadInGround { get; set; }

        public override string Serialize() =>
            $"{'{'} \"type\": \"Ostrich\", {base.RemoveBrackets(base.Serialize())}, \"IsHeadInGround\": \"{IsHeadInGround}\" {'}'}";
    }
}
