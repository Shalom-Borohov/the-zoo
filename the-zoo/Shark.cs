using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_zoo
{
    public enum SharkSpecies
    {
        GreatWhite,
        HammerHead,
        Loan,
    }

    internal class Shark : Animal
    {

        public SharkSpecies Type { get; set; }
        public bool IsLawyer { get; set; }

        public override List<(string, object)> Serialize()
        {
            List<(string, object)> sharkProps = base.Serialize();
            sharkProps.Add(("Type", this.Type));
            sharkProps.Add(("IsLawyer", this.IsLawyer));
            sharkProps.Insert(0, ("type", "Shark"));

            return sharkProps;
        }
    }
}
