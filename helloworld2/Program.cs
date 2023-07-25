using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace helloworld2
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
            int sum = 0;

            for (int i = 1; i <= 10; i = i + 1)
            {
                sum = sum + i;
            }

            Console.WriteLine(sum);
        }
    }
}
