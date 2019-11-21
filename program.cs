using System;
using System.Linq;
namespace AnimalClass
{
 
    public class Animal
    {
        public string name;
        public int lifeSpan;
        public double weight;

        public Animal (string _name, int _lifeSpan, double _weight)
        {
            name = _name;
            lifeSpan = _lifeSpan;
            weight = _weight;

        }
        public void displayBasicData()
        {
            Console.WriteLine($"The animal's name is: {name}");
        }
        public void displayLifeSpan ()
        {
            Console.WriteLine($"The animal's lifeSpan: {lifeSpan}");
        }
        public void displayWeiht()
        {
            Console.WriteLine($"The animal's weight: {weight}");
        }
        public void makeAnimalEat ()
        {
            weight +=0.2; 

        }
        public void makeAnimalLoseWeight ()
        {
            weight -=0.1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal hamster = new Animal("ham", 0, 1);

            for (int i = 0; i <= 10; i++)
            {
                hamster.lifeSpan++;
                hamster.makeAnimalEat();
                if (hamster.weight > 0.7 && hamster.lifeSpan != 10)
                {
                    hamster.makeAnimalLoseWeight();
                }
                else if (hamster.lifeSpan == 10)
                {

                    Console.WriteLine($"The hamster named {hamster.name} is dead");
                    break;

                }
            }
        }
    }

}
