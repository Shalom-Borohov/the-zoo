using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_zoo
{
    internal interface ISerializableObject
    {
        List<(string, object)> Serialize();
    }
}
