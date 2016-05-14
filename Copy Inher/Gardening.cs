using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher
{
    class Gardening:Service
    {
        

        //how about another property that gives us the effectiveness of this magical item?
        public virtual new int PercentEffective { get; set; }

        //let's make sure all of them have a name!
        public override string Name { get; set; }

        //let's throw in the level of expertise the fortune teller needs to use this item
        protected virtual string Expertise { get; set; }

        public override decimal Price { get; set; }

        public override string Result { get; set; }





        //How about a  work -- "make it go now" method?
        //public virtual void Work()
        //{
        //    Console.WriteLine("Let's begin to plant our garden {0}", this.Name);
        //}
        //What about a Show method for sharing the results -- showing the magical object to the user?
        //public virtual void Show()
        //{
        //    Console.WriteLine("Oh, my. The {0} told me, yes, your future.", this.Name);
        //    Console.WriteLine(this.Result);
        //}
        //public virtual void StateEffectiveness()
        //{
        //    Console.WriteLine("In case you're wondering, this method is {2} percent effective.", this.Name, this.Result, this.PercentEffective);
        //}
    }
}

