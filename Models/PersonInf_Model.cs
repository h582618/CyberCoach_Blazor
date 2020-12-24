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
        public int age { get; set ; }
        [Parameter]
        public String mail { get; set; }
        [Parameter]
        public String adresse { get; set; }
        [Parameter]
        public String postnr { get; set; }
        [Parameter]
        public List<int> goal { get; set; }
        public List<string> GenderChoices { get; }
        public Dictionary<int,string> GoalChoices { get; }
        public String gender { get; set; }
        public decimal weight { get; set; }
        public decimal height { get; set; }
        public bool CheckBox1Value;
        public bool? CheckBox2Value;
        public bool? CheckBox3Value = true;
        //Per nå er det en list emed
        public List<int> goals { get; set; } = new List<int>();



        public void SetWeight(decimal weight)
        {
            Console.WriteLine(weight);
            this.weight = weight;
            foreach(int x in goals){
                Console.WriteLine(x);
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

    }

}

