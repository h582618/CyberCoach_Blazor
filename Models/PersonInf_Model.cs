using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace ccBlazor.Components
{
    public class PersonInf_Model
    {
        [Parameter]
        public String name { get; set; }
        [Parameter]
        public String surname { get; set; }
        [Parameter]
        public int mobile { get; set; }
        [Parameter]
        public int age { get; set; }
        [Parameter]
        public String mail { get; set; }
        [Parameter]
        public String adress { get; set; }
        [Parameter]
        public String postnr { get; set; }
        [Parameter]
        public List<int> goal { get; set; }
        public List<string> GenderChoices { get; }
        public Dictionary<int, string> GoalChoices { get; }
        public String gender { get; set; } = "Male";
        public double weight { get; set; }
        public double height { get; set; }

        public int activityLevel {get; set; }
        public int experienceLevel { get; set; }

        public bool submitted { get; set; }

        public bool weightLoss { get; set; } 
        public bool muscleIncrease { get; set; } 
        public bool maintenance { get; set; }
        public bool fatLoss { get; set; }

        public bool weaknessShoulder { get; set; }
        public bool weaknessBack { get; set; }
        public bool weaknessChest { get; set; }
        public bool weaknessArms { get; set; }
        public bool weaknessCore { get; set; }
        public bool weaknessAss { get; set; }
        public bool weaknessLegs { get; set; }

        public int trainingDays { get; set; }
        public int mealAmount { get; set; }
        public List<String> preferedDays { get; set; }

        public List<String> allergys { get; }

        public List<String> disLikes { get; }

        public List<int> goals { get; set; } = new List<int>();


        //Eller (daysofweek value + 6) % 7
        public enum DayOfWeek
        {    
            Monday = 0,
  
            Tuesday = 1,
          
            Wednesday = 2,
           
            Thursday = 3,
          
            Friday = 4,
       
            Saturday = 5,

            Sunday = 6,
        }

        public void addAllergy(String allergy)
        {
      
                allergys.Add(allergy);
          
        }
        public void addDislikes(String dislike)
        {

            disLikes.Add(dislike);

        }

        public void SetWeight(String weight)
        {
            if(weight.Trim() != "")
            {
                this.weight = Int64.Parse(weight);
            }
 
        }
        public void SetHeight(String height)
        {
            if (height.Trim() != "")
            {
                this.height = Int64.Parse(height);
            }

        }

        public void SetMail(String mail)
        {
            Console.WriteLine(mail);
            this.mail = mail;
        }

        public void SetAge(int age  )
        {

            Console.WriteLine(age);
            this.age = age;
        }

        public void setName(String name)
        {
            Console.WriteLine(name);
            this.name = name;
        }


        public void setSurname(String surname)
        {
            Console.WriteLine(surname);
            this.surname = surname;
        }

        public PersonInf_Model()
        {
            GenderChoices = new List<string>();
            GenderChoices.Add("Male");
            GenderChoices.Add("Female");
            GoalChoices = new Dictionary<int,string>();
            GoalChoices.Add(1,"Vektnedgang");
            GoalChoices.Add(2,"Muskeløkning");
            GoalChoices.Add(3,"Vedlikehold");
            GoalChoices.Add(4, "Fettreduksjon");
            goal = new List<int>();

            preferedDays = new List<String>();

            allergys = new List<String>();

            disLikes = new List<String>();

        }
        public void SetGender(string gender)
        {
            Console.WriteLine(gender);
            this.gender = gender;
        }
        public void SetGoal(int goal, bool add)
        {
         
            
            if (add)
            {
                this.goal.Add(goal);
            }
            else
            {
                this.goal.Remove(goal);
            }
          
        }
        public void setActivityLevel(String value)
        {
            this.activityLevel = int.Parse(value);
        
        }

        public void setExperienceLevel(String value)
        {
            this.experienceLevel = int.Parse(value);

        }
        public void setPreferedDays(String value, bool add)
        {
            if (!preferedDays.Contains(value) && trainingDays > preferedDays.Count )
            {
                this.preferedDays.Add(value);
            }
            else if(preferedDays.Contains(value))
            {
                this.preferedDays.Remove(value);
            } else
            {

            }
            this.preferedDays = preferedDays.OrderBy(s => Enum.Parse(typeof(DayOfWeek), (char.ToUpper(s[0]) + s.Substring(1)))).ToList();

        }

        public void setTrainingDays(String value)
        {
            int difference = preferedDays.Count - int.Parse(value);
            this.trainingDays = int.Parse(value);
            if(difference > 0)
            {
               for(int i = 0; i < difference; i++)
                {
                    preferedDays.RemoveAt(preferedDays.Count - 1);
                }
            };
      
        }
        public void setMealAmount(String value)
        {
            this.mealAmount = int.Parse(value);
            
        }

        public void removeAllergy(String value)
        {
            allergys.Remove(value);
        }

        public void removeDislike(String value)
        {
            disLikes.Remove(value);
        }
    }

}

