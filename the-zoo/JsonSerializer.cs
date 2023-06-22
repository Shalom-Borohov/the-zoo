namespace the_zoo
{
    internal class JsonSerializer : Serializer
    {
        public override void SerializeToFile(string path, List<List<(string, object)>> keyValuePairsLists)
        {
            IEnumerable<string> formattedKeyValuePairsLists = keyValuePairsLists.Select(
                keyValuePairs => $"{this.SerializeToJson(keyValuePairs, 1)}{Environment.NewLine}"
            );

            string json = $"[{Environment.NewLine}{string.Join("", formattedKeyValuePairsLists)}]";
            string exceptionMessage = "Serialization to JSON file failed.";

            try
            {
                if (!path.Split(".")[^1].Equals("json")) throw new Exception("Path suffix should be 'json'.");
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{exceptionMessage} {ex.Message}");
            }
        }

        private string SerializeToJson(List<(string key, object value)> keyValuePairs, int depthLevel)
        {
            IEnumerable<string> formattedKeyValuePairs = keyValuePairs.Select((keyValuePair) =>
            {
                string key = keyValuePair.key;
                object value = keyValuePair.value;

                if (value as List<(string, object)> != null)
                {
                    string formattedValue = this.SerializeToJson((List<(string key, object value)>)value, depthLevel + 1);
                    return $"{new String('\t', depthLevel + 1)}\"{key}\": {formattedValue}";
                }

                return $"{new String('\t', depthLevel + 1)}\"{key}\": {value}";
            });

            string formattedJson = $"{new String('\t', depthLevel)}{"{"}{Environment.NewLine}{string.Join($",{Environment.NewLine}", formattedKeyValuePairs)}{Environment.NewLine}{new String('\t', depthLevel)}{"},"}";
            return formattedJson;
        }
    }
}
