using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230711_01_datatype
{
    internal class Program
    {
        //int : 정수 자료형
        //정수 상수 : -111, 111, 0
        //
        //string : 문자열
        //문자열 상수 : "문자열", "1"
        //
        //float : 실수 자료형
        //실수 상수 : 1.1f, 2.3f, 4.12312f
        //
        //bool : true, false
        //
        static void Main(string[] args)
        {
            /*
            int myMoney = 0;
            int yourMoney = 0;

            string message = "";

            myMoney = 100;
            yourMoney = 3;

            message = "Hello World" + " Bye";
            
            Console.WriteLine(message);
            Console.WriteLine(myMoney + yourMoney); //더하기 연산
            Console.WriteLine(myMoney - yourMoney); //빼기 연산
            Console.WriteLine(myMoney * yourMoney); //곱하기 연산
            Console.WriteLine(myMoney / yourMoney); //나누기 연산
            Console.WriteLine(myMoney % yourMoney); //나머지 연산
            
            Console.WriteLine(1+2+3+4+5+6+7+8+9+10);
            */


            //배열, array
            //korean
            //[0][1][2][3][4][5][6][7][8][9] = index
            /*
            int[] korean = new int[10];
            int[] english = new int[10];
            int[] math = new int[10];

            int x = 0;

            for (x = 0; x < 10; x = x + 1)
            {
                korean[x] = 100;
            }

            
            for(초기치; 조건식; 증가치)
            {
                내용
            }
            

            float[] average = new float[10];
            */
            /*
                        int sumOfOdd = 0;
                        int sumOfEven = 0;
                        int sumOfThree = 0;
                        int i = 0;

                        for (i = 1; i <= 100; i = i + 2)
                        {
                            sumOfOdd = sumOfOdd + i;
                        }

                        for (i = 2; i <= 100; i = i + 2)
                        {
                            sumOfEven = sumOfEven + i;
                        }

                        for (i = 3; i <= 100; i = i + 3)
                        {
                            sumOfThree = sumOfThree + i;
                        }

                        Console.WriteLine(sumOfOdd);
                        Console.WriteLine(sumOfEven);
                        Console.WriteLine(sumOfThree);
            *//*
                        if(false)
                        {
                            Console.WriteLine("참");
                        }
                        else
                        {
                            Console.WriteLine("거짓");
                        }*/
            //점수
            //A : 90 ~ 100
            //B : 80 ~ 90
            //C : 70 ~ 80
            //D : 60 ~ 70
            //F : 0 ~ 60

            /*            int score = 100;

                        if (score >= 90)
                        {
                            Console.WriteLine("A");
                        }
                        else
                        {
                            if (score >= 80)
                            {
                                Console.WriteLine("B");
                            }
                            else
                            {
                                if (score >= 70)
                                {
                                    Console.WriteLine("C");
                                }
                                else
                                {
                                    if (score >= 60)
                                    {
                                        Console.WriteLine("D");
                                    }
                                    else
                                    {
                                        Console.WriteLine("F");
                                    }
                                }
                            }
                        }*/

            /*            int score = 100;

                        if (score >= 90)
                        {
                            Console.WriteLine("A");
                        }
                        else if (score >= 80)
                        {
                            Console.WriteLine("B");
                        }
                        else if (score >= 70)
                        {
                            Console.WriteLine("C");
                        }
                        else if (score >= 60)
                        {
                            Console.WriteLine("D");
                        }
                        else
                        {
                            Console.WriteLine("F");
                        }*/

            //int score = 100;
            //int scoreDevide = score / 10;

            //switch (scoreDevide)
            //{
            //    case 10:
            //    case 9:
            //        Console.WriteLine("A");
            //        break;
            //    case 8:
            //        Console.WriteLine("B");
            //        break;
            //    case 7:
            //        Console.WriteLine("C");
            //        break;
            //    case 6:
            //        Console.WriteLine("D");
            //        break;
            //    default:
            //        Console.WriteLine("F");
            //        break;
            //}

            //int score = 100;
            //float average = 0.3f;

            //int sum = score + (int)average;
            //float fsum = (float)score + average;

            //Console.WriteLine(sum);
            //Console.WriteLine(fsum);

            //string numberString = Console.ReadLine();

            //int number = 0;

            //bool result = int.TryParse(numberString, out number);

            //if (result)
            //{
            //    Console.WriteLine(number + 20);
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //Console.WriteLine(number.ToString() + 20.ToString());

            //string userId = "test";
            //string password = "1234";

            //if(userId=="test" && password == "1234")
            //{
            //    Console.WriteLine("맞습니다.");
            //}
            //else
            //{
            //    Console.WriteLine("나가");
            //}

            //int firstNum = 0;
            //int secondNum = 0;
            //string getFirstNumber = "";
            //string getSecondNumber = "";

            //while (true)
            //{
            //    Console.Write("첫 번째 숫자: ");
            //    getFirstNumber = Console.ReadLine();
            //    Console.Write("두 번째 숫자: ");
            //    getSecondNumber = Console.ReadLine();

            //    bool firstNumCheck = int.TryParse(getFirstNumber, out firstNum);
            //    bool secondNumCheck = int.TryParse(getSecondNumber, out secondNum);

            //    if ((secondNum == 0) || (!(firstNumCheck && secondNumCheck)))
            //    {
            //        break;
            //    }

            //    int addNum = firstNum + secondNum;
            //    int subNum = firstNum - secondNum;
            //    int mulNum = firstNum * secondNum;
            //    int divNum = firstNum / secondNum;
            //    int modNum = firstNum % secondNum;

            //    Console.Write("첫 번째 숫자와 두 번째 숫자를 더한 값: ");
            //    Console.WriteLine(addNum);
            //    Console.Write("첫 번째 숫자에서 두 번째 숫자를 뺀 값: ");
            //    Console.WriteLine(subNum);
            //    Console.Write("첫 번째 숫자와 두 번째 숫자를 곱한 값: ");
            //    Console.WriteLine(mulNum);
            //    Console.Write("첫 번째 숫자를 두 번째 숫자로 나눈 몫: ");
            //    Console.WriteLine(divNum);
            //    Console.Write("첫 번째 숫자를 두 번째 숫자로 나눈 나머지: ");
            //    Console.WriteLine(modNum);
            //}

            //int iteration = 0;
            //string inputNum = "";
            //string sortingDirection = "";

            //Console.WriteLine("L, R 중 입력해주세요");
            //sortingDirection = Console.ReadLine();

            //Console.Write("0보다 큰 정수를 입력해주세요: ");
            //inputNum = Console.ReadLine();
            //bool check = int.TryParse(inputNum, out iteration);

            //if ((iteration > 0) && check)
            //{
            //    switch (sortingDirection)
            //    {
            //        case "L":
            //            for (int i = 0; i < iteration; i++)
            //            {
            //                for (int j = 0; j <= i; j++)
            //                {
            //                    Console.Write("*");
            //                }
            //                Console.WriteLine("");
            //            }
            //            break;
            //        case "R":
            //            for (int i = 0; i < iteration; i++)
            //            {
            //                for (int j = 0; j < iteration; j++)
            //                {
            //                    if (j < (iteration - i - 1))
            //                    {
            //                        Console.Write(" ");
            //                    }
            //                    else
            //                    {
            //                        Console.Write("*");
            //                    }
            //                }
            //                Console.WriteLine("");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("잘못된 입력입니다.");
            //            break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 입력입니다.");
            //}

        }
    }
}
