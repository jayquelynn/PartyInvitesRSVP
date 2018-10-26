using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFarm
{
    class Farm
    {
        static void Main(string[] args)
        {
            Dog aDog = new Dog();
            aDog.Speak();
            aDog.Eats();
            aDog.Sound();
            aDog.Activity();

            Cat aCat = new Cat();
            aCat.Speak();
            aCat.Eats();
            aCat.Sound();
            aCat.Activity();

            Horse aHorse = new Horse();
            aHorse.Speak();
            aHorse.Eats();
            aHorse.Sound();
            aHorse.Activity();

            Sheep aSheep = new Sheep();
            aSheep.Speak();
            aSheep.Eats();
            aSheep.Sound();
            aSheep.Activity();

            Pig aPig = new Pig();
            aPig.Speak();
            aPig.Eats();
            aPig.Sound();
            aPig.Activity();

            Cow aCow = new Cow();
            aCow.Speak();
            aCow.Eats();
            aCow.Sound();
            aCow.Activity();

            Console.ReadKey();


        }
    }
}
