using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    static class textRPG
    {
        
    }
}
namespace 메이플스토리
{

    //여러분들이 플레이 했던 게임의 정보를 class로 변환해보기
    class player
    {
        public string name;
        public int HP;
        public int lv;
        public int AttackPower;
        public int MoveSpeed;
        public int AttackSpeed;
        public int skilllv;
        public void show()
        {
            Console.WriteLine($"{name}의 체력 : {HP}");
            Console.WriteLine($"{name}의 레벨 : {lv}");
            Console.WriteLine($"{name}의 공격속도 : {AttackSpeed}");
            Console.WriteLine($"{name}의 공격력 : {AttackPower}");
            Console.WriteLine($"{name}의 이동속도 : {MoveSpeed}");
            Console.WriteLine($"{name}의 스킬레벨 : {skilllv}");

        }

        public void Attack(slime slime)
        {
            Console.Clear();
            slime.HP = slime.HP - AttackPower;

            Console.WriteLine($"플레이어가 {slime.Name}을 공격했습니다");
            Console.WriteLine($"------------------결과--------------------");
            Console.WriteLine($"플레이어의 공격력 : {AttackPower}으로 공격했습니다");
            Console.WriteLine($"슬라임의 현제 체력 : {slime.HP}");


        }
        public void Rest()
        {
            Console.Clear();
            HP = HP + 500;

            Console.WriteLine($"플레이어가 휴식을 했습니다!");
            Console.WriteLine($"------------------결과-------------------");
            Console.WriteLine($"플레이어의 체력을 500만큼 회복했습니다!");
            Console.WriteLine($"플레이어의 현재 체력 : {HP}");
        }

        public void reattack(slime s1)
        {
            Console.Clear();
            HP = HP - 50;
            s1.HP = s1.HP - s1.AttackPower * 2;
            Console.WriteLine("강한 공격을 했습니다");
            Console.WriteLine($"HP를 50을 쓰고 슬라임의 HP가 {s1.AttackPower * 2}만큼 줄어들었습니다");
        }
    }
    class slime
    {
        //슬라임의 체력은 50입니다. 실수형, 정수형

        /*
         * 접근 지정자
         * 1.public : 공공의, 외부에서 전부 사용할수 있게 하라
         * 2.private : class 내부에서만 사용해라, 접근 지정자를 명시하지 않으면 자동으로 private 선언이 된다
         */
        public int HP;
        public int AttackPower;
        public string Name;
        public float MoveSpeed;


        /*
         *  메소드 : 일련의 코드를 하나의 이름안에 묶는것 입니다.
         *  묶인 코드를 이름을 불러주는 것만으로 실행할수 있습니다
         *  메소드를 호출하는 것을 Call method (메소드 호출)
         */

        /*
         * (접근 지정자) + (반환값) + (메소드의 이름) + () + {}
         * public          void         show() {묶인 코드 내용들    }
         * 
         * 접근 지정자 : private, public => public 선언을 해주세요
         * 반환값이 없는 경우 : void
         * 반환값이 있는 경우 : Int(정수형), Float(실수형), String(문자열), Class이름(사용자 정의형) 변환하라...
         * 메소드의 이름 : show+()+; 1.show 2.소괄호 () 3. ; => 3개의 기호가 합쳐져서 show 메소드 안에 있는 코드를 호출한다.
         */

        int ReturnHP()
        {
            //반환값이 있는 경우에는 return + 변수의 이름 + ; => 해당하는 변수 값을 변환한다.
            return HP;
        }

        string ReturnName()
        {
            return Name;
        }

        float ReturnMoveSpeed()
        {
            return MoveSpeed;
        }

        //슬라임이 공격하는 메소드를 만들어 보세요.
        //슬라임이 공격할 대상이 필요합니다.
        public void BeAttacked(int damaged)
        {
            //슬라임의 체력 - 플레이어의 공격력
            HP = HP - damaged;
        }

        public void Attack(player p1)
        {
            // 슬라임이 플레이어를 공격
            p1.HP = p1.HP - AttackPower; // 슬라임에게 공격당한 플레이어의 체력
            Console.WriteLine("슬라임이 공격했습니다");
        }

        public void SpecialAttack(player p1)
        {
            // 특별한 기술명 출력
            Console.WriteLine("슬라임이 강한 공격을 사용했습니다");
            p1.HP = p1.HP - AttackPower * 5;
        }

        public void show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
            Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");

        }
    }

    class 초록달팽이
    {
        public int HP;
        public int AttackPower;
        public string Name;
        public float MoveSpeed;

        public void show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
            Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");
        }
    }
}
