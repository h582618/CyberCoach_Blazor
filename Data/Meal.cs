using System;
using System.Collections.Generic;

namespace ccBlazor.Data
{
    public class Meal
    {

        public String time { get; set; }
        public String type { get; set; } //Frokost,Middag,Etc
        public double calories { get; set; }
        public double fat { get; set; }
        public double protein { get; set; }
        public double carbs { get; set; }
        public String ingredients { get; set; }



        public Meal()
        {
            
        }

        public Meal(string time, string type, string ingredients, double calories, double fat, double protein, double carbs)
        {
            this.time = time;
            this.type = type;
            this.calories = calories;
            this.fat = fat;
            this.protein = protein;
            this.carbs = carbs;
            this.ingredients = ingredients;
        }
    }
}
