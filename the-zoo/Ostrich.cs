using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_zoo
{
    internal class Ostrich : Animal
    {
        public bool IsHeadInGround { get; set; }

        public override List<(string, object)> Serialize()
        {
            List<(string, object)> ostrichProps = base.Serialize();
            ostrichProps.Add(("IsHeadInGround", this.IsHeadInGround));
            ostrichProps.Insert(0, ("type", "Ostrich"));

            return ostrichProps;
        }
    }
}
