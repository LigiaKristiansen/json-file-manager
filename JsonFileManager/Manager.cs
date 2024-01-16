using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            // Guard clause
            if (dict == null)            
                throw new ArgumentNullException();                        
            else if (!dict.Any())            
                throw new ArgumentException();  
            else if (dict.ContainsValue(null))            
                throw new NullReferenceException();                      
            return JsonConvert.SerializeObject(dict);            
        }
        // Write JSON-file

        public void WriteJsonToFile(string json, string fileName)
        {
            if (IsValidJson(json))
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
                File.WriteAllText(filePath, json);
            }  
            else
                throw new JsonReaderException();
        }

        private bool IsValidJson(string stringToValidate)
        {
            JToken.Parse(stringToValidate);
            return true;
        }
    }

        // Read JSON-file
}

