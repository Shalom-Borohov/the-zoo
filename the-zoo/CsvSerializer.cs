namespace the_zoo
{
    internal class CsvSerializer : Serializer
    {
        public override void SerializeToFile(string path, List<List<(string, object)>> keyValuePairsLists)
        {
            IEnumerable<string> formattedValuesLists = keyValuePairsLists.Select(
                keyValuePairs => $"{this.SerialzeToCsv(keyValuePairs)}{Environment.NewLine}"
            );

            string commaSeparatedValues = string.Join("", formattedValuesLists);
            string exceptionMessage = "Serialization to CSV file failed.";

            try
            {
                if (!path.Split(".")[^1].Equals("csv")) throw new Exception("Path suffix should be 'csv'.");
                File.WriteAllText(path, commaSeparatedValues);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{exceptionMessage} {ex.Message}");
            }
        }

        private object SerialzeToCsv(List<(string key, object value)> keyValuePairs)
        {
            IEnumerable<string> formattedValues = keyValuePairs.Select((keyValuePair) =>
            {
                object value = keyValuePair.value;

                if (value as List<(string, object)> != null)
                {
                    string formattedValue = (string)this.SerialzeToCsv((List<(string key, object value)>)value);
                    return $"{formattedValue}";
                }

                return $"{value},";
            });

            return string.Join("", formattedValues);
        }
    }
}
