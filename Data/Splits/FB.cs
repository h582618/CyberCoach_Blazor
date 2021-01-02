using System;
using System.Collections.Generic;
using System.Linq;

namespace ccBlazor.Data.Splits
{
    public class FB
    {
        public List<Exercise> fullBody { get; set; }
                = new List<Exercise>();
        public FB(List<Exercise> exercises, int days, int week)
        {
            switch (days)
            {
                case 1:
                    fullBody1(exercises);
                    break;
                case 2:
                    fullBody2(exercises);
                    break;
                case 3:
                    fullBody3(exercises,week);
                    break;
            }
        }

        private void fullBody1(List<Exercise> exercises)
        {
            var squat = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));

            var benchpress = exercises

            .FindAll(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));

            var rows = exercises
              .FindAll(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));

            var OHShoulderPress = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));


            var PullUps = exercises
           .FindAll(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));


            var legCurls = exercises
           .FindAll(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));

            var tricepsPushdown = exercises
          .FindAll(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));

            var bicepCurl = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));

            fullBody.Add(new Exercise("Fullbody " + "A"));
            fullBody.AddRange(squat);
            fullBody.AddRange(benchpress);
            fullBody.AddRange(rows);
            fullBody.AddRange(OHShoulderPress);
            fullBody.AddRange(PullUps);
            fullBody.AddRange(legCurls);
            fullBody.AddRange(tricepsPushdown);
            fullBody.AddRange(bicepCurl);
        }

        private void fullBody2(List<Exercise> exercises)
        {
            var squat = exercises
             .FindAll(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));

            var benchpress = exercises

            .FindAll(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));

            var rows = exercises
              .FindAll(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));

            var OHShoulderPress = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));


            var PullUps = exercises
           .FindAll(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));


            var legCurls = exercises
           .FindAll(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));

            var tricepsPushdown = exercises
          .FindAll(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));

            var bicepCurl = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));

            fullBody.Add(new Exercise("Fullbody " + "A"));
            fullBody.AddRange(squat);
            fullBody.AddRange(benchpress);
            fullBody.AddRange(rows);
            fullBody.AddRange(OHShoulderPress);
            fullBody.AddRange(PullUps);
            fullBody.AddRange(legCurls);
            fullBody.AddRange(tricepsPushdown);
            fullBody.AddRange(bicepCurl);

          

            var romanianDeadlift = exercises
      .FindAll(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Romanian Deadlift".ToUpper()));

            var inclineBenchpress = exercises

            .FindAll(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Incline dumbbell bench press".ToUpper()));

            var inclineDumbellRow = exercises
              .FindAll(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Incline dumbbell row".ToUpper()));

            var legPress = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Leg Press".ToUpper()));


            var lateralRaises = exercises
           .FindAll(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated Side Lateral Raise".ToUpper()));


            var facePulls = exercises
           .FindAll(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Standing face pull".ToUpper()));

            var standingCalfRaises = exercises
          .FindAll(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));

     

            fullBody.Add(new Exercise("Fullbody " + "B"));
            fullBody.AddRange(romanianDeadlift);
            fullBody.AddRange(PullUps);
            fullBody.AddRange(inclineBenchpress);
            fullBody.AddRange(inclineDumbellRow);
            fullBody.AddRange(legPress);
            fullBody.AddRange(lateralRaises);
            fullBody.AddRange(facePulls);
            fullBody.AddRange(standingCalfRaises);
        }

       

        public void fullBody3(List<Exercise> exercises,int week)
        {
            var benchpress = exercises

            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));


            var squat = exercises
           .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));

            var rows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));


            var deadlifts = exercises

         .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));


            var PullUps = exercises
           .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));

            if (!(week % 2 == 0)) { 
     
            fullBody.Add(new Exercise("Fullbody " + "A"));
            fullBody.Add(benchpress);
            fullBody.Add(squat);
            fullBody.Add(rows);


            fullBody.Add(new Exercise("Fullbody " + "B"));
            fullBody.Add(deadlifts);
            fullBody.Add(PullUps);
            fullBody.Add(OHShoulderPress);

           fullBody.Add(new Exercise("Fullbody " + "A"));
           fullBody.Add(benchpress);
           fullBody.Add(squat);
           fullBody.Add(rows);

            } else
            {
                fullBody.Add(new Exercise("Fullbody " + "B"));
                fullBody.Add(deadlifts);
                fullBody.Add(PullUps);
                fullBody.Add(OHShoulderPress);

                fullBody.Add(new Exercise("Fullbody " + "A"));
                fullBody.Add(benchpress);
                fullBody.Add(squat);
                fullBody.Add(rows);

                fullBody.Add(new Exercise("Fullbody " + "B"));
                fullBody.Add(deadlifts);
                fullBody.Add(PullUps);
                fullBody.Add(OHShoulderPress);
            }



        }
        
    }
}
