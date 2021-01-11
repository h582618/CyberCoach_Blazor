using System;
using System.Collections.Generic;
using System.Linq;

namespace ccBlazor.Data.Splits
{
    public class FB
    {
        public List<Exercise> fullBody { get; set; }
                = new List<Exercise>();
        public FB(List<Exercise> exercises, int days, int week, int exerienceLevel)
        {

            switch (exerienceLevel)
            {
                case 1:
                    switch (days)
                    {
                        case 1:
                            fullBody1(exercises);
                            break;
                        case 2:
                            fullBody2(exercises);
                            break;
                        case 3:
                            fullBody3BeginnerV1(exercises, week);
                            break;
                        case 4:
                            fullBody4(exercises, week);
                            break;
                    }
                    break;
                case 2:
                    switch (days)
                    {
                        case 1:
                            fullBody1(exercises);
                            break;
                        case 2:
                            fullBody2Intermediate(exercises);
                            break;
                        case 3:
                            fullBody3Intermediate(exercises, week);
                            break;
                    }
                    break;
                case 3:
                    switch (days)
                    {
                        case 1:
                            fullBody1(exercises);
                            break;
                        case 2:
                            fullBody2Intermediate(exercises);
                            break;
                        case 3:
                            fullBody3Intermediate(exercises, week);
                            break;
                    }
                    break;
            }
            
        }

        private void fullBody4(List<Exercise> exercises, int week)
        {
            //A
            var squat = exercises
           .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));

            squat.repsSets = "3 Sett, 8 - 10 reps";
            squat.rest = "2 minutter pause mellom hvert sett";

            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));

            benchpress.repsSets = "3 Sett, 8 - 10 reps";
            benchpress.rest = "2 minutter pause mellom hvert sett";

            var rows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));

            rows.repsSets = "3 Sett, 8 - 10 reps";
            rows.rest = "2 minutter pause mellom hvert sett";

            var tricepsPushdown = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));
            tricepsPushdown.repsSets = "1 Sett, 10 - 12 reps";

            var standingCalfRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));
            standingCalfRaises.repsSets = "1-2 Sett, 10 - 12 reps";
            rows.rest = "1 minutt pause mellom hvert sett";

            //B
            var deadlifts = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            deadlifts.repsSets = "3 Sett, 6 - 8 reps";
            deadlifts.rest = "2 minutter pause mellom hvert sett";

            var PullUps = exercises
           .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 8 - 10 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            var bicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "1 Sett, 10 - 12 reps";

            var abs = exercises
                    .Find(x => x.muscle_Targeted.Equals("Abdominals") && x.name.ToUpper().Equals("Ab Crunch Machine".ToUpper()));
            abs.repsSets = "3-4 Sett, 10 - 12 reps";
            abs.rest = "1 minutt pause mellom hvert sett";
            
            //Middle

            var cardio = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Treadmill jogging".ToUpper()));
            cardio.repsSets = "30-45 min moderat jogging på tredemølle eller ute";
    

            if (!(week % 2 == 0))
            {

                    fullBody.Add(new Exercise("Fullbody " + "A"));
                fullBody.Add(benchpress);
                fullBody.Add(squat);
                fullBody.Add(rows);


                fullBody.Add(new Exercise("Fullbody " + "B"));
                fullBody.Add(deadlifts);
                fullBody.Add(PullUps);
                fullBody.Add(OHShoulderPress);

                fullBody.Add(new Exercise("Cardiodag"));
                fullBody.Add(cardio);

                fullBody.Add(new Exercise("Fullbody " + "A"));
                fullBody.Add(benchpress);
                fullBody.Add(squat);
                fullBody.Add(rows);

            }
            else 
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

        private void fullBody1(List<Exercise> exercises)
        {
            var squat = exercises
               .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));
            squat.repsSets = "3 Sett, 6 - 8 reps";
            squat.rest = "2 minutter pause mellom hvert sett";

            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            benchpress.repsSets = "3 Sett, 6 - 8 reps";
            benchpress.rest = "2 minutter pause mellom hvert sett";

            var rows = exercises
              .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));
            rows.repsSets = "3 Sett, 8 - 10 reps";
            rows.rest = "2 minutter pause mellom hvert sett";

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            var PullUps = exercises
           .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 8 - 10 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var legCurls = exercises
           .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));
            legCurls.repsSets = "3 Sett, 8 - 10 reps";
            legCurls.rest = "2 minutter pause mellom hvert sett";

            var tricepsPushdown = exercises
           .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));
            tricepsPushdown.repsSets = "3 Sett, 10 - 15 reps";
            tricepsPushdown.rest = "2 minutter pause mellom hvert sett";

            var bicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "3 Sett, 10 - 15 reps";
            bicepCurl.rest = "2 minutter pause mellom hvert sett";

            fullBody.Add(new Exercise("Fullbody"));
            fullBody.Add(squat);
            fullBody.Add(benchpress);
            fullBody.Add(rows);
            fullBody.Add(OHShoulderPress);
            fullBody.Add(PullUps);
            fullBody.Add(legCurls);
            fullBody.Add(tricepsPushdown);
            fullBody.Add(bicepCurl);
        }

        private void fullBody2(List<Exercise> exercises)
        {
            var squat = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));
            squat.repsSets = "3 Sett, 6 - 8 reps";
            squat.rest = "2 minutter pause mellom hvert sett";

            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            benchpress.repsSets = "3 Sett, 6 - 8 reps";
            benchpress.rest = "2 minutter pause mellom hvert sett";

            var rows = exercises
              .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));
            rows.repsSets = "3 Sett, 8 - 10 reps";
            rows.rest = "2 minutter pause mellom hvert sett";

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            var PullUps = exercises
           .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 8 - 10 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var legCurls = exercises
           .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));
            legCurls.repsSets = "3 Sett, 8 - 10 reps";
            legCurls.rest = "2 minutter pause mellom hvert sett";

            var tricepsPushdown = exercises
           .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));
            tricepsPushdown.repsSets = "3 Sett, 10 - 15 reps";
            tricepsPushdown.rest = "2 minutter pause mellom hvert sett";

            var bicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "3 Sett, 10 - 15 reps";
            bicepCurl.rest = "2 minutter pause mellom hvert sett";

            fullBody.Add(new Exercise("Fullbody " + "A"));
            fullBody.Add(squat);
            fullBody.Add(benchpress);
            fullBody.Add(rows);
            fullBody.Add(OHShoulderPress);
            fullBody.Add(PullUps);
            fullBody.Add(legCurls);
            fullBody.Add(tricepsPushdown);
            fullBody.Add(bicepCurl);



            var romanianDeadlift = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Romanian Deadlift".ToUpper()));
            romanianDeadlift.repsSets = "3 Sett, 6 - 8 reps";
            romanianDeadlift.rest = "2 minutter pause mellom hvert sett";

            var PullUps2 = exercises
            .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps2.repsSets = "3 Sett, 6 - 8 reps";
            PullUps2.rest = "2 minutter pause mellom hvert sett";

            var inclineBenchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Incline dumbbell bench press".ToUpper()));
            inclineBenchpress.repsSets = "3 Sett, 8 - 10 reps";
            inclineBenchpress.rest = "2 minutter pause mellom hvert sett";


            var inclineDumbellRow = exercises
              .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Incline dumbbell row".ToUpper()));
            inclineDumbellRow.repsSets = "3 Sett, 8 - 10 reps";
            inclineDumbellRow.rest = "2 minutter pause mellom hvert sett";

            var legPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Leg Press".ToUpper()));
            legPress.repsSets = "3 Sett, 10 - 12 reps";
            legPress.rest = "2 minutter pause mellom hvert sett";

            var lateralRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated Side Lateral Raise".ToUpper()));
            lateralRaises.repsSets = "3 Sett, 10 - 15 reps";
            lateralRaises.rest = "2 minutter pause mellom hvert sett";

            var facePulls = exercises
           .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Standing face pull".ToUpper()));
            facePulls.repsSets = "3 Sett, 10 - 15 reps";
            facePulls.rest = "2 minutter pause mellom hvert sett";


            var standingCalfRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));
            standingCalfRaises.repsSets = "4 Sett, 6 - 10 reps";
            standingCalfRaises.rest = "1 minutt pause mellom hvert sett";


            fullBody.Add(new Exercise("Fullbody " + "B"));
            fullBody.Add(romanianDeadlift); 
            fullBody.Add(PullUps2);
            fullBody.Add(inclineBenchpress);
            fullBody.Add(inclineDumbellRow);
            fullBody.Add(legPress);
            fullBody.Add(lateralRaises);
            fullBody.Add(facePulls);
            fullBody.Add(standingCalfRaises);
        }


        //kort men bra
        public void fullBody3BeginnerV1(List<Exercise> exercises, int week)
        {
            //A
            var squat = exercises
           .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));

            squat.repsSets = "3 Sett, 8 - 10 reps";
            squat.rest = "2 minutter pause mellom hvert sett";

            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));

            benchpress.repsSets = "3 Sett, 8 - 10 reps";
            benchpress.rest = "2 minutter pause mellom hvert sett";

            var rows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));

            rows.repsSets = "3 Sett, 8 - 10 reps";
            rows.rest = "2 minutter pause mellom hvert sett";

            //B
            var deadlifts = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Barbell deadlift".ToUpper()));
            deadlifts.repsSets = "3 Sett, 6 - 8 reps";
            deadlifts.rest = "2 minutter pause mellom hvert sett";

            var PullUps = exercises
           .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 8 - 10 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            if (!(week % 2 == 0))
            {

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

            }
            else
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

        //Hvis versjonen over er for kort
        public void fullBody3BeginnerV2(List<Exercise> exercises, int week)
        {
            //A
            var squat = exercises
           .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));

            squat.repsSets = "3 Sett, 8 - 10 reps";
            squat.rest = "2 minutter pause mellom hvert sett";

            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));

            benchpress.repsSets = "3 Sett, 8 - 10 reps";
            benchpress.rest = "2 minutter pause mellom hvert sett";

            var rows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));

            rows.repsSets = "3 Sett, 8 - 10 reps";
            rows.rest = "2 minutter pause mellom hvert sett";

            var tricepsPushdown = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));
            tricepsPushdown.repsSets = "1 Sett, 10 - 12 reps";

            var standingCalfRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));
            standingCalfRaises.repsSets = "1-2 Sett, 10 - 12 reps";
            rows.rest = "1 minutt pause mellom hvert sett";

            //B
            var deadlifts = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            deadlifts.repsSets = "3 Sett, 6 - 8 reps";
            deadlifts.rest = "2 minutter pause mellom hvert sett";

            var PullUps = exercises
           .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 8 - 10 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            var bicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "1 Sett, 10 - 12 reps";

            var abs = exercises
                       .Find(x => x.muscle_Targeted.Equals("Abdominals") && x.name.ToUpper().Equals("Ab Crunch Machine".ToUpper()));
            abs.repsSets = "3-4 Sett, 10 - 12 reps";
            abs.rest = "1 minutt pause mellom hvert sett";

            if (!(week % 2 == 0))
            {

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

            }
            else
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

        public void fullBody2Intermediate(List<Exercise> exercises)
        {
            //A
            var squat = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));
            squat.repsSets = "3 Sett, 6 - 8 reps";
            squat.rest = "2 minutter pause mellom hvert sett";

            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            benchpress.repsSets = "3 Sett, 6 - 8 reps";
            benchpress.rest = "2 minutter pause mellom hvert sett";

            var PullUps = exercises
            .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 8 - 10 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            var legCurls = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));
            legCurls.repsSets = "3 Sett, 8 - 10 reps";
            legCurls.rest = "2 minutter pause mellom hvert sett";

            var bicepCurl = exercises
           .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "3 Sett, 10 - 15 reps";
            bicepCurl.rest = "2 minutter pause mellom hvert sett";

            var facePulls = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Standing face pull".ToUpper()));
            facePulls.repsSets = "3 Sett, 10 - 15 reps";
            facePulls.rest = "2 minutter pause mellom hvert sett";


            //B
            var romanianDeadlift = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Romanian Deadlift".ToUpper()));
            romanianDeadlift.repsSets = "3 Sett, 6 - 8 reps";
            romanianDeadlift.rest = "2 minutter pause mellom hvert sett";

            var rows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));
            rows.repsSets = "3 Sett, 6 - 8 reps";
            rows.rest = "2 minutter pause mellom hvert sett";

            var inclineBenchpress = exercises
                 .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Incline dumbbell bench press".ToUpper()));
            inclineBenchpress.repsSets = "3 Sett, 8 - 10 reps";
            inclineBenchpress.rest = "2 minutter pause mellom hvert sett";

            var legPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Leg Press".ToUpper()));
            legPress.repsSets = "3 Sett, 10 - 12 reps";
            legPress.rest = "2 minutter pause mellom hvert sett";

            var lateralRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated Side Lateral Raise".ToUpper()));
            lateralRaises.repsSets = "3 Sett, 10 - 15 reps";
            lateralRaises.rest = "2 minutter pause mellom hvert sett";

            var tricepsPushdown = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));
            tricepsPushdown.repsSets = "3 Sett, 10 - 15 reps";
            tricepsPushdown.rest = "2 minutter pause mellom hvert sett";

            var standingCalfRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));
            standingCalfRaises.repsSets = "4 Sett, 6 - 10 reps";
            standingCalfRaises.rest = "1 minutt pause mellom hvert sett";


                fullBody.Add(new Exercise("Fullbody " + "A"));
                fullBody.Add(squat);
                fullBody.Add(benchpress);
                fullBody.Add(PullUps);
                fullBody.Add(OHShoulderPress);
                fullBody.Add(legCurls);
                fullBody.Add(bicepCurl);
                fullBody.Add(facePulls);


                fullBody.Add(new Exercise("Fullbody " + "B"));
                fullBody.Add(romanianDeadlift);
                fullBody.Add(rows);
                fullBody.Add(inclineBenchpress);
                fullBody.Add(legPress);
                fullBody.Add(lateralRaises);
                fullBody.Add(tricepsPushdown);
                fullBody.Add(standingCalfRaises);

        }


        public void fullBody3Intermediate(List<Exercise> exercises, int week)
        {
            //A
            var squat = exercises
           .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));
            squat.repsSets = "3 Sett, 6 - 8 reps";
            squat.rest = "2 minutter pause mellom hvert sett";

            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            benchpress.repsSets = "3 Sett, 6 - 8 reps";
            benchpress.rest = "2 minutter pause mellom hvert sett";

            var PullUps = exercises
            .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 8 - 10 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            var legCurls = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));
            legCurls.repsSets = "3 Sett, 8 - 10 reps";
            legCurls.rest = "2 minutter pause mellom hvert sett";

            var bicepCurl = exercises
           .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "3 Sett, 10 - 15 reps";
            bicepCurl.rest = "2 minutter pause mellom hvert sett";

            var facePulls = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Standing face pull".ToUpper()));
            facePulls.repsSets = "3 Sett, 10 - 15 reps";
            facePulls.rest = "2 minutter pause mellom hvert sett";


            //B
            var romanianDeadlift = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Romanian Deadlift".ToUpper()));
            romanianDeadlift.repsSets = "3 Sett, 6 - 8 reps";
            romanianDeadlift.rest = "2 minutter pause mellom hvert sett";

            var rows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));
            rows.repsSets = "3 Sett, 6 - 8 reps";
            rows.rest = "2 minutter pause mellom hvert sett";

            var inclineBenchpress = exercises
                 .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Incline dumbbell bench press".ToUpper()));
            inclineBenchpress.repsSets = "3 Sett, 8 - 10 reps";
            inclineBenchpress.rest = "2 minutter pause mellom hvert sett";

            var legPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Leg Press".ToUpper()));
            legPress.repsSets = "3 Sett, 10 - 12 reps";
            legPress.rest = "2 minutter pause mellom hvert sett";

            var lateralRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated Side Lateral Raise".ToUpper()));
            lateralRaises.repsSets = "3 Sett, 10 - 15 reps";
            lateralRaises.rest = "2 minutter pause mellom hvert sett";

            var tricepsPushdown = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));
            tricepsPushdown.repsSets = "3 Sett, 10 - 15 reps";
            tricepsPushdown.rest = "2 minutter pause mellom hvert sett";

            var standingCalfRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));
            standingCalfRaises.repsSets = "4 Sett, 6 - 10 reps";
            standingCalfRaises.rest = "1 minutt pause mellom hvert sett";


            if (!(week % 2 == 0))
            {

                fullBody.Add(new Exercise("Fullbody " + "A"));
                fullBody.Add(squat);
                fullBody.Add(benchpress);
                fullBody.Add(PullUps);
                fullBody.Add(OHShoulderPress);
                fullBody.Add(legCurls);
                fullBody.Add(bicepCurl);
                fullBody.Add(facePulls);


                fullBody.Add(new Exercise("Fullbody " + "B"));
                fullBody.Add(romanianDeadlift);
                fullBody.Add(rows);
                fullBody.Add(inclineBenchpress);
                fullBody.Add(legPress);
                fullBody.Add(lateralRaises);
                fullBody.Add(tricepsPushdown);
                fullBody.Add(standingCalfRaises);

                fullBody.Add(new Exercise("Fullbody " + "A"));
                fullBody.Add(squat);
                fullBody.Add(benchpress);
                fullBody.Add(PullUps);
                fullBody.Add(OHShoulderPress);
                fullBody.Add(legCurls);
                fullBody.Add(bicepCurl);
                fullBody.Add(facePulls);

            }
            else
            {
                fullBody.Add(new Exercise("Fullbody " + "B"));
                fullBody.Add(romanianDeadlift);
                fullBody.Add(rows);
                fullBody.Add(inclineBenchpress);
                fullBody.Add(legPress);
                fullBody.Add(lateralRaises);
                fullBody.Add(tricepsPushdown);
                fullBody.Add(standingCalfRaises);

                fullBody.Add(new Exercise("Fullbody " + "A"));
                fullBody.Add(squat);
                fullBody.Add(benchpress);
                fullBody.Add(PullUps);
                fullBody.Add(OHShoulderPress);
                fullBody.Add(legCurls);
                fullBody.Add(bicepCurl);
                fullBody.Add(facePulls);


                fullBody.Add(new Exercise("Fullbody " + "B"));
                fullBody.Add(romanianDeadlift);
                fullBody.Add(rows);
                fullBody.Add(inclineBenchpress);
                fullBody.Add(legPress);
                fullBody.Add(lateralRaises);
                fullBody.Add(tricepsPushdown);
                fullBody.Add(standingCalfRaises);
            }

        }
    }
}
