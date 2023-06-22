using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_zoo
{
    internal abstract class Formatter
    {
        public abstract string Format(List<List<(string key, object value)>> keyValuePairsLists);
        public abstract string Format(List<(string key, object value)> keyValuePairsLists);
        public abstract string Format(List<(string key, object value)> keyValuePairsLists, int depthLevel);
    }
}
