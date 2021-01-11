using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using ccBlazor.Data;
using Microsoft.AspNetCore.Components;

namespace ccBlazor.Components
{
    public partial class GenerateExercise
    {
        public static List<Data.Exercise> exercises = Exercises.getExerises();
        //public static Data.Splits.PPL ppl = new Data.Splits.PPL(exercises);
        //public static Data.Splits.UL ul = new Data.Splits.UL(exercises);
  

        [Parameter]
        public int days { get; set; } = 0;

        [Parameter]
        public int currentDay { get; set; }

        [Parameter]
        public int week { get; set; }

        [Parameter]
        public int experienceLevel { get; set; }

        [Parameter]
        public List<String> preferedDays { get; set; }

        [Parameter]
        public bool[] show { get; set; }


        /*
        protected override async Task OnInitializedAsync()
        {
            var json = await File.ReadAllTextAsync("wwwroot/Exercises/exercises80_2.json");
            exercises = JsonSerializer.Deserialize<List<Data.Exercise>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }*/



        public List<Data.Exercise> Generateexercises(int days)
        {

            List<Data.Exercise> exercisesGen = null;

            switch (experienceLevel)
            {
                case 1:
                    switch (days)
                    {
                        case 1:
                            exercisesGen = new Data.Splits.FB(exercises, days, week,experienceLevel).fullBody;
                            break;
                        case 2:
                            exercisesGen = new Data.Splits.FB(exercises, days, week, experienceLevel).fullBody;
                            break;
                        case 3:
                            exercisesGen = new Data.Splits.FB(exercises, days, week, experienceLevel).fullBody;
                            break;
                        case 4:
                            exercisesGen = new Data.Splits.FB(exercises, days, week, experienceLevel).fullBody;
                            break;
                        case 5:
                            break;
                        case 6:
                            break;

                    }
                    break;
                case 2:
                    switch (days)
                    {
                        case 1:
                            exercisesGen = new Data.Splits.FB(exercises, days, week,experienceLevel).fullBody;
                            break;
                        case 2:
                            exercisesGen = new Data.Splits.FB(exercises, days, week, experienceLevel).fullBody;
                            break;
                        case 3:
                            exercisesGen = new Data.Splits.UL(exercises, days, week,experienceLevel).UpperLower;
                            break;
                        case 4:
                            exercisesGen = new Data.Splits.UL(exercises, days, week, experienceLevel).UpperLower;
                            break;
                        case 5:
                            exercisesGen = new Data.Splits.UL(exercises, days, week, experienceLevel).UpperLower;
                            break;
                        case 6:
                            break;

                    }
                    break;
                case 3:
                    switch (days)
                    {
                        case 1:
                            exercisesGen = new Data.Splits.FB(exercises, days, week, experienceLevel).fullBody;
                            break;
                        case 2:
                            exercisesGen = new Data.Splits.FB(exercises, days, week, experienceLevel).fullBody;
                            break;
                        case 3:
                            exercisesGen = new Data.Splits.UL(exercises, days, week, experienceLevel).UpperLower;
                            break;
                        case 4:
                            exercisesGen = new Data.Splits.UL(exercises, days, week, experienceLevel).UpperLower;
                            break;
                        case 5:
                            exercisesGen = new Data.Splits.PPL(exercises, days, week, experienceLevel).PushPullLegs;
                            break;
                        case 6:
                            exercisesGen = new Data.Splits.PPL(exercises, days, week, experienceLevel).PushPullLegs;
                            break;
                    }
                    break;
                default:
                    exercisesGen = new Data.Splits.PPL(exercises, days, week, experienceLevel).PushPullLegs;
                    break;
            }
            /*
            switch (days)
    {
        case 1:
            exercisesGen = new Data.Splits.FB(exercises, days, week).fullBody;
            break;
        case 2:
            exercisesGen = new Data.Splits.FB(exercises, days, week).fullBody;
            break;
        case 3:
            exercisesGen = new Data.Splits.FB(exercises, days, week).fullBody;
            break;
        case 4:
            exercisesGen = ul.UpperLower;
            break;
        default:
            exercisesGen = ppl.PushPullLegs;
            break;
    }
    */
            /*
            if (days == 6)
            {
                exercisesGen = ppl.PushPullLegs;
            }
            else
            {
                exercisesGen = ul.UpperLower;
            }
            */
                    return exercisesGen;
        }
    }
}
