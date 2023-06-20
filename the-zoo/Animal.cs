using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_zoo
{
    internal abstract class Animal
    {
        private enum Gender
        {
            Male,
            Female,
            Other,
        }

        private string name { get; set; }
        private int age { get; set; }
        private Gender gender { get; set; }
        private string favoriteHumanWithFirstLetterOfName { get; set; }
    }
}
