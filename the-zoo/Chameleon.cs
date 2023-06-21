using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_zoo
{
    internal class Chameleon : Animal
    {
        public string CurrentColor { get; set; }

        public override List<(string, object)> Serialize()
        {
            List<(string, object)> chameleonProps = base.Serialize();
            chameleonProps.Add(("CurrentColor", this.CurrentColor));
            chameleonProps.Insert(0, ("type", "Chameleon"));

            return chameleonProps;
        }
    }
}
