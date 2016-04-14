using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher
{
    class Apartment:HouseCleansing
    {
        //child to HouseCleansing
       private Random random = new Random();
  


        //properties
        public List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Spiritual Cleansing";


        public override void Work()
        {
            base.Work();
            //now let's call a method that will get a result 
            this.Result = GetPhrase();

        }

        protected new void CreatePhrases()
        {
            Phrases.Add("The living space has been cleansed of all bad energy.");
            Phrases.Add("the feeling of your home is reflecting positive vibes.");
            Phrases.Add("The dark energy in the basement has been removed.");
        }

        //not working 
        protected new void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }
        //not working 
        private string GetPhrase()
        {
            //local variable
            int randomnumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomnumber);

        }

        //constructor
        //this is to inherit from  HouseCleansing andService not working help.
        public Apartment()
        {
            this.Price = 45.00M;
            this.PercentEffective = 85;
            this.BlackMagic = true;
            this.Type = "Living Space ";
            //I want to call my initializer for phrases.
            CreatePhrases();
        }
    }
}
