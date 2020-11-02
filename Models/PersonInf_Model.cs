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
        public String goal { get; set; }
        public List<string> GenderChoices { get; }
        public List<string> GoalChoices { get; }
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

            GoalChoices = new List<string>();
            GoalChoices.Add("Vektnedgang");
            GoalChoices.Add("Muskeløkning");
            GoalChoices.Add("Vedlikehold");
            GoalChoices.Add("Fettreduksjon");
        }
        public void SetGender(string gender)
        {
            this.gender = gender;
        }
        public void SetGoal(string goal)
        {
            this.goal = goal;
         
        }

    }

}

