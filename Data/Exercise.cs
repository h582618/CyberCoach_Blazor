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
        public String repsSets { get; set; }
        public String rest { get; set; }
        public String info { get; set; }
        public String video { get; set; }

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
        public Exercise(string name, string muscle_Targeted, string equipment_type, string src, String repsSets, String rest)
        {
            this.name = name;
            this.muscle_Targeted = muscle_Targeted;
            this.equipment_Type = equipment_type;
            this.src = src;
            this.newDay = null;
            this.repsSets = repsSets;
            this.rest = rest;
        }

        public String toString()
        {
            return this.name + " " + this.muscle_Targeted
                + " " + this.equipment_Type + " " + this.src;
        }
    }
}
