namespace the_zoo.src.fileWriters
{
    internal class CsvWriter : IAbleToWrite
    {
        public void WriteToFile(string path, string text)
        {
            if (!IsCsvFilePath(path)) throw new Exception("Path suffix should be 'csv'.");

            File.WriteAllText(path, text);
        }

        private bool IsCsvFilePath(string path) => path.Split(".")[^1].Equals("csv");
    }
}
