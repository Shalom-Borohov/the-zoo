using System.Text.RegularExpressions;

namespace the_zoo
{
    internal class CsvSerializer
    {
        public string Serialize(List<ISerializableObject> serializables)
        {
            IEnumerable<string> serializedObjects = serializables.Select((serializable) => serializable.Serialize());
            string json = string.Join(Environment.NewLine, serializedObjects);

            return RemoveKeysAndBrackets(json);
        }

        private string RemoveKeysAndBrackets(string json) => Regex.Replace(json, "(\".[^\"]+\": )|({ | }|\")", "");
    }
}
