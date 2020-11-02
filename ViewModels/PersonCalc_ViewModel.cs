using System;
using System.Collections.Generic;
using ccBlazor.Models;

namespace ccBlazor.ViewModels
{
    public interface IPersonCalc_ViewModel
    {
        int Age { get; set; }
        double Weight { get; set; }
        String Activity { get; set; }
        String Goal { get; set; }
        String Gender { get; set; }
        int GymDays { get; set; }
        List<String> GenderChoices { get; }

        void SetAge(int age);
        void SetWeight(double weight);
        void SetGender(String gender);
        void SetActivity(String activity);
        void SetGoal(String goal);
        void SetGymDays(int gymDays);
    }
    public class PersonCalc_ViewModel : IPersonCalc_ViewModel
    {
        private IPersonCalc_Model _personCalc_Model;
        private int _age;
        private double _weight;
        private String _activity;
        private String _goal;
        private String _gender;
        private int _gymDays;

        public PersonCalc_ViewModel(PersonCalc_Model personCalc_Model)
        {
            _personCalc_Model = personCalc_Model;
            GenderChoices = new List<string>();
            GenderChoices.Add("Male");
            GenderChoices.Add("Female");
        }
        public List<string> GenderChoices { get; private set; }
        public int Age { get => _age; set => _age = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public string Activity { get => _activity; set => _activity = value; }
        public string Goal { get => _goal; set => _goal = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int GymDays { get => _gymDays; set => _gymDays = value; }

        public void SetActivity(string activity)
        {
            _activity = activity;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void SetGender(string gender)
        {
            Console.WriteLine(gender);
            _gender = gender;
            _personCalc_Model.SetGender(gender);
        }

        public void SetGoal(string goal)
        {
            _goal = goal;
        }

        public void SetGymDays(int gymDays)
        {
            _gymDays = gymDays;
        }

        public void SetWeight(double weight)
        {
            _weight = weight;
        }
    }
}
