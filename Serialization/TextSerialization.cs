using System;
using laba3.Classes;
using System.Collections.Generic;
using System.Reflection;

namespace laba3.Serialization
{
    public class TextSerialization : ISerialization
    {
        public string Serialize(List<Pet> listOfPets)
        {
            string str = string.Empty;
            foreach(var item in listOfPets)
            {
                str += "{";
                Type type = item.GetType();
                str += $"'Type': {type},";

                foreach(var filed in type.GetFields())
                {
                    if(filed.GetType() == typeof(int) )
                        str += $" '{filed.Name}': {filed.GetValue(item)},";
                    else
                        str += $" '{filed.Name}': \"{filed.GetValue(item)}\",";
                } 
                foreach(var property in type.GetProperties())
                {
                    if(property.GetType() == typeof(string) )
                        str += $" '{property.Name}': \"{property.GetValue(item)}\",";
                    else
                        str += $" '{property.Name}': {property.GetValue(item)},";
                }
                str = str.Remove(str.Length - 1);
                str+="}\r\n";
            }

            return str;
        }

        public List<Pet> Deserialize(string str)
        {
            TextDictionary textDictionary;
            List<Pet> listOfPets = new List<Pet>();
            string[] strArray = str.Split('\n');
            foreach(var item in strArray)
            {
                if(item == "")
                    break;
                textDictionary = new TextDictionary(item);
                textDictionary.MakeDictionary();
                string tempString;
                textDictionary.dictionary.TryGetValue("Type", out tempString);
                Type type = Type.GetType(tempString);
                Pet pet = (Pet)Activator.CreateInstance(type);
                foreach(var field in type.GetFields())
                {
                    if(field.FieldType == typeof(string))
                    {
                        string fieldValue = textDictionary.dictionary[field.Name];
                        field.SetValue(pet, fieldValue);
                    }
                    else
                    {
                        int fieldValue =  Convert.ToInt16(textDictionary.dictionary[field.Name]);
                        field.SetValue(pet, fieldValue);
                    }
                }

                foreach(var property in type.GetProperties())
                {
                    if(property.PropertyType == typeof(string))
                    {
                        string propertyValue = textDictionary.dictionary[property.Name]; 
                        property.SetValue(pet, propertyValue);
                    }
                    else
                    {
                        int propertyValue =  Convert.ToInt16(textDictionary.dictionary[property.Name]);
                        property.SetValue(pet, propertyValue);
                    }
                }
                listOfPets.Add(pet);
            }

            return listOfPets;
        }
    }
}