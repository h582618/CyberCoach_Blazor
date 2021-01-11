using System;
using System.Collections.Generic;
using System.Linq;

namespace ccBlazor.Data.Splits
{
    public class PPL
    {
        public List<Exercise> PushPullLegs { get; set; }
             = new List<Exercise>();
        public PPL()
        {
        }
        public PPL(List<Exercise> exercises, int days, int week, int exerienceLevel)
        {

            switch (days)
            {
                case 5:
                    UpperLowerPPL5(exercises);
                    break;
                case 6:
                    PPL6(exercises);
                    break;
            }


        }

          public void UpperLowerPPL5(List<Exercise> exercises)
        {

            //Uppper
            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            benchpress.repsSets = "3 Sett, 5 - 8 reps";
            benchpress.rest = "2-3 minutter pause mellom hvert sett";
            benchpress.video = "https://www.muscleandstrength.com/exercises/barbell-bench-press.html";


            var rows = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Seated Cable Rows".ToUpper()));
            rows.repsSets = "3 Sett, 5 - 8 reps";
            rows.rest = "2 minutter pause mellom hvert sett";

            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            var latPullDowns = exercises
            .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Lat pull-down".ToUpper()));
            latPullDowns.repsSets = "3 Sett, 8 - 10 reps";
            latPullDowns.rest = "2 minutter pause mellom hvert sett";

            var dumbellFlyes = exercises
           .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Dumbbell Flyes".ToUpper()));
            dumbellFlyes.repsSets = "2 Sett, 10 - 15 reps";
            dumbellFlyes.rest = "1 minutt pause mellom hvert sett";

            var hammerCurls = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Cable rope hammer curl".ToUpper()));
            hammerCurls.repsSets = "2 Sett, 12 - 15 reps";
            hammerCurls.rest = "1 minutt pause mellom hvert sett";

            var tricepsPushdown = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps Pushdown".ToUpper()));
            tricepsPushdown.repsSets = "3 Sett, 12 - 12 reps";
            tricepsPushdown.rest = "1 minutt pause mellom hvert sett";

            PushPullLegs.Add(new Exercise("Upper"));
            PushPullLegs.Add(benchpress);
            PushPullLegs.Add(rows);
            PushPullLegs.Add(OHShoulderPress);
            PushPullLegs.Add(latPullDowns);
            PushPullLegs.Add(dumbellFlyes);
            PushPullLegs.Add(hammerCurls);
            PushPullLegs.Add(tricepsPushdown);


            //Lower

            var deadlifts = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            deadlifts.repsSets = "3 Sett, 6 - 8 reps";
            deadlifts.rest = "2 minutter pause mellom hvert sett";

            var legPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Leg Press".ToUpper()));
            legPress.repsSets = "3 Sett, 6 - 8 reps";
            legPress.rest = "1-2 minutter pause mellom hvert sett";


            var legCurls = exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));
            legCurls.repsSets = "3 Sett, 8 - 10 reps";
            legCurls.rest = "1-2 minutter pause mellom hvert sett";

            var splitSquat = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Split Squat with Dumbbells".ToUpper()));
            splitSquat.repsSets = "3 Sett, 8 - 10 reps";
            splitSquat.rest = "1-2 minutter pause mellom hvert sett";

            var standingCalfRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Standing Calf Raises".ToUpper()));
            standingCalfRaises.repsSets = "4 Sett, 6 - 8 reps";
            standingCalfRaises.rest = "1-2 minutt pause mellom hvert sett";

            PushPullLegs.Add(new Exercise("Lower"));
            PushPullLegs.Add(deadlifts);
            PushPullLegs.Add(legPress);
            PushPullLegs.Add(legCurls);
            PushPullLegs.Add(splitSquat);
            PushPullLegs.Add(standingCalfRaises);
     

            //Push

            var inclineBenchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Incline Bench Press Medium-Grip".ToUpper()));
            standingCalfRaises.repsSets = "3 Sett, 6 - 8 reps";
            standingCalfRaises.rest = "2-3 minutt pause mellom hvert sett";

            var dumbellBenchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Dumbbell Bench Press".ToUpper()));
            dumbellBenchpress.repsSets = "3 Sett, 8 - 10 reps";
            dumbellBenchpress.rest = "1-2 minutter pause mellom hvert sett";

            var lateralRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Side Lateral Raise".ToUpper()));
            lateralRaises.repsSets = "2 Sett, 10 - 15 reps";
            lateralRaises.rest = "1-2 minutter pause mellom hvert sett";

            var skullCrushers = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("EZ-Bar Skullcrusher".ToUpper()));
            skullCrushers.repsSets = "3 Sett, 12 - 12 reps";
            skullCrushers.rest = "1-2 minutter pause mellom hvert sett";

            PushPullLegs.Add(new Exercise("Push"));
            PushPullLegs.Add(inclineBenchpress);
            PushPullLegs.Add(dumbellBenchpress);
            PushPullLegs.Add(lateralRaises);
            PushPullLegs.Add(skullCrushers);
  

            //pull

            var PullUps = exercises
            .Find(x => x.muscle_Targeted.Equals("Lats") && x.name.ToUpper().Equals("Pullups".ToUpper()));
            PullUps.repsSets = "3 Sett, 6 - 8 reps";
            PullUps.rest = "2 minutter pause mellom hvert sett";

            var barbellRow = exercises
            .Find(x => x.muscle_Targeted.Equals("Middle Back") && x.name.ToUpper().Equals("Bent Over Barbell Row".ToUpper()));
            barbellRow.repsSets = "3 Sett, 6 - 8 reps";
            barbellRow.rest = "2-3 minutter pause mellom hvert sett";

            var facePulls = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Standing face pull".ToUpper()));
            facePulls.repsSets = "3 Sett, 10 - 12 reps";
            facePulls.rest = "2 minutter pause mellom hvert sett";

            var bicepCurl = exercises
            .Find(x => x.muscle_Targeted.Equals("Biceps") && x.name.ToUpper().Equals("Dumbbell Bicep Curl".ToUpper()));
            bicepCurl.repsSets = "2 Sett, 12 - 15 reps";
            bicepCurl.rest = "1 minutt pause mellom hvert sett";

            PushPullLegs.Add(new Exercise("Pull"));
            PushPullLegs.Add(PullUps);
            PushPullLegs.Add(barbellRow);
            PushPullLegs.Add(facePulls);
            PushPullLegs.Add(bicepCurl);

            //Legs 

            var squat = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Barbell Squat".ToUpper()));
            squat.repsSets = "3 Sett, 5 - 8 reps";
            squat.rest = "2-3 minutter pause mellom hvert sett";

            var hipThrusts = exercises
           .Find(x => x.muscle_Targeted.Equals("Glutes") && x.name.ToUpper().Equals("Barbell Hip Thrust".ToUpper()));
            hipThrusts.repsSets = "3 Sett, 8 - 10 reps";
            hipThrusts.rest = "2 minutter pause mellom hvert sett";

            var legExtensions = exercises
            .Find(x => x.muscle_Targeted.Equals("Quadriceps") && x.name.ToUpper().Equals("Leg Extensions".ToUpper()));
            hipThrusts.repsSets = "3 Sett, 8 - 10 reps";
            hipThrusts.rest = "2 minutter pause mellom hvert sett";

            var legCurls2= exercises
            .Find(x => x.muscle_Targeted.Equals("Hamstrings") && x.name.ToUpper().Equals("Seated Leg Curl".ToUpper()));
            legCurls2.repsSets = "2 Sett, 10 - 12 reps";
            legCurls2.rest = "1-2 minutter pause mellom hvert sett";

            var seatedCalfRaise = exercises
            .Find(x => x.muscle_Targeted.Equals("Calves") && x.name.ToUpper().Equals("Seated Calf Raise".ToUpper()));
            seatedCalfRaise.repsSets = "4 Sett, 10 - 15 reps";
            seatedCalfRaise.rest = "1-2 minutt pause mellom hvert sett";

            PushPullLegs.Add(new Exercise("Legs"));
            PushPullLegs.Add(squat);
            PushPullLegs.Add(hipThrusts);
            PushPullLegs.Add(legExtensions);
            PushPullLegs.Add(legCurls2);
            PushPullLegs.Add(standingCalfRaises);
        }

        public void PPL6(List<Exercise> exercises)
        {

            //Push A

            var benchpress = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Barbell Bench Press - Medium Grip".ToUpper()));
            benchpress.repsSets = "3 Sett, 5 - 8 reps";
            benchpress.rest = "2-3 minutter pause mellom hvert sett";
            benchpress.video = "https://www.muscleandstrength.com/exercises/barbell-bench-press.html";


            var OHShoulderPress = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Seated dumbbell shoulder press".ToUpper()));
            OHShoulderPress.repsSets = "3 Sett, 8 - 10 reps";
            OHShoulderPress.rest = "2 minutter pause mellom hvert sett";

            var tricepDip = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("Triceps dip".ToUpper()));
            tricepDip.repsSets = "3 Sett, 8 - 12 reps";
            tricepDip.rest = "2 minutter pause mellom hvert sett";
            tricepDip.info = "Egenvekt, bruk strikk hvis det for tungt. " +
                "Ta vekter rundt livet hvis det er for lett.";

            var cableCrossover = exercises
            .Find(x => x.muscle_Targeted.Equals("Chest") && x.name.ToUpper().Equals("Cable Crossover".ToUpper()));
            cableCrossover.repsSets = "3 Sett, 8 - 12 reps";
            cableCrossover.rest = "2 minutter pause mellom hvert sett";

            var skullCrushers = exercises
            .Find(x => x.muscle_Targeted.Equals("Triceps") && x.name.ToUpper().Equals("EZ-Bar Skullcrusher".ToUpper()));
            skullCrushers.repsSets = "3 Sett, 12 - 12 reps";
            skullCrushers.rest = "1-2 minutter pause mellom hvert sett";
            skullCrushers.info = "Her kan du også bruke manualer, eller tau hvis ønskelig";

            var lateralRaises = exercises
            .Find(x => x.muscle_Targeted.Equals("Shoulders") && x.name.ToUpper().Equals("Side Lateral Raise".ToUpper()));
            lateralRaises.repsSets = "2 Sett, 10 - 15 -reps";
            lateralRaises.rest = "1-2 minutter pause mellom hvert sett";


        }


        public List<Exercise> push(List<Exercise> exercises, String x)
        {
            Random rnd = new Random();
            var chest = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Chest")
            && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
               && !x.equipment_Type.Equals("Medicine Ball") && !x.equipment_Type.Equals("Exercise Ball"))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(3).Distinct()
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



            PushPullLegs.Add(new Exercise("Push " + x.ToUpper()));
            PushPullLegs.AddRange(chest);
            PushPullLegs.AddRange(shoulders);
            PushPullLegs.AddRange(triceps);

            return PushPullLegs;
        }



        public List<Exercise> pull(List<Exercise> exercises, String x)
        {
            Random rnd = new Random();
            var midBack = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Middle Back")
                        && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
               && !x.equipment_Type.Equals("Medicine Ball"))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(2)
            .Select(x => x.v);

            var lowBack = exercises
           .FindAll(x => x.muscle_Targeted.Equals("Lower Back")
                     && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
              && !x.equipment_Type.Equals("Medicine Ball"))
           .Distinct().Select(v => new { v, i = rnd.Next() })
           .OrderBy(x => x.i).Take(1)
           .Select(x => x.v);

            var upperBack = exercises
          .FindAll(x => x.muscle_Targeted.Equals("Upper Back")
                         && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
              && !x.equipment_Type.Equals("Medicine Ball"))
          .Distinct().Select(v => new { v, i = rnd.Next() })
          .OrderBy(x => x.i).Take(1)
          .Select(x => x.v);


            var biceps = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Biceps")
                         && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other")
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
              && !x.equipment_Type.Equals("Medicine Ball")))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(2)
            .Select(x => x.v);

            PushPullLegs.Add(new Exercise("Pull " + x.ToUpper()));
            PushPullLegs.AddRange(midBack);
            PushPullLegs.AddRange(lowBack);
            PushPullLegs.AddRange(upperBack);
            PushPullLegs.AddRange(biceps);


            return PushPullLegs;
        }
        public List<Exercise> legs(List<Exercise> exercises, String x)
        {
            Random rnd = new Random();
            var Quadriceps = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Quadriceps")
                   && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other")
             && !x.equipment_Type.Equals("Bands"))
             && !x.equipment_Type.Equals("Medicine Ball"))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(2)
            .Select(x => x.v);

            var Hamstrings = exercises
           .FindAll(x => x.muscle_Targeted.Equals("Hamstrings")
              && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other")
             && !x.equipment_Type.Equals("Bands"))
             && !x.equipment_Type.Equals("Medicine Ball"))
          .Distinct().Select(v => new { v, i = rnd.Next() })
           .OrderBy(x => x.i).Take(2)
           .Select(x => x.v);

            var Calves = exercises
          .FindAll(x => x.muscle_Targeted.Equals("Calves")
             && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
                && !x.equipment_Type.Equals("Bands")
                && !x.equipment_Type.Equals("Medicine Ball"))
          .Distinct().Select(v => new { v, i = rnd.Next() })
          .OrderBy(x => x.i).Take(1)
          .Select(x => x.v);


            var Abdominals = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Abdominals"))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(2)
            .Select(x => x.v);

            PushPullLegs.Add(new Exercise("Legs + Abs " + x));
            PushPullLegs.AddRange(Quadriceps);
            PushPullLegs.AddRange(Hamstrings);
            PushPullLegs.AddRange(Calves);
            PushPullLegs.AddRange(Abdominals);

            return PushPullLegs;

        }
    }
}
