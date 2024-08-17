/*
 *학습목표 : 이름 공간(name space)에 대한 이해
 *작성일 : 2024 - 8 - 17
 *작성자 : 김준수
 */


/*
 *  이름 : 다른 이름을 가짐으로서 구분할수 있다.
 *  만약에 같은 이름이 중복되면 어떻게 될까?
 *   > 컴파일 에러가 발생한다.(실행이 안됩니다.)
 *   
 *   다른 비교할 기준이 있으면 두 대상을 구분할수 있게 됩니다.
 *   같은 이름을 분류하는 이름 공간
 */

/*
 * 2. 네임 스페이스 선언 방법
 * namespace 이름공간의 이름 {} 범위를 표현해주는 기호
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 부산 
{
    class 밀면
    {
        public int count;
    }
}

namespace 서울
{

    class 밀면
    {
        public int count;
    }

}

//이름 공간 (커피 브랜드 두개 선언을 해보세요)

namespace 이디야 
{ 
    class 커피 
    {
        public string name;
    }
}

namespace 컴포즈 
{
    class 커피 
    {
        public string name;
    }

}


namespace 클래스와_메소드
{
    internal class 네임스페이스
    {
        public void show()
        {
            Console.WriteLine("hello world!");
            //1. 같은 이름이 중복되면 안되는 예시
            int num = 10;
            int num2 = 20;

            부산.밀면 noodle = new 부산.밀면();
            noodle.count = 1;
            Console.WriteLine(noodle.count);
            서울.밀면 noodle2 = new 서울.밀면();
            noodle2.count = 10;
            Console.WriteLine(noodle2.count);


            이디야.커피 manu = new 이디야.커피(); 
            manu.name = "레몬에이드";
            Console.WriteLine(manu.name);
            컴포즈.커피 manu2 = new 컴포즈.커피();
            manu2.name = "아메리카노";
            Console.WriteLine(manu2.name);
        }
    }
}
