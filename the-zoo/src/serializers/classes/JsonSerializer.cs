using System.Text.RegularExpressions;
using the_zoo.src.serializers.interfaces;

namespace the_zoo
{
    internal class JsonSerializer : IAbleToSerialize
    {
        public string Serialize(List<ISerializableObject> serializables)
        {
            IEnumerable<string> serializedObjects = serializables.Select((serializable) => serializable.Serialize());
            WrapInJsonArray(serializedObjects);
            string jsonArray = WrapInJsonArray(serializedObjects);
            string linedJson = AddNewLines(jsonArray);
            string indentedPropsJson = IndentProperties(linedJson);
            string indentedNestedPropsJson = IndentNestedProperties(indentedPropsJson);

            return IndentObjects(indentedNestedPropsJson);
        }

        private string WrapInJsonArray(IEnumerable<string> serializedObjects) =>
            $"[{Environment.NewLine}{string.Join($",{Environment.NewLine}", serializedObjects)}{Environment.NewLine}]";

        private string AddNewLines(string json) =>
            Regex.Replace(json, "(,|{) | ([}][,]?)", $"$1{Environment.NewLine}$2", RegexOptions.Multiline);

        private string IndentProperties(string json) =>
            Regex.Replace(json, "(^[\"])", "\t$1", RegexOptions.Multiline);

        private string IndentNestedProperties(string json) =>
            Regex.Replace(json, "(?s)(?<=: {\r\n)(.+?)(?=})", $"\t$1\t", RegexOptions.Multiline);

        private string IndentObjects(string json) =>
            Regex.Replace(json, "(^[{]|^[}]|^[\t])", $"\t$1", RegexOptions.Multiline);
    }
}
