using System;
using System.Collections.Generic;
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
        public String gender { get; set; }
        public double weight { get; set; }
        public double height { get; set; }

        public int activityLevel {get; set; }

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
        public List<String> preferedDays { get; }

        public List<String> allergys { get; }

        public List<String> disLikes { get; }

        public List<int> goals { get; set; } = new List<int>();

        public void addAllergy(String allergy)
        {
      
                allergys.Add(allergy);
          
        }
        public void addDislikes(String dislike)
        {

            disLikes.Add(dislike);

        }

        public void SetWeight(double weight)
        {
            Console.WriteLine(weight);
            this.weight = weight;
          
        }
        public void SetHeight(double height)
        {
            Console.WriteLine(height);
            this.height = height;
            
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
            Console.WriteLine(goal + " " + add);
            
            if (add)
            {
                this.goal.Add(goal);
            }
            else
            {
                this.goal.Remove(goal);
            }
            Console.WriteLine(this.goal.Count);
        }
        public void setActivityLevel(String value)
        {
            this.activityLevel = int.Parse(value);
        
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
        }

        public void setTrainingDays(String value)
        {
            this.trainingDays = int.Parse(value);
            Console.WriteLine(value);
        }
        public void setMealAmount(String value)
        {
            this.mealAmount = int.Parse(value);
            Console.WriteLine(value);
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

