using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat //writing this and the curly braces defines the class?
    {
        //Inside of our class, we create the blueprint for our object.
        //Classes are templates in OOP that we use to create objects.
        //They should always be named in Pascal Case.

        //In OOP, there are two types of states:
        //Fields - variables that belong to a class
        private string name; // (create field) *fields usually have private access modifiers
        private int age;
        private string furColor;
        private bool isHungry = true;


        //Properties - a sort of mix between a field and a method that allow controlled access
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }

        }

        //We also have Behaviors.
        //Methods - repeatable or reusable sections of code - Actions
        //Constructors - specialized methods that are used when instantiating an object
        // - allow us to control the state of an object upon creation
        // - allow us to perform any actions the object might need upon creation
        // - always share the name of the class (in this case cat)

        public Cat()
        {
            //This is an example of a default constructor. A default constructor takes no arguments/parameters 
            //default constructors are really common, they 
        }

        //you can have as many constructors as you need as long as they each have a unique signature
        //signature - the parameters in teh parentheses after the constructor name.
        public Cat(string name, int age, string furColor) //another constructor?
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
            //overloading
        }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    }
}


