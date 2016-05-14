using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher

{
    //enum buildignand using a enum creates a drop down.
    internal enum DifficultyOptions { easy, medium, hard };
    abstract class Service
    {
     

        //Properties
        //services have costs
        //I want this to be overrideable.
        public abstract decimal Price { get; set; }

        //all services have a name.
        public abstract string Name { get; set; }

        //Let's make a property to store some result. Let's just say it's a single result and it's a string.
        public abstract string Result { get; set; }

        public int PercentEffective { get; private set; }

        public virtual Enum Difficulty { get; set; } = DifficultyOptions.medium;


        // public virtual string CreatePhrases2 { get; set; }

        //We might want to track other things too, but we can add on later if we'd like

        public virtual void Work()
        {
            Console.WriteLine(this.Name);
        }
        public virtual void Show()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Result);
        }
        public virtual void StateEffectiveness()
        {
            Console.WriteLine( this.Name, this.Result, this.PercentEffective);
        }
    }

}
