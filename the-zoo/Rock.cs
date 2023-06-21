using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_zoo
{
    internal class Rock : ISerializableObject
    {
        public int Weight { get; set; }

        public List<(string, object)> Serialize()
        {
            List<(string, object)> rockProps = new List<(string, object)>() { ("Weight", this.Weight) };

            return rockProps;
        }

    }
}
