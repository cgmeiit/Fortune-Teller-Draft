using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher
{
    interface IRandomPhrase
    {
        Random Rnd { get; set; }
        List<string> Phrases { get; set; }
        void CreatePhrases();
        string GetPhrase();
        //any class that uses this interface will use this in their classes. 
        //Interface must be public always so when adding the Interface name ex IRandomPhrase and it is red check all your methods and make sure the interface is PUBLIC. 
        //interfaces can be implmnetated in the classes as many as you want.
        //keep them small because if you need to make changes you will need to change all the classess this can become overwhelming processing. Keep them short and sweet. 

    }
}
