using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_zoo
{
    internal class CsvSerializer : Serializer
    {
        public override void SerializeToFile(string fileName, List<List<(string, object)>> keyValuePairsLists)
        {
            //File.WriteAllText(fileName, dict);
        }
    }
}
