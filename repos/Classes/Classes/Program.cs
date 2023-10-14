using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Classes
{
    internal class Program
    {
        public class Human
        {
            public string Name; // by deafault classes have these atributes unacessable/private  
            public string Lastname;  // attributes == variables 
            public int Age;
            public string fullname;
            public int Legs;
            public string Genes;
            
            public Human(string name, string lastname, int age, string genes) // overloaded constructor
            {
                this.Name = name;
                this.Lastname = lastname;
                this.Age = age;
                this.fullname = name + " " + lastname;
                this.Genes = genes;

                if (Genes == "Human")
                {
                    this.Legs = 2;
                    Console.WriteLine($"i have {Legs} legs");
                }
            }
        

            public void Speak() // Behavior == Methods == Functions
            {
                Console.WriteLine($"Hi my name is {this.Name} {this.Lastname} and im {this.Age} years old"); // this. means to refer to the classes atributes 
            }

            public void Eat(string food)
            {
                Console.WriteLine($"{this.Name} is going to eat some {food} for lunch today");
            }

        }
        
        
        static void Main(string[] args)
        {
            Human Erik = new Human("Erik","Dadashyan", 20, "Human");
            Human John = new Human("John","Kowaski",30,"Human");
            Console.WriteLine(Erik.Name);
            Console.WriteLine(Erik.Age);
            Console.WriteLine(Erik.Lastname);

            Console.WriteLine(Erik.fullname);

            Erik.Speak();
            John.Speak();
            Erik.Eat("Apple");
            Console.ReadLine(); // just makes sure that terminal doesnt close instantly 
        }
    }
}
