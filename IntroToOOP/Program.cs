using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //When we intitialize a new object, it is called INSTANTIATING (creating a new instance)
            //An object needs to be instantiated before it can be used
            //All objects of a specific type are created from the same template - called a class (class like blueprint for what object will be)
            //All objects from a class will have the same number and type of states
            //BUT each instance can have it's own unique values

            //The format we use to instantiate an object looks like this:
            //ClassName objectName = new ClassName();
            Cat firstCat = new Cat();
            firstCat.Name = "Mittens";

            Cat secondCat = new Cat("Oz", 3, "Orange and white");
            secondCat.Name = "Ozzy";
            Console.WriteLine(secondCat.Name);

            secondCat.IsHungry = true;
            Console.WriteLine(secondCat.IsHungry);
            secondCat.Eat();
            Console.WriteLine(secondCat.IsHungry);

            //Dog firstDog = new Dog("short", 10, 10, 80);



            //To create a new object, we use special method called a CONSTRUCTOR

            //Thinking about objects in real life create thre examples of objects
            //Your objects should have five states and five behaviors

            //Object One: Building
            //States: Height, Windows, Walls, Rooms, Roof
            //Behaviors: HousesPeople, GetsBuilt, CastsShadows, AbsorbsSunlight, ProvidesProtection

            //Object Two: Meeting
            //States: invitees, topics, startTime, location, purpose
            //Behaviors: AllowsDecisionsToBeMade, FacilitatesSolutions, BringsPeopleTogether, GetsPlanned






            //Superhero firstHero = new Superhero(); //instantiating object - first hero

            ////firstHero.StrengthLevel = 100;
            ////firstHero.HasCape = true;

            ////firstHero.BattleNemesis();
            ////Console.WriteLine(firstHero.HasCape);
            ////Console.WriteLine(firstHero.StrengthLevel);

            ////firstHero.BattleNemesis();
            ////Console.WriteLine(firstHero.HasCape);
            ////Console.WriteLine(firstHero.StrengthLevel);

            //Superhero secondHero = new Superhero("Diamond Daniel");
            ////Console.WriteLine(secondHero.StrengthLevel);

            ////secondHero.AllyGain();
            ////Console.WriteLine(secondHero.StrengthLevel);

            //Superhero thirdHero = new Superhero("black Kevlar body armor", "The Best Ever", 1000, "Being the best", false);


            //Console.WriteLine(thirdHero.Costume + thirdHero.StrengthLevel);
            //thirdHero.BattleNemesis();
            //Console.WriteLine("Oh no! Now my costume is " + thirdHero.Costume);
            //Console.WriteLine("And my strength has diminished " + thirdHero.StrengthLevel);
            //Console.WriteLine(thirdHero.Costume + thirdHero.StrengthLevel);

        }
    }
}
