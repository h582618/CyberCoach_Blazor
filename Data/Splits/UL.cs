using System;
using System.Collections.Generic;
using System.Linq;

namespace ccBlazor.Data.Splits
{
    public class UL
    {
        public List<Exercise> UpperLower { get; set; }
             = new List<Exercise>();
        public UL()
        {
        }
        public UL(List<Exercise> exercises, int days, int week, int exerienceLevel)
        {
            /*
            upper(exercises, "A");
            lower(exercises, "A");

            upper(exercises, "B");
            lower(exercises, "B");
            */

            switch (exerienceLevel)
            { 
                case 2:
                    switch (days)
                    {
                        case 3:
                            UL3(exercises, week);
                            break;
                        case 4:
                            UL4(exercises, week);
                            break;
                        case 5:
                            UL5(exercises, week);
                            break;
                    }
                    break;
                case 3:
                    switch (days)
                    {
                            case 3:
                            UL3(exercises, week);
                            break;
                        case 4:
                            UL4(exercises, week);
                            break;
                         
                    }
                    break;
            }

        }

        public List<Exercise> upper(List<Exercise> exercises, String x)
        {
            Random rnd = new Random();
            var chest = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Chest")
            && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
               && !x.equipment_Type.Equals("Medicine Ball") && !x.equipment_Type.Equals("Exercise Ball"))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(3)
            .Select(x => x.v);

            var shoulders = exercises
          .FindAll(x => x.muscle_Targeted.Equals("Shoulders")
                    && (!x.equipment_Type.Equals("Body Only")
           && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
            && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
             && !x.equipment_Type.Equals("Medicine Ball"))
          .Distinct().Select(v => new { v, i = rnd.Next() })
          .OrderBy(x => x.i).Take(2)
          .Select(x => x.v);

            var triceps = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Triceps")
                         && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
               && !x.equipment_Type.Equals("Medicine Ball"))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(2)
            .Select(x => x.v);



            UpperLower.Add(new Exercise("Upper " + x.ToUpper()));
            UpperLower.AddRange(chest);
            UpperLower.AddRange(shoulders);
            UpperLower.AddRange(triceps);

            return UpperLower;
        }
        public List<Exercise> lower(List<Exercise> exercises, String x)
        {
            Random rnd = new Random();
            var chest = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Chest")
            && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
               && !x.equipment_Type.Equals("Medicine Ball") && !x.equipment_Type.Equals("Exercise Ball"))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(3)
            .Select(x => x.v);

            var shoulders = exercises
          .FindAll(x => x.muscle_Targeted.Equals("Shoulders")
                    && (!x.equipment_Type.Equals("Body Only")
           && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
            && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
             && !x.equipment_Type.Equals("Medicine Ball"))
          .Distinct().Select(v => new { v, i = rnd.Next() })
          .OrderBy(x => x.i).Take(2)
          .Select(x => x.v);

            var triceps = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Triceps")
                         && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
               && !x.equipment_Type.Equals("Medicine Ball"))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(2)
            .Select(x => x.v);



            UpperLower.Add(new Exercise("Lower " + x.ToUpper()));
            UpperLower.AddRange(chest);
            UpperLower.AddRange(shoulders);
            UpperLower.AddRange(triceps);

            return UpperLower;
        }


        private void UL3(List<Exercise> exercises, int week)
        {
            //Upper
            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));

            benchpress.repsSets = "3 Sett, 6 - 8 reps";
            benchpress.rest = "2 minutter pause mellom hvert sett";
            benchpress.video = "https://www.muscleandstrength.com/exercises/barbell-bench-press.html";

            var rows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));

            rows.repsSets = "3 Sett, 6 - 8 reps";
            rows.rest = "2 minutter pause mellom hvert sett";

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            var PullUps = exercises
               .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 8 - 10 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var inclineDumbellFlyes = exercises
             .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Incline Dumbbell Flyes".ToUpper()));
            inclineDumbellFlyes.repsSets = "2 Sett, 10 - 15 reps";
            inclineDumbellFlyes.rest = "2 minutter pause mellom hvert sett";


            var bicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "2 Sett, 12 - 15 reps";
            bicepCurl.rest = "1 minutt pause mellom hvert sett";

            var tricepExtensions = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Standing Dumbbell Triceps Extension".ToUpper()));
            tricepExtensions.repsSets = "2 Sett, 12 - 15 reps";
            tricepExtensions.rest = "1 minutt pause mellom hvert sett";

            //Lower

            var squat = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));

            squat.repsSets = "3 Sett, 6 - 8 reps";
            squat.rest = "2 minutter pause mellom hvert sett";

            var romanianDeadlift = exercises
                    .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Romanian Deadlift".ToUpper()));
            romanianDeadlift.repsSets = "3 Sett, 6 - 8 reps";
            romanianDeadlift.rest = "2 minutter pause mellom hvert sett";

            var legPress = exercises
          .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Leg Press".ToUpper()));
            legPress.repsSets = "3 Sett, 10 - 12 reps";
            legPress.rest = "2 minutter pause mellom hvert sett";


            var legCurls = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));
            legCurls.repsSets = "3 Sett, 8 - 10 reps";
            legCurls.rest = "2 minutter pause mellom hvert sett";

            var standingCalfRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));
            standingCalfRaises.repsSets = "1-2 Sett, 10 - 12 reps";
            standingCalfRaises.rest = "1 minutt pause mellom hvert sett";

            var abs = exercises
            .Find(x => x.muscle_Targeted.Equals("Abdominals") && x.name.ToUpper().Equals("Ab Crunch Machine".ToUpper()));
            abs.repsSets = "3-4 Sett, 10 - 12 reps";
            abs.rest = "1 minutt pause mellom hvert sett";


            if (!(week % 2 == 0))
            {

                UpperLower.Add(new Exercise("Upper"));
                UpperLower.Add(benchpress);
                UpperLower.Add(rows);
                UpperLower.Add(OHShoulderPress);
                UpperLower.Add(PullUps);
                UpperLower.Add(inclineDumbellFlyes);
                UpperLower.Add(bicepCurl);
                UpperLower.Add(tricepExtensions);



                UpperLower.Add(new Exercise("Lower"));
                UpperLower.Add(squat);
                UpperLower.Add(romanianDeadlift);
                UpperLower.Add(legPress);
                UpperLower.Add(legCurls);
                UpperLower.Add(standingCalfRaises);
                UpperLower.Add(abs);

                UpperLower.Add(new Exercise("Upper"));
                UpperLower.Add(benchpress);
                UpperLower.Add(rows);
                UpperLower.Add(OHShoulderPress);
                UpperLower.Add(PullUps);
                UpperLower.Add(inclineDumbellFlyes);
                UpperLower.Add(bicepCurl);
                UpperLower.Add(tricepExtensions);
            }
            else
            {

                UpperLower.Add(new Exercise("Lower"));
                UpperLower.Add(squat);
                UpperLower.Add(romanianDeadlift);
                UpperLower.Add(legPress);
                UpperLower.Add(legCurls);
                UpperLower.Add(standingCalfRaises);
                UpperLower.Add(abs);

                UpperLower.Add(new Exercise("Upper"));
                UpperLower.Add(benchpress);
                UpperLower.Add(rows);
                UpperLower.Add(OHShoulderPress);
                UpperLower.Add(PullUps);
                UpperLower.Add(inclineDumbellFlyes);
                UpperLower.Add(bicepCurl);
                UpperLower.Add(tricepExtensions);

                UpperLower.Add(new Exercise("Lower"));
                UpperLower.Add(squat);
                UpperLower.Add(romanianDeadlift);
                UpperLower.Add(legPress);
                UpperLower.Add(legCurls);
                UpperLower.Add(standingCalfRaises);
                UpperLower.Add(abs);


            }
        }

        private void UL4(List<Exercise> exercises, int week)
        {
            //Upper A
            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            benchpress.repsSets = "3 Sett, 6 - 8 reps";
            benchpress.rest = "2-3 minutter pause mellom hvert sett";
            benchpress.video = "https://www.muscleandstrength.com/exercises/barbell-bench-press.html";


            var machineRows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Machine Low Row".ToUpper()));
            machineRows.repsSets = "3 Sett, 6 - 8 reps";
            machineRows.rest = "2-3 minutter pause mellom hvert sett";

            var inclineDumbellPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Incline dumbbell bench press".ToUpper()));
            inclineDumbellPress.repsSets = "3 Sett, 8 - 10 reps";
            inclineDumbellPress.rest = "1-2 minutter pause mellom hvert sett";

            var latPullDowns = exercises
            .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Lat pull-down".ToUpper()));
            latPullDowns.repsSets = "3 Sett, 8 - 10 reps";
            latPullDowns.rest = "1-2 minutter pause mellom hvert sett";

            var lateralRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Side Lateral Raise".ToUpper()));
            lateralRaises.repsSets = "2 Sett, 10 - 15 reps";
            lateralRaises.rest = "1-2 minutter pause mellom hvert sett";

            var tricepsPushdown = exercises
           .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));
            tricepsPushdown.repsSets = "3 Sett, 10 - 12 reps";
            tricepsPushdown.rest = "1 minutt pause mellom hvert sett";

            var bicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "2 Sett, 12 - 15 reps";
            bicepCurl.rest = "1 minutt pause mellom hvert sett";


            //Lower A

            var romanianDeadlift = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Romanian Deadlift".ToUpper()));
            romanianDeadlift.repsSets = "3 Sett, 6 - 8 reps";
            romanianDeadlift.rest = "2-3 minutter pause mellom hvert sett";

            var legPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Leg Press".ToUpper()));
            legPress.repsSets = "3 Sett, 10 - 12 reps";
            legPress.rest = "1-2 minutter pause mellom hvert sett";


            var legCurls = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));
            legCurls.repsSets = "3 Sett, 8 - 10 reps";
            legCurls.rest = "1-2 minutter pause mellom hvert sett";

            var standingCalfRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));
            standingCalfRaises.repsSets = "4 Sett, 6 - 8 reps";
            standingCalfRaises.rest = "1-2 minutt pause mellom hvert sett";

            var abs = exercises
            .Find(x => x.muscle_Targeted.Equals("Abdominals") && x.name.ToUpper().Equals("Ab Crunch Machine".ToUpper()));
            abs.repsSets = "3-4 Sett, 8 - 15 reps";
            abs.rest = "1 minutt pause mellom hvert sett";


            //Upper B

            var PullUps = exercises
            .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 6 - 8 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var barbellShoulderPress = exercises
           .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("barbell shoulder press".ToUpper()));
            barbellShoulderPress.repsSets = "3 Sett, 6 - 8 reps";
            barbellShoulderPress.rest = "2-3 minutter pause mellom hvert sett";

            var seatedRows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));
            seatedRows.repsSets = "3 Sett, 8 - 10 reps";
            seatedRows.rest = "1-2 minutter pause mellom hvert sett";

            var dumbellBenchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Dumbbell Bench Press".ToUpper()));
            dumbellBenchpress.repsSets = "3 Sett, 8 - 10 reps";
            dumbellBenchpress.rest = "1-2 minutter pause mellom hvert sett";

            var dumbellFlyes = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Dumbbell Flyes".ToUpper()));
            dumbellFlyes.repsSets = "2 Sett, 10 - 15 reps";
            dumbellFlyes.rest = "1 minutt pause mellom hvert sett";

            var barbellBicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Barbell Curl".ToUpper()));
            barbellBicepCurl.repsSets = "3 Sett, 10 - 12 reps";
            barbellBicepCurl.rest = "1 minutt pause mellom hvert sett";

            var skullCrushers = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("EZ-Bar Skullcrusher".ToUpper()));
            skullCrushers.repsSets = "2 Sett, 12 - 15 reps";
            skullCrushers.rest = "1 minutt pause mellom hvert sett";


            //Lower B

            var squat = exercises
           .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));
            squat.repsSets = "3 Sett, 6 - 8 reps";
            squat.rest = "2-3 minutter pause mellom hvert sett";

            var splitSquat = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Split Squat with Dumbbells".ToUpper()));
            splitSquat.repsSets = "3 Sett, 8 - 10 reps";
            splitSquat.rest = "1-2 minutter pause mellom hvert sett";

            var lyingLegCurls = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Lying Leg Curls".ToUpper()));
            lyingLegCurls.repsSets = "3 Sett, 10 - 12 reps";
            lyingLegCurls.rest = "1-2 minutter pause mellom hvert sett";

            var seatedCalfRaise = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Seated Calf Raise".ToUpper()));
            seatedCalfRaise.repsSets = "4 Sett, 6 - 8 reps";
            seatedCalfRaise.rest = "1-2 minutt pause mellom hvert sett";

            var abs2 = exercises
            .Find(x => x.muscle_Targeted.Equals("Abdominals") && x.name.ToUpper().Equals("Ab Crunch Machine".ToUpper()));
            abs2.repsSets = "3-4 Sett, 8 - 15 reps";
            abs2.rest = "1 minutt pause mellom hvert sett";


            UpperLower.Add(new Exercise("Upper A"));
            UpperLower.Add(benchpress);
            UpperLower.Add(machineRows);
            UpperLower.Add(inclineDumbellPress);
            UpperLower.Add(latPullDowns);
            UpperLower.Add(lateralRaises);
            UpperLower.Add(tricepsPushdown);
            UpperLower.Add(bicepCurl);



            UpperLower.Add(new Exercise("Lower A"));
            UpperLower.Add(romanianDeadlift);
            UpperLower.Add(legPress);
            UpperLower.Add(legCurls);
            UpperLower.Add(seatedCalfRaise);
            UpperLower.Add(abs);

            UpperLower.Add(new Exercise("Upper B"));
            UpperLower.Add(PullUps);
            UpperLower.Add(barbellShoulderPress);
            UpperLower.Add(seatedRows);
            UpperLower.Add(dumbellBenchpress);
            UpperLower.Add(dumbellFlyes);
            UpperLower.Add(barbellBicepCurl);
            UpperLower.Add(skullCrushers);

            UpperLower.Add(new Exercise("Lower B"));
            UpperLower.Add(squat);
            UpperLower.Add(splitSquat);
            UpperLower.Add(lyingLegCurls);
            UpperLower.Add(seatedCalfRaise);
            UpperLower.Add(abs);




        }
        private void UL5(List<Exercise> exercises, int week)
        {
            //Upper A
            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            benchpress.repsSets = "3 Sett, 6 - 8 reps";
            benchpress.rest = "2-3 minutter pause mellom hvert sett";
            benchpress.video = "https://www.muscleandstrength.com/exercises/barbell-bench-press.html";

            var machineRows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Machine Low Row".ToUpper()));
            machineRows.repsSets = "3 Sett, 6 - 8 reps";
            machineRows.rest = "2-3 minutter pause mellom hvert sett";

            var inclineDumbellPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Incline dumbbell bench press".ToUpper()));
            inclineDumbellPress.repsSets = "3 Sett, 8 - 10 reps";
            inclineDumbellPress.rest = "1-2 minutter pause mellom hvert sett";

            var latPullDowns = exercises
            .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Lat pull-down".ToUpper()));
            latPullDowns.repsSets = "3 Sett, 8 - 10 reps";
            latPullDowns.rest = "1-2 minutter pause mellom hvert sett";

            var lateralRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated Side Lateral Raise".ToUpper()));
            lateralRaises.repsSets = "2 Sett, 10 - 15 reps";
            lateralRaises.rest = "1-2 minutter pause mellom hvert sett";

            var tricepsPushdown = exercises
           .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));
            tricepsPushdown.repsSets = "3 Sett, 10 - 12 reps";
            tricepsPushdown.rest = "1 minutt pause mellom hvert sett";

            var bicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "2 Sett, 12 - 15 reps";
            bicepCurl.rest = "1 minutt pause mellom hvert sett";


            //Lower A

            var romanianDeadlift = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Romanian Deadlift".ToUpper()));
            romanianDeadlift.repsSets = "3 Sett, 6 - 8 reps";
            romanianDeadlift.rest = "2-3 minutter pause mellom hvert sett";

            var legPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Leg Press".ToUpper()));
            legPress.repsSets = "3 Sett, 10 - 12 reps";
            legPress.rest = "1-2 minutter pause mellom hvert sett";


            var legCurls = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));
            legCurls.repsSets = "3 Sett, 8 - 10 reps";
            legCurls.rest = "1-2 minutter pause mellom hvert sett";

            var standingCalfRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));
            standingCalfRaises.repsSets = "4 Sett, 6 - 8 reps";
            standingCalfRaises.rest = "1-2 minutt pause mellom hvert sett";

            var abs = exercises
            .Find(x => x.muscle_Targeted.Equals("Abdominals") && x.name.ToUpper().Equals("Ab Crunch Machine".ToUpper()));
            abs.repsSets = "3-4 Sett, 8 - 15 reps";
            abs.rest = "1 minutt pause mellom hvert sett";


            //Upper B

            var PullUps = exercises
            .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 6 - 8 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var barbellShoulderPress = exercises
           .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Standing barbell shoulder press".ToUpper()));
            barbellShoulderPress.repsSets = "3 Sett, 6 - 8 reps";
            barbellShoulderPress.rest = "2-3 minutter pause mellom hvert sett";

            var seatedRows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));
            seatedRows.repsSets = "3 Sett, 8 - 10 reps";
            seatedRows.rest = "1-2 minutter pause mellom hvert sett";

            var dumbellBenchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Dumbbell Bench Press".ToUpper()));
            dumbellBenchpress.repsSets = "3 Sett, 8 - 10 reps";
            dumbellBenchpress.rest = "1-2 minutter pause mellom hvert sett";

            var dumbellFlyes = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Dumbbell Flyes".ToUpper()));
            dumbellFlyes.repsSets = "2 Sett, 10 - 15 reps";
            dumbellFlyes.rest = "1 minutt pause mellom hvert sett";

            var barbellBicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Barbell Curl".ToUpper()));
            barbellBicepCurl.repsSets = "3 Sett, 10 - 12 reps";
            barbellBicepCurl.rest = "1 minutt pause mellom hvert sett";

            var skullCrushers = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("EZ-Bar Skullcrusher".ToUpper()));
            skullCrushers.repsSets = "2 Sett, 12 - 15 reps";
            skullCrushers.rest = "1 minutt pause mellom hvert sett";


            //Lower B

            var squat = exercises
           .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));
            squat.repsSets = "3 Sett, 6 - 8 reps";
            squat.rest = "2-3 minutter pause mellom hvert sett";

            var splitSquat = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Split Squat with Dumbbells".ToUpper()));
            splitSquat.repsSets = "3 Sett, 8 - 10 reps";
            splitSquat.rest = "1-2 minutter pause mellom hvert sett";

            var lyingLegCurls = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Lying Leg Curls".ToUpper()));
            lyingLegCurls.repsSets = "3 Sett, 10 - 12 reps";
            lyingLegCurls.rest = "1-2 minutter pause mellom hvert sett";

            var seatedCalfRaise = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Seated Calf Raise".ToUpper()));
            seatedCalfRaise.repsSets = "4 Sett, 6 - 8 reps";
            seatedCalfRaise.rest = "1-2 minutt pause mellom hvert sett";

            var abs2 = exercises
            .Find(x => x.muscle_Targeted.Equals("Abdominals") && x.name.ToUpper().Equals("Ab Crunch Machine".ToUpper()));
            abs2.repsSets = "3-4 Sett, 8 - 15 reps";
            abs2.rest = "1 minutt pause mellom hvert sett";

            

            UpperLower.Add(new Exercise("Upper A"));
            UpperLower.Add(benchpress);
            UpperLower.Add(machineRows);
            UpperLower.Add(inclineDumbellPress);
            UpperLower.Add(latPullDowns);
            UpperLower.Add(lateralRaises);
            UpperLower.Add(tricepsPushdown);
            UpperLower.Add(bicepCurl);



            UpperLower.Add(new Exercise("Lower A"));
            UpperLower.Add(romanianDeadlift);
            UpperLower.Add(legPress);
            UpperLower.Add(legCurls);
            UpperLower.Add(seatedCalfRaise);
            UpperLower.Add(abs);

            UpperLower.Add(new Exercise("Upper B"));
            UpperLower.Add(PullUps);
            UpperLower.Add(barbellShoulderPress);
            UpperLower.Add(seatedRows);
            UpperLower.Add(dumbellBenchpress);
            UpperLower.Add(dumbellFlyes);
            UpperLower.Add(barbellBicepCurl);
            UpperLower.Add(skullCrushers);

            UpperLower.Add(new Exercise("Lower B"));
            UpperLower.Add(squat);
            UpperLower.Add(splitSquat);
            UpperLower.Add(lyingLegCurls);
            UpperLower.Add(seatedCalfRaise);
            UpperLower.Add(abs);




        }
    }
}
