using System;
using Newtonsoft.Json;

namespace ccBlazor.Data
{
    public class Exercise
    {
        public String name { get; set; }
        [JsonProperty(PropertyName = "Muscle Targeted")]
        public string muscle_Targeted { get; set; }
        [JsonProperty(PropertyName
            = "Equipment Type")]
        public string equipment_Type { get; set; }
        public string src { get; set; }
        public String newDay { get; set; }


        public Exercise()
        {
        }
        public Exercise(String newDay)
        {
            this.newDay = newDay;
        }

        public Exercise(string name, string muscle_Targeted, string equipment_type, string src)
        {
            this.name = name;
            this.muscle_Targeted = muscle_Targeted;
            this.equipment_Type = equipment_type;
            this.src = src;
            this.newDay = null;
        }
        public String toString()
        {
            return this.name + " " + this.muscle_Targeted
                + " " + this.equipment_Type + " " + this.src;
        }
    }
}
