using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher
{
    class Palm_reading:Magic,IRandomPhrase
    {
        public List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Palm Reading";

        public override Enum Difficulty { get; set; } = DifficultyOptions.easy;

        public Random Rnd { get; set; } = new Random();
        //changed from field to property b/c of Interface 


        public override void Work()
        {
            //base.Work();
            //now let's call a method that will get a result for the crystal ball
            this.Result = GetPhrase();
          

        }

        public void CreatePhrases()
        {
            Phrases.Add("Your right palm life line reads that you will become a zombie in next 5 years.");
            Phrases.Add("On your left palm I see you traveling across the Atlantic Ocean to buy unusual shoes");
            Phrases.Add("There will be a $100000.00 waiting for you at end of this reading.");
        }

        //let's create an overloaded method now
        public void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }

        public string GetPhrase()
        {
            //local variable
            int randomNumber = Rnd.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);

        }


        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public Palm_reading()
        {
            this.Price = 45.00M;
            this.PercentEffective = 65;
            this.BlackMagic = false;
            this.Difficulty=Difficulty;
            Program.AvailableServices.Add((Service)this);
            //I want to call my initializer for phrases.
            CreatePhrases();
        }

    }
}
