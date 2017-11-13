using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    class gangstergame

    {
        static void Main(string[] args)
        {
           
            string Saythx = "";

            int milliseconds = 3000;
            Thread.Sleep(milliseconds);
            Textcontainer.Starttxt();

            Console.ForegroundColor = ConsoleColor.Yellow;




            string Typename = " ";
            Console.WriteLine("\r\n" + "hey manno Whats your name ?");
            Typename = Console.ReadLine();
            Console.WriteLine("okay " + Typename + " Welcome to the crew!");
            Thread.Sleep(milliseconds);
            Console.WriteLine("First of all we need to set you up with a piece");
            Thread.Sleep(milliseconds);
            Console.WriteLine("Here you go man!");
            Textcontainer.Gun1();


            while (true)
            {


                Saythx = Console.ReadLine();
                if (Saythx != "Thanks")
                {

                    Console.WriteLine("Don't be dissrespectfull! and say ((Thanks)) and take it! ");

                }
                else
                {
                    Console.WriteLine("You are Welcome e'se");
                    Thread.Sleep(milliseconds);


                    break;
                }

            }
            Console.WriteLine("Mission 1");
            Thread.Sleep(milliseconds);
            Console.WriteLine("okay manno.now take the car and go prove yourself!");
            Thread.Sleep(milliseconds);
            Console.WriteLine("up at 9'th there is a store run by Niggers!");
            Console.WriteLine("thats mexican turf!");
            Thread.Sleep(milliseconds);
            Console.WriteLine("there's a door on the back of the building go see if you");
            Console.WriteLine("can figure out the code. we might need that later! ");
            Thread.Sleep(milliseconds);
            Console.WriteLine("so take your shitty car and DO it!");
            Thread.Sleep(milliseconds);
            Mission1();

        }
        public static void Mission1()
        {
            string missionone = "";
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);
            Console.ForegroundColor = ConsoleColor.Yellow;


            //Mission one!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Textcontainer.Mission1();
            Thread.Sleep(milliseconds);
            Textcontainer.Mission1b();
            Thread.Sleep(milliseconds);
            Textcontainer.Mission1y();
            Thread.Sleep(milliseconds);
            Textcontainer.Mission1w();
            Console.WriteLine(" witch one is it (Nr 1, Nr 2 or Nr 3) ese" );


            while (true)
            {


                missionone = Console.ReadLine();
                if (missionone != "Nr 1")
                {
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("How stupid are you! Thats Not The NIgger Store!!");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Finnaly! now we need to go back and find the code box! and guess the code! ");
                    Thread.Sleep(milliseconds);

                    Console.ReadLine();
                    break;

                }


            }
            Textcontainer.Mission1code();
            Textcontainer.Mission1codelock();
            while (true)
            {


                missionone = Console.ReadLine();
                if (missionone != "8741")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wrong Code Carnal! Quickly Before the Mayate's Come!");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Good ese, now remember the code (8741), W'll Come back later at Teach them a leason! ");
                    Thread.Sleep(milliseconds);

                    Console.ReadLine();
                    break;

                }


            }
            Textcontainer.Thedrive();
            Thread.Sleep(milliseconds);
            Textcontainer.Enterdinner();
            Thread.Sleep(milliseconds);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Come on ese! make up your mind! ");
            Console.ReadLine();
            while (true)
            {

                
                missionone = Console.ReadLine();
                if (missionone != "Start shooting")
                {
                    
                    Textcontainer.Thesetup();
                    
                    Textcontainer.Sluttxt();

                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mission 1 Complete! You have proven yourself to be a gagster!");
                    Console.WriteLine("You won the game");


                }


            }

        }

    }
}
