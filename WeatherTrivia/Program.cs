using System;

namespace WeatherTrivia
{
    class Program
    {
        static void Main(string[] args)
        { 

            int correctanswer = 0;
            int correctanswer1sttry = 0;

            //Greeting
            Console.WriteLine("Welcome to the weather trivia game!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Let's get started " + name + "!");
            System.Threading.Thread.Sleep(1500);

            int loopcounter = 0;
            bool wascorrect = false;
            do {
                //Question 1
                Console.WriteLine("\nWhat is the \"standard\" barometric pressure at sea level in inches mercury?");
                Console.WriteLine("\na:\t49.94");
                Console.WriteLine("b:\t19.91");
                Console.WriteLine("c:\t39.93");
                Console.WriteLine("d:\t29.92");//correct answer

                string answer1 = "d";
                string playerInput1;

                playerInput1 = Console.ReadLine();
                if (playerInput1 == answer1)
                {
                    Console.WriteLine("\nThat is correct!");
                    correctanswer++;
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
            } while (!wascorrect);


            System.Threading.Thread.Sleep(1500);

            //Question 2
            Console.WriteLine("\nWhat is the force that deflects air to the right in the northern hemisphere?");
            Console.WriteLine("\na:\tGradient Force");
            Console.WriteLine("b:\tCoriolis Force");//correct answer
            Console.WriteLine("c:\tNorthern Force");
            Console.WriteLine("d:\tSouthern Force");

            string answer2 = "b";
            string playerInput2;

            playerInput2 = Console.ReadLine();
            if (playerInput2 == answer2)
            {
                Console.WriteLine("\nThat is correct!");
                correctanswer++;

            }
            else
            {
                Console.WriteLine("\nThat is incorrect, the right answer is {0}", answer2);
            }

            System.Threading.Thread.Sleep(1500);

            //Question 3
            Console.WriteLine("\nIn what layer of the atmosphere would you find the Jet Stream?");
            Console.WriteLine("\na:\tTroposphere");
            Console.WriteLine("b:\tMesosphere");
            Console.WriteLine("c:\tExosphere");
            Console.WriteLine("d:\tTropopause");//correct answer

            string answer3 = "d";
            string playerInput3;

            playerInput3 = Console.ReadLine();
            if(playerInput3 == answer3)
            {
                Console.WriteLine("\nThat is Correct!");
                correctanswer++;
            }
            else
            {
                Console.WriteLine("\nThat is incorrect, the right answer is {0}", answer3);
            }

            System.Threading.Thread.Sleep(1500);

            //question 4
            Console.WriteLine("\nAn Elongated area of high pressure is called a/an");
            Console.WriteLine("\na:\tRidge");//correct answer
            Console.WriteLine("b:\tTrough");
            Console.WriteLine("c:\tFront");
            Console.WriteLine("d:\tAir mass");

            string answer4 = "a";
            string playerInput4;

            playerInput4 = Console.ReadLine();
            if(playerInput4 == answer4)
            {
                Console.WriteLine("\nThat is Correct!");
                correctanswer++;
            }
            else
            {
                Console.WriteLine("\nThat is incorrect, the right answer is {0}", answer4);
            }

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\nThanks for playing " + name + ", you got {0} percent correct.", correctanswer * (25));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}