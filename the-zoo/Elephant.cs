using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_zoo
{
    internal class Elephant : Animal
    {
        public int TrunkLength { get; set; }
        public int Tusks { get; set; }

        public override List<(string, object)> Serialize()
        {
            List<(string, object)> elephantProps = base.Serialize();
            elephantProps.Add(("TrunkLength", this.TrunkLength));
            elephantProps.Add(("Tusks", this.Tusks));
            elephantProps.Insert(0, ("type", "Elephant"));

            return elephantProps;
        }
    }
}
