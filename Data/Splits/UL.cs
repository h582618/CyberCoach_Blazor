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
        public UL(List<Exercise> exercises)
        {
            upper(exercises, "A");
            lower(exercises, "A");

            upper(exercises, "B");
            lower(exercises, "B");


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
    }
}
