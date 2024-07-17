using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Model
{
    internal class Person
    {
        private const double HEIGHT = 1.524, WEIGHT =50;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Person( int id , string name , int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = HEIGHT;
            Weight = WEIGHT;

        }
        public Person(int id, string name, int age , double height , double weight):this(id , name , age) 
        { 
            Height = height; 
            Weight = weight;
        }

        public static double CalculateBmi(double height , double weight) 
        {
            double bmi = weight / (height * height);
            return bmi;
        }

        public static string FindBodyType(double bmi) 
        {
            if (bmi < 18.5)
                return $"Your BMI is : {bmi}\nYou are Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                return $"Your BMI is : {bmi}\nYou are Healthy";
            else if (bmi >= 25 && bmi <= 29.9)
                return $"Your BMI is : {bmi}\nYou are Overweight";
            else
                return $"Your BMI is : {bmi}\nYou are Obese";
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Age: {Age}\n" +
                $"Height: {Height}\n" +
                $"Weight: {Weight}\n";
        }
    }
}
