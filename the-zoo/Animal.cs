using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_zoo
{
    public enum Gender
    {
        Male,
        Female,
    }

    internal class Animal : ISerializableObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string FavoriteHumanName { get; set; }

        public virtual List<(string, object)> Serialize()
        {
            List<(string, object)> animalProps = new List<(string, object)>()
            {
                ("Name", this.Name),
                ("Age", this.Age),
                ("Gender", this.Gender),
                ("FavoriteHumanName", this.FavoriteHumanName)
            };


            return animalProps;
        }
    }
}
