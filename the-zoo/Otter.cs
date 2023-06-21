using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_zoo
{
    internal class Otter : Animal
    {
        public Rock FavoriteRock { get; set; }

        public override List<(string, object)> Serialize()
        {
            List<(string, object)> otterProps = base.Serialize();
            otterProps.Add(("FavoriteRock", this.FavoriteRock.Serialize()));
            otterProps.Insert(0, ("type", "Otter"));

            return otterProps;
        }
    }
}
