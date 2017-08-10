using System;

namespace WeatherTrivia
{
    class Program
    {
        static void Main(string[] args)
        { 

            //int correctanswer = 0;
            int correctanswer1sttry = 0;

            //Greeting
            Console.WriteLine("Welcome to the weather trivia game!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Let's get started " + name + "!");
            System.Threading.Thread.Sleep(1000);

            int loopcounter = 0;
            bool wascorrect = false;

            do {
                //Question 1
                Console.WriteLine("\nWhat is the \"standard\" barometric pressure at sea level in inches mercury?");
                Console.WriteLine("\n\ta: 49.94");
                Console.WriteLine("\tb: 19.91");
                Console.WriteLine("\tc: 39.93");
                Console.WriteLine("\td: 29.92");//correct answer

                string answer1 = "d";
                string playerInput1;

                playerInput1 = Console.ReadLine();
                if (playerInput1 == answer1)
                {
                    Console.WriteLine("\nThat is correct!");
                    //correctanswer++;
                    wascorrect = true;
                    if (loopcounter == 0)
                    {
                        correctanswer1sttry++;
                    }

                }
                else
                {
                    Console.WriteLine("\nThat is incorrect, please try again");
                }
                loopcounter++;
                System.Threading.Thread.Sleep(1000);
            } while (!wascorrect);


            System.Threading.Thread.Sleep(1000);

            bool wascorrect1 = false;
            int loopcounter1 = 0;

            do
            {
                //Question 2
                Console.WriteLine("\nWhat is the force that deflects air to the right in the northern hemisphere?");
                Console.WriteLine("\n\ta: Gradient Force");
                Console.WriteLine("\tb: Coriolis Force");//correct answer
                Console.WriteLine("\tc: Northern Force");
                Console.WriteLine("\td: Southern Force");

                string answer2 = "b";
                string playerInput2;

                playerInput2 = Console.ReadLine();
                if (playerInput2 == answer2)
                {
                    Console.WriteLine("\nThat is correct!");
                    //correctanswer++;
                    wascorrect1 = true;
                    if (loopcounter1 == 0)
                    {
                        correctanswer1sttry++;
                    }
                }
                else
                {
                    Console.WriteLine("\nThat is incorrect, please try again.");                    
                }
                loopcounter1++;
                System.Threading.Thread.Sleep(1000);
            } while (!wascorrect1);

            System.Threading.Thread.Sleep(1000);

            bool wascorrect2 = false;
            int loopcounter2 = 0;

            //Question 3
            do
            {
                Console.WriteLine("\nIn what layer of the atmosphere would you find the Jet Stream?");
                Console.WriteLine("\n\ta: Troposphere");
                Console.WriteLine("\tb: Mesosphere");
                Console.WriteLine("\tc: Exosphere");
                Console.WriteLine("\td: Tropopause");//correct answer

                string answer3 = "d";
                string playerInput3;

                playerInput3 = Console.ReadLine();
                if (playerInput3 == answer3)
                {
                    Console.WriteLine("\nThat is Correct!");
                    wascorrect2 = true;
                    //correctanswer++;
                    if (loopcounter2 == 0)
                    {
                        correctanswer1sttry++;
                    }
                }
                else
                {
                    Console.WriteLine("\nThat is incorrect, please try again");
                }
                loopcounter2++;
                System.Threading.Thread.Sleep(1000);
            } while (!wascorrect2);

            System.Threading.Thread.Sleep(1000);

            bool wascorrect3 = false;
            int loopcounter3 = 0;

            do
            {

                //question 4
                Console.WriteLine("\nAn Elongated area of high pressure is called a/an");
                Console.WriteLine("\n\ta: Ridge");//correct answer
                Console.WriteLine("\tb: Trough");
                Console.WriteLine("\tc: Front");
                Console.WriteLine("\td: Air mass");

                string answer4 = "a";
                string playerInput4;

                playerInput4 = Console.ReadLine();
                if (playerInput4 == answer4)
                {
                    Console.WriteLine("\nThat is Correct!");
                    wascorrect3 = true;
                    //correctanswer++;
                    if (loopcounter3 == 0)
                    {
                        correctanswer1sttry++;
                    }
                }
                else
                {
                    Console.WriteLine("\nThat is incorrect, please try again");
                }
                loopcounter3++;
                System.Threading.Thread.Sleep(1000);
            } while (!wascorrect3);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nThanks for playing " + name + ", you got {0} correct on the first try.", correctanswer1sttry);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}