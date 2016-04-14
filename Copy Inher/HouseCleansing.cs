using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher
{
    class HouseCleansing:Service
    {
        // Sibling to Magic using Service
        //Properties 
        internal string CreatePhrases;

        public virtual bool BlackMagic { get; set; }

        public virtual string Type { get; set; } 

        public virtual int PercentEffective { get; set; }

        public override string Name { get; set; } 

        // 1st method 
        public virtual void Work()
        {
            //ask for user input as to what type of living space
            Console.WriteLine("Please slect what type of Living Space you would like to Sage below");

            Console.WriteLine("1 |Apartment ");
            Console.WriteLine("2 |House ");
            Console.WriteLine("3 |Single room");
            Console.WriteLine("4 |Basement");
            Console.WriteLine("5 |all");
            int livingSpace = int.Parse(Console.ReadLine());
            //conosle write to begin the cleansing 
            Console.WriteLine("Let's begin to cleanse your home {0}.", this.Name, this.Type);
        }
        //method not working as of yet not sure why 
        public virtual void Show()
        {
            Console.WriteLine("your home has been cleansed", this.Name);
            Console.WriteLine(this.Result);
        }
        //method not working unknown
        public virtual void StateEffectiveness()
        {
            Console.WriteLine("This method of cleaning is {2} percent effective.", this.Name, this.Result, this.PercentEffective);
        }
    }
}




