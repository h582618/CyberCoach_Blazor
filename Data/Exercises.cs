using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ccBlazor.Data
{

    public class Exercises
    {
        List<Exercise> exercises { get; set; } = new List<Exercise>();

        public static List<Exercise> getExerises()
        {

            String live = "wwwroot/Exercises/exercises80_2.json";

            String local = "/Users/matia/ccblazor/wwwroot/Exercises/exercises80_2.json";

            using (StreamReader r = new StreamReader(live))
            {

                var json = r.ReadToEnd();
                var list = JsonConvert.DeserializeObject<List<Exercise>>(json);
                /* dynamic dynJson = JsonConvert.DeserializeObject(json);          

                 foreach (var item in dynJson)
                 {
                     exercises.Add(new Exercise(item.name, item["Muscle Targeted"], item["Equipment Type"],
                         item.src));
                     Console.WriteLine("{0}{1}\n", item.name, item["Muscle Targeted"]);
                
                 }
                */

                return list;
            }
             
            }
        
        /*
        public static List<Exercise> GetExerisesAsync()
        {
            var forecastsJson = await File.ReadAllTextAsync("Exercises/exercises80_2.json");
            return JsonConvert.DeserializeObject<List<Exercise>>(forecastsJson);
        }
        */
        public static string PrettyJson(string unPrettyJson)
        {
            try
            {
                return JObject.Parse(unPrettyJson).ToString(Formatting.Indented);
            }
            catch
            {
                return unPrettyJson;
            }
        }
    }
}

