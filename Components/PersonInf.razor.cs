using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace ccBlazor.Components
{
    public partial class PersonInf
    {
        [Parameter]
        public String name { get; set; }
        [Parameter]
        public String surname { get; set; }
        [Parameter]
        public int mobile { get; set; }
        [Parameter]
        public String mail { get; set; }
        [Parameter]
        public String adresse { get; set; }
        [Parameter]
        public String postnr { get; set; }
        public List<string> GenderChoices { get; }
        public String gender { get; set; }
        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public PersonInf()
        {
            GenderChoices = new List<string>();
            GenderChoices.Add("Male");
            GenderChoices.Add("Female");
         
        }
        public void SetGender(string gender)
        {
            Console.WriteLine("gender er nå" + gender);
            this.gender = gender;

        }
    }
}
   
