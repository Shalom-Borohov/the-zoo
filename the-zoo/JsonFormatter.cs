namespace the_zoo
{
    internal class JsonFormatter : Formatter
    {
        public override string Format(List<List<(string key, object value)>> keyValuePairsLists)
        {
            IEnumerable<string> jsonLists = keyValuePairsLists.Select(FormatAndAddNewLine);
            return FormatAsArray(jsonLists);
        }

        public override string Format(List<(string key, object value)> keyValuePairs, int depthLevel)
        {
            IEnumerable<string> formattedKeyValuePairs = keyValuePairs.Select((keyValuePair) => FormatKeyValuePair(keyValuePair, 1));
            string depthLevelTabs = new String('\t', depthLevel);
            string newLine = Environment.NewLine;
            return $"{depthLevelTabs}{"{"}{newLine}{string.Join($",{newLine}", formattedKeyValuePairs)}{newLine}{depthLevelTabs}{"},"}";
        }

        public override string Format(List<(string key, object value)> keyValuePairsLists)
        {
            throw new NotImplementedException();
        }

        private string FormatAndAddNewLine(List<(string key, object value)> keyValuePairs) =>
            $"{Format(keyValuePairs, 1)}{Environment.NewLine}";

        private string FormatAsArray(IEnumerable<string> jsonLists) =>
            $"[{Environment.NewLine}{string.Join("", jsonLists)}]";


        private string FormatKeyValuePair((string key, object value) keyValuePair, int depthLevel)
        {
            string key = keyValuePair.key;
            object value = ShouldFormatValueFurther(keyValuePair.value) ?
                Format((List<(string key, object value)>)keyValuePair.value, depthLevel + 1) : keyValuePair.value;
            return $"{new String('\t', depthLevel + 1)}\"{key}\": {value}";
        }

        private bool ShouldFormatValueFurther(object value) => value as List<(string key, object value)> != null;
    }
}
