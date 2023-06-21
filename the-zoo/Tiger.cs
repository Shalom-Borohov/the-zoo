using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_zoo
{
    internal class Tiger : Animal
    {
        public int Stripes { get; set; }
        public int HumansEaten { get; set; }

        public override List<(string, object)> Serialize()
        {
            List<(string, object)> tigerProps = base.Serialize();
            tigerProps.Add(("Stripes", this.Stripes));
            tigerProps.Add(("HumansEaten", this.HumansEaten));
            tigerProps.Insert(0, ("type", "Tiger"));

            return tigerProps;
        }
    }
}
