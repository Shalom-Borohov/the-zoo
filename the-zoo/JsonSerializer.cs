using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace the_zoo
{
    internal class JsonSerializer : Serializer
    {
        public override void SerializeToFile(string fileName, List<List<(string, object)>> keyValuePairsLists)
        {
            IEnumerable<string> formattedKeyValuePairsLists = keyValuePairsLists.Select(
                keyValuePairs => $"{this.SerializeToJson(keyValuePairs)}{Environment.NewLine}"
            );

            Console.WriteLine($"[{Environment.NewLine}{string.Join("", formattedKeyValuePairsLists)}{Environment.NewLine}]");
        }

        private string SerializeToJson(List<(string key, object value)> keyValuePairs)
        {
            IEnumerable<string> formattedKeyValuePairs = keyValuePairs.Select((keyValuePair) =>
            {
                string key = keyValuePair.key;
                object value = keyValuePair.value;

                if (value as List<(string, object)> != null)
                {
                    string formattedValue = this.SerializeToJson((List<(string key, object value)>)value);
                    return $"\t\t\"{key}\": {formattedValue}";
                }

                return $"\t\t\"{key}\": {value}";
            });

            string formattedJson = $"\t{"{"}{Environment.NewLine}{string.Join($",{Environment.NewLine}", formattedKeyValuePairs)}{Environment.NewLine}\t{"},"}";
            return formattedJson;
        }
    }
}
