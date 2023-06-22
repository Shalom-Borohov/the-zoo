namespace the_zoo
{
    internal class JsonSerializer : Serializer
    {
        public override void SerializeToFile(string path, string text)
        {
            if (!IsJsonFilePath(path)) throw new Exception("Path suffix should be 'json'.");

            File.WriteAllText(path, text);
        }

        private bool IsJsonFilePath(string path) => path.Split(".")[^1].Equals("json");
    }
}
