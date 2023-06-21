using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_zoo
{
    internal abstract class Serializer
    {
        public abstract void SerializeToFile(string fileName, List<List<(string, object)>> keyValuePairsLists);
    }
}
