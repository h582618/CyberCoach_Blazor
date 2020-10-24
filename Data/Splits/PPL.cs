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
        public PPL(List<Exercise> exercises)
        {
            push(exercises);
            pull(exercises);
            legs(exercises);

        }
        public List<Exercise> push(List<Exercise> exercises)
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
          .OrderBy(x => x.i).Take(3)
          .Select(x => x.v);

            var triceps = exercises
            .FindAll(x => x.muscle_Targeted.Equals("Triceps")
                         && (!x.equipment_Type.Equals("Body Only")
             && !x.equipment_Type.Equals("None") && !x.equipment_Type.Equals("Other"))
              && !x.equipment_Type.Equals("Kettlebells") && !x.equipment_Type.Equals("Bands")
               && !x.equipment_Type.Equals("Medicine Ball"))
            .Distinct().Select(v => new { v, i = rnd.Next() })
            .OrderBy(x => x.i).Take(3)
            .Select(x => x.v);

          

            PushPullLegs.Add(new Exercise("Push"));
            PushPullLegs.AddRange(chest);
            PushPullLegs.AddRange(shoulders);
            PushPullLegs.AddRange(triceps);

            return PushPullLegs;
        }
        public List<Exercise> pull(List<Exercise> exercises)
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

            PushPullLegs.Add(new Exercise("Pull"));
            PushPullLegs.AddRange(midBack);
            PushPullLegs.AddRange(lowBack);
            PushPullLegs.AddRange(upperBack);
            PushPullLegs.AddRange(biceps);


            return PushPullLegs;
        }
        public List<Exercise> legs(List<Exercise> exercises)
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

            PushPullLegs.Add(new Exercise("Legs + Abs"));
            PushPullLegs.AddRange(Quadriceps);
            PushPullLegs.AddRange(Hamstrings);
            PushPullLegs.AddRange(Calves);
            PushPullLegs.AddRange(Abdominals);

            return PushPullLegs;

        }
    }
}
