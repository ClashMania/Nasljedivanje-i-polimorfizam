using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje_i_polimorfizam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Desert 
    {
        private string name;
        private double weight;
        private int calories;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }

        

        public override string ToString()
        {
            
        }
    }


    class Cake : Desert
    {
        Boolean containsGluten;
        string cakeType;

        public Boolean ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }
    }

    class IceCream : Desert
    {
        string flavour, color;


        public string Flavour { get => flavour; set => flavour = value; }
        public string Color { get => color; set => color = value; }
    }

    class Person 
    {
        string name, surname;
        int age;
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        
    }

    class Student : Person 
    {
        string studentId;
        short academicYear;


        public string StudentId { get => studentId; set => studentId = value; }
        public short AcademicYear { get => academicYear; set => academicYear = value; }
    }

    class Teacher : Person 
    {
    string email, subject;
    double salary;


     public string Email { get => email; set => email = value; }
     public string Subject { get => subject; set => subject = value; }
     public double Salary { get => salary; set => salary = value; }
    }

}
