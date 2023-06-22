using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_zoo
{
    internal class CsvFormatter : Formatter
    {
        public override string Format(List<List<(string key, object value)>> keyValuePairsLists)
        {
            IEnumerable<string> formattedValuesLists = keyValuePairsLists.Select(
                keyValuePairs => $"{this.Format(keyValuePairs)}{Environment.NewLine}"
            );

            return string.Join("", formattedValuesLists);
        }

        public override string Format(List<(string key, object value)> keyValuePairs)
        {
            IEnumerable<string> formattedValues = keyValuePairs.Select((keyValuePair) =>
            {
                object value = keyValuePair.value;

                if (value as List<(string, object)> != null)
                {
                    string formattedValue = (string)this.Format((List<(string key, object value)>)value);
                    return $"{formattedValue}";
                }

                return $"{value},";
            });

            return string.Join("", formattedValues);
        }

        public override string Format(List<(string key, object value)> keyValuePairsLists, int depthLevel)
        {
            throw new NotImplementedException();
        }
    }
}
