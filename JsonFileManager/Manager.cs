using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Xunit.Sdk;

namespace JsonFileManager
{
    public class Manager
    {
        // JSON to Dictionary

        // Dictionary to JSON
        public string CreateJsonFromDict(Dictionary<string, object> dict)
        {
            if (!dict.Any())
            {
                throw new ArgumentException("Dictionary is empty");  
            }                              
            
            return JsonConvert.SerializeObject(dict);            
        }

        // Read JSON-file
        // Write JSON-file
    }
}
