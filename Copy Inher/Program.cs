using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Inher
{
    class Program
    {
        static void Main(string[] args)
        {
           // our game will start here
            //let's create a fortune teller
            FortuneTeller fortuneTeller = new FortuneTeller();
            CrystalBall crystalBall = new CrystalBall();
            //numerology seetting 
            Numerology numerology = new Numerology();
            fortuneTeller.Greet(); //say hi
            fortuneTeller.StartService((Service)numerology); //talk about the service that's being performed
            crystalBall.Work(); //run it (do the service)
            crystalBall.Show(); //display it (state results of the service)
            numerology.StateEffectiveness(); //state effectiveness of service.
            fortuneTeller.Farewell(); //say goodbye.
            numerology.MatchPhrases();
            Console.WriteLine(numerology.BlackMagic); // Console.WriteLine("Whats your favorite number ");
            //sibling to magic HouseCleansing 
            HouseCleansing cleansing = new HouseCleansing();
            fortuneTeller.StartService((Service)cleansing); //talk about the service that's being performed
            cleansing.Work(); //run it (do the service)
            cleansing.Show(); //display it (state results of the service)
            cleansing.StateEffectiveness(); //state effectiveness of service.
            fortuneTeller.Farewell(); //say goodbye.
            cleansing.CreatePhrases="";
            Console.WriteLine(cleansing.BlackMagic);
           


        }


    }
}

