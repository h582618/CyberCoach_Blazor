using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace ccBlazor.Components
{
    public partial class GenerateExercise
    {
        public static List<Data.Exercise> exercises = Data.Exercises.getExerises();
        public static Data.Splits.PPL ppl = new Data.Splits.PPL(exercises);
        public static Data.Splits.UL ul = new Data.Splits.UL(exercises);
  

        [Parameter]
        public int days { get; set; } = 0;

        [Parameter]
        public int currentDay { get; set; }

        [Parameter]
        public int week { get; set; }

        [Parameter]
        public List<String> preferedDays { get; set; }

        public List<Data.Exercise> Generateexercises(int days)
        {

            List<Data.Exercise> exercisesGen = null;

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
