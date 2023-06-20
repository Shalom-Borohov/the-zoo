using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_zoo
{
    internal class Shark : Animal
    {
        private enum SharkSpecies
        {
            GreatWhite,
            HammerHead,
            Loan,
        }

        private SharkSpecies type { get; set; }
        private bool isLawyer { get; set; }
    }
}
