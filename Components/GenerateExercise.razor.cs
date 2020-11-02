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

        public List<Data.Exercise> Generateexercises(int days)
        {

            List<Data.Exercise> exercisesGen = null;

            if (days == 6)
            {
                exercisesGen = ppl.PushPullLegs;
                Console.WriteLine(days);
            }
            else
            {
                exercisesGen = ul.UpperLower;
            }
            return exercisesGen;
        }
    }
}
