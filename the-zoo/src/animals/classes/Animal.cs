using System.Text.RegularExpressions;
using the_zoo.src.misc.enums;

namespace the_zoo.src.animals
{
    internal abstract class Animal : ISerializableObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string FavoriteHumanName { get; set; }

        public virtual string Serialize() =>
            $"{'{'}\"Name\": \"{Name}\", \"Age\": {Age}, \"Gender\": \"{Gender}\", \"FavoriteHumanName\": \"{FavoriteHumanName}\" {'}'}";

        public virtual string RemoveBrackets(string json) => Regex.Replace(json, "({| })", "");
    }
}
