using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher
{
    class Numerology : Magic,IRandomPhrase

    {
        public List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Numerology";

        public override Enum Difficulty { get; set; } = DifficultyOptions.easy;

        public Random Rnd { get; set; } = new Random();
       

        //method
        public override void Work()
        {
            this.Result = GetPhrase();
            //now let's call a method that will get a result for the crystal ball
            //this.Result = GetPhrase();

        }

        public void CreatePhrases()
        {
            //ask user to inpit number 1-5


            //Console.WriteLine("Please enter your favorite number, 1-5.");
            //int userNum = int.Parse(Console.ReadLine());

            ////setup swtich case to read each number and console write the # definition for the number choosen.
            //string numfortune = "";

            //switch (userNum)
            {
                 Phrases.Add ("1 is a doer, a powerful force that produces results and does not allow anything or anyone to limit its potential.");
                   
                 Phrases.Add("2 You will recognize a symbolic representation of the ultimate survivor and an extremely resilient force");
               
                 Phrases.Add("3 Is like a gifted teenager who is still under the protection of its parents: a bit spoiled, certainly scattered and perpetually in need of guidance. ");
                     Phrases.Add(" 4 You will see that the hard angles are a proper symbolic representation of this rather straight-edged workaholic, who is neither creative nor artistic, but is good at working with his hands");
                    
                 Phrases.Add(" 5 Generally does not find a suitable career until she has tried a number of different jobs, many of them lasting barely long enough to warrant a full paycheck, especially if there is any kind of routine involved boredom sets in almost immediately.");
                   

            }
        }

        public string GetPhrase()
        {
           
            Console.WriteLine("Please enter your favorite number, 1-5.");
            int userNum = int.Parse(Console.ReadLine());
           
            return Phrases.ElementAt(userNum-1);
        }

        //write the the numereology def for user input.

        // default constructor for that will populate to the console  
        public Numerology()
        {
            this.Price = 15.00M;
            this.PercentEffective =70;
            this.BlackMagic = true;
            this.Expertise = "beginner";
            Program.AvailableServices.Add((Service)this);
            //I want to call my initializer for phrases.
            CreatePhrases();

        }
    }
}



