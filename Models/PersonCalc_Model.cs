using System;
namespace ccBlazor.Models
{
    public interface IPersonCalc_Model
    {
        Func<String> EvaluateScore { get; set; }

        void CalculatePlan();
        void CalculateCals();
        void SetAge(int age);
        void SetWeight(double weight);
        void SetGender(String gender);
        void SetActivity(String activity);
        void SetGoal(String goal);
        void SetGymDays(int gymDays);
    }
    public class PersonCalc_Model : IPersonCalc_Model
    {
        private int _age;
        private double _weight;
        private String _activity;
        private String _goal;
        private String _gender;
        private int _gymDays;

        public Func<string> EvaluateScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalculatePlan()
        {
            throw new NotImplementedException();
        }

        public void CalculateCals()
        {
            throw new NotImplementedException();
        }

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
            _gender = gender;

            switch (_gender)
            {
                case "Female":
           
                    break;

                case "Male":
                 
                    break;
            }
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
