using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person("Maria", 67, "Female");
            /* p1.name = "Ivan";
             p1.age = 23;
             p1.gender = "Man";*/
            // p1.showInfo();
            /*Person p1 = new Person();
            Person.showCount();

            Console.WriteLine(Person.count);
            Person p2 = new Person();
            Console.WriteLine(Person.count);
            Person p3 = new Person();
            Console.WriteLine(Person.count);*/

            /* Engine engine = new Engine();
             engine.manufacturer = "Motors";
             engine.power = 580;

             Car audi = new Car();
             audi.color = "Red";
             audi.brand = "Audi";
             audi.engine = engine;

             Console.WriteLine(audi.getMaxSpeed());*/

            
            



            Console.ReadLine();
        }

       
    }
    class Person
    {
        public static int count = 0;
        public string name;
        public int age;
        public string gender;

        public Person()
        {
            Console.WriteLine("Person was created");
            count++;
        }
        public Person(string name, int age, string gender)
        {

            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void showInfo()
        {
            Console.WriteLine("{0}, {1}, {2}", name, age, gender);
        }

        public static void showCount()
        {
            Console.WriteLine(count);
        }

    }
    class Car
    {
        private int _wheels;
        public int wheels
        {
            get { return wheels; }
            set { _wheels = value * 5; }
        }

        public string brand { get; set; }
        public string color { get; set; }
        public Engine engine { get; set; }

        public Car()
        {
            _wheels = 4;
        }

        public double getMaxSpeed()
        {
            double result = (engine.power * wheels) / 8;
            return result;
        }


        /*public Car()
        {
            Console.WriteLine("The car was created");
        }
        public Car(int WheelsCount, string brand, string color)
        {
            this.WheelsCount = WheelsCount;
            this.brand = brand;
            this.color = color;
        }*/


    }
    class Engine
    {
        public int power { get; set; }
        public string manufacturer { get; set; }
    }

    class Calculator
    {
        private double _num;
        public double num
        {
            get { return num; }
        }
        public void Add(int n)
        {
            _num += n;
        }
        public void Inc()
        {
            _num++;
        }
        public void Sub(int n)
        {
            _num -= n;
        }
        public void Dec()
        {
            _num--;
        }
        public void Mult(int n)
        {
            _num *= n;
        }
        public void Div(int n)
        {
            _num /= n;
        }
    }


}
