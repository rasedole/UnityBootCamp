using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230712_01
{
    internal class Program
    {
        //static int[,] map = {
        //    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        //    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        //    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
        //    };

        //static int playerX = 1;
        //static int playerY = 1;

        //static ConsoleKeyInfo Input()
        //{
        //    return Console.ReadKey(true);
        //}

        //static void Process(ConsoleKey Key)
        //{
        //    switch (Key)
        //    {
        //        case ConsoleKey.LeftArrow:
        //            if (playerX > 1)
        //            {
        //                playerX--;
        //            }
        //            break;
        //        case ConsoleKey.RightArrow:
        //            if (playerX < 8)
        //            {
        //                playerX++;
        //            }
        //            break;
        //        case ConsoleKey.UpArrow:
        //            if (playerY > 1)
        //            {
        //                playerY--;
        //            }
        //            break;
        //        case ConsoleKey.DownArrow:
        //            if (playerY < 8)
        //            {
        //                playerY++;
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //static void Render()
        //{
        //    Console.Clear();

        //    for (int y = 0; y < 10; y++)
        //    {
        //        for (int x = 0; x < 10; x++)
        //        {
        //            if ((x == playerX) && (y == playerY))
        //            {
        //                Console.Write("P" + " ");
        //            }
        //            else if (map[y, x] == 1)
        //            {
        //                Console.Write("*" + " ");
        //            }
        //            else if (map[y, x] == 0)
        //            {
        //                Console.Write(" " + " ");
        //            }
        //            else
        //            {
        //                Console.Write(map[y, x] + " ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
        ///
        static int Add(int number1, int number2)
        {
            return (number1 + number2);
        }
        static int Subtract(int number1, int number2)
        {
            return (number1 - number2);
        }

        static int Multiply(int number1, int number2)
        {
            return (number1 * number2);
        }

        static int Divide(int number1, int number2)
        {
            return (number1 / number2);
        }

        static int Modulate(int number1, int number2)
        {
            return (number1 % number2);
        }


        static void Render(int number1, int number2)
        {
            Console.WriteLine(Add(number1, number2));
            Console.WriteLine(Subtract(number1, number2));
            Console.WriteLine(Multiply(number1, number2));
            Console.WriteLine(Divide(number1, number2));
            Console.WriteLine(Modulate(number1, number2));
        }
        
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            string getFirstNumber = "";
            string getSecondNumber = "";

            while (true)
            {
                Console.Write("첫 번째 정수를 입력해주세요: ");
                getFirstNumber = Console.ReadLine();
                Console.Write("두 번째 정수를 입력해주세요: ");
                getSecondNumber = Console.ReadLine();

                bool check1 = int.TryParse(getFirstNumber, out firstNumber);
                bool check2 = int.TryParse(getSecondNumber, out secondNumber);

                if ((check1 && check2))
                {
                    Render(firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }


            //*****
            //int starNum = 0;
            //string getNum = "";

            //Console.WriteLine("0보다 큰 정수를 입력해주세요");
            //getNum = Console.ReadLine();

            //bool check = int.TryParse(getNum, out starNum);

            //int[,] data = new int[starNum, starNum];

            //if (check && (starNum > 0))
            //{
            //    for (int i = 1; i <= starNum; i++)
            //    {
            //        for(int j = 1; j <= starNum; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 입력입니다.");
            //}


            //while (true)
            //{
            //    ConsoleKeyInfo info = Input();

            //    Process(info.Key);

            //    Render();
            //}





            //int[] myPos = new int[2];
            //int[] enemyPos = new int[2];

            //int distance = 0;

            //while (true)
            //{
            //    string inputMyXPos = Console.ReadLine();
            //    string inputMyYPos = Console.ReadLine();
            //    string inputEnemyXPos = Console.ReadLine();
            //    string inputEnemyYPos = Console.ReadLine();

            //    if((inputMyXPos == ".") || (inputMyYPos == ".") || (inputEnemyXPos == ".") || (inputEnemyYPos == "."))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        bool check1 = int.TryParse(inputMyXPos, out myPos[0]);
            //        bool check2 = int.TryParse(inputMyYPos, out myPos[1]);
            //        bool check3 = int.TryParse(inputEnemyXPos, out enemyPos[0]);
            //        bool check4 = int.TryParse(inputEnemyYPos, out enemyPos[1]);

            //        if (check1 && check2 && check3 && check4)
            //        {
            //            distance = ((myPos[0] - enemyPos[0]) * (myPos[0] - enemyPos[0]) + (myPos[1] - enemyPos[1]) * (myPos[1] - enemyPos[1]));
            //            if (distance < (15 * 15))
            //            {
            //                Console.WriteLine("사정거리 안에 있습니다");
            //            }
            //            else
            //            {
            //                Console.WriteLine("사정거리 밖에 있습니다");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("잘못된 입력입니다.");
            //        }
            //    }
            //}


        }
    }
}
