using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //Create a Dog class
        //Your dog class should have fields for hair length, height, running speed and weight
        //Your class should have the following behaviors: run, bark, potty, cuddle
        //You should have at least one constructor

        private string hairLength;
        private int height;
        private int runningSpeed;
        private int weight;
        private bool crap = true;
        // private double barkVolume under indivisibility cloak




        //Properties
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public double BarkVolume { get; set; }

        public Dog()
        {
            //this is my default constructor
        }

        public Dog(string hairLength, int height, int runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
            //this is typical way you will see it set up
        }

        public int Run()
        {
            Console.WriteLine("Go doggy go!");
            RunningSpeed -= 1;
            return RunningSpeed;
        }
        public void Bark()
        {
            Console.WriteLine("Bark bark bark");
        }
        public int Potty()
        {
            if(crap == true)
            {
                Console.WriteLine("Your dog just made a mess");
                weight -= 1;
            }
            else
            {
                Console.WriteLine("Your dog has to alleviate itself.");
                weight = weight;
            }
        }
        public void Cuddle()
        {
            Console.WriteLine("Aww");
        }
    }
}
