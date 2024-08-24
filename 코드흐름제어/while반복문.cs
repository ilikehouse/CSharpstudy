
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    static class while반복문
    {
        public static void show()
        {
            Console.WriteLine("while반복문");

            int number = 0;

            //while () 조건식이 false가 될때까지 반복한다
            while (number < 10) //조건식  
            {
                Console.WriteLine(number);
                number = number + 1; //number에 1을 더해서 다시 넣어준다

            }


            number = 0;
            //while() 무한 반복문 실행후에 조건문으로 탈출하는 방법
            while (true) 
            { 
                Console.WriteLine(number);
                number = number + 1; //number에 1을 더해서 다시 넣어준다
                if (number == 10)
                {
                    break;
                }
            }

            //while문 언제 사용하는가?
            //얼마 만큼 반복해야하는지 모르겠을 때 while반복문을 쓰면 좋다
            
            //1~10까지의 숫자중 짝수만 출력하는 코드를 작성해라. for반복문, while반복문
            int num2 = 0;
            while (num2 <= 10)
            {
                if(num2 % 2 == 0) //짝수라면...
                {
                    Console.WriteLine("짝수 값 : "+ num2);
                }

                num2 = num2 + 1;
      
            }
            //1.탈출해야하는 조건
            //2.반복해서 실행해야할 코드


            //1부터 100사이의 3의 배수를 출력하는 코드를 작성해보세요.
            Console.WriteLine("반복문 예제 문제");

            int num3 = 0;
            
            //1.while(true) 무한 반복문
            //2.무한 반복문 탈출할 조건을 작성
            //3.탈출할수 있게 코드를 작성
            //4.실행할 코드를 작성
            while (num3 <= 100)
            {

                num3 = num3 + 1;


                if (num3 % 3 == 0)
                {
                    Console.WriteLine("3의 배수 : " + num3);
                }





            }

        }
    }
}
