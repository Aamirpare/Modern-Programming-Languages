using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WindowsFormsShoppingApp.Data
{
    public static class ContentFormater
    {
        static JsonSerializerOptions Options = new JsonSerializerOptions { WriteIndented = true };
        public static string ToPrettyJson<T>(List<T> data)
        {
            return JsonSerializer.Serialize<List<T>>(data, Options); 
        }
        public static List<T> ToObjectCollection<T>(string jsonString)
        {
            return JsonSerializer.Deserialize<List<T>>(jsonString, Options);
        }

    }
}
