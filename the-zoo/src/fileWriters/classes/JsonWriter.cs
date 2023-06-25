namespace the_zoo.src.fileWriters
{
    internal class JsonWriter : IAbleToWrite
    {
        public void WriteToFile(string path, string text)
        {
            if (!IsJsonFilePath(path)) throw new Exception("Path suffix should be 'json'.");

            File.WriteAllText(path, text);
        }

        private bool IsJsonFilePath(string path) => path.Split(".")[^1].Equals("json");
    }
}
