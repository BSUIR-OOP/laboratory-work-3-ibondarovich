using laba3.Classes;
using System.Collections.Generic;

namespace laba3.Serialization
{
    public interface ISerialization
    {
        string Serialize(List<Pet> listOfPets);   
        List<Pet> Deserialize(string str);
    }
}