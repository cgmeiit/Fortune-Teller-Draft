﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher
{
    class CrystalBall : Magic,IRandomPhrase
    {
        //straight up field. I really don't need a property. Just using globally so random behaves well.
       // private Random random = new Random();//changed due to 

        //properties
        public List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Crystal Ball";

        public override Enum Difficulty { get; set; } = DifficultyOptions.easy;

        public Random Rnd { get; set; }=new Random();
        //changed from field to property b/c of Interface 


        public override void Work()
        {
           // base.Work();
            //now let's call a method that will get a result for the crystal ball
            this.Result = GetPhrase();

        }

        public void CreatePhrases()
        {
            Phrases.Add("Night time is a dark place for you.");
            Phrases.Add("I see shiny objects in your near future");
            Phrases.Add("The decorating around you needs some help.");
        }

        //let's create an overloaded method now
        public void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }

        public string GetPhrase()
        {
            //local variable
            int randomNumber =Rnd.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);

        }

        
        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public CrystalBall()
        {
            this.Price = 45.00M;
            this.PercentEffective = 65;
            this.BlackMagic = false;
            this.Expertise = "beginner";
            Program.AvailableServices.Add((Service)this);

            //I want to call my initializer for phrases.
            CreatePhrases();
        }

    }


}
