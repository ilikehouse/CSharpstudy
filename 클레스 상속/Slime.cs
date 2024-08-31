using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//클래스 상속
//클래스와 클래스 사이에 상속관계를 가져야하는 경우가 언제인가요?
// Unit -> 공격,스탑,홀드,정찰
//저그 - 라바, 오버로드.. 공격기능이 없다.

//상속 - 자식에게 넘겨준다. ((모든)자식에게 념겨주지 않을 수도 있다.)
//모든 유닛이 공격, 스탑, 홀드, 정찰 기능을 갖는다.
//라바, 오버로드 공격을 해야한다

//어떻게 상속을 할지 말지 결정할까요
//IS-A : B(자식)는 A(부모)이다. 상속을 해라
//HAS-A : B가 A를 소유하고 있다. 상속을 사용하지 말라.

//관래 = IAttack
interface IAttack
{
    public void Attack();
}

class Unit()
{

    public void Hold() { }
    public void stop() { }
    public void Patrol() { }
}

class AttackableUnit : Unit, IAttack
{
    public void Attack()
    {
        Console.WriteLine("공격했다");
    }
}

class Zergling : AttackableUnit
{
    public virtual void Attack()
    {
        Console.WriteLine("저글링이 공격했다");
    }
}

class UnassailableUnit : Unit
{

}

class overload : Unit
{
    //공중유닛
    //공중    
}



namespace 클레스_상속
{
    //플레이어가 공격할 대상 
    // Attack(클래스)

    class Monster
    {
        public int HP;
        public int AttackPower;

        // virtual 키워드를 수식받는 함수는 자식에서 같은 이름의 함수를 찾는다.
        public virtual void Attack(Player player)
        {
            //몬스터가 플레이어를 공격
            player.HP = player.HP - AttackPower;


        }

        public virtual void BeAttacked(Player player)
        {
            HP = HP - player.AttackPower;
            Console.WriteLine("플레이어가 몬스터를 공격함");
        }

        /*
         * 형변환 Monster class type Slime, Wolf class type
         * (변수 is 데이터 타입) => True of False
         * 
         * (변수 as 데이터 타입) => 형변환을 하고 null을 변환
         * 
         * 변수?. => 변수가 null이 아닐때만 접근해라
         * 
         * if (monster != null)
         * monster.Divide
         */



        public void SpecialAttack()
        {


            if(this is Slime)
            {
                (this as Slime).Divide();
            }
            
            if (this is Wolf)
            {
                (this as Wolf).Howling();
            }

        }

        public void sound()
        {

        }

        //interface


    }


    //slime은 몬스터를 상속하고 있다
    //상속을 왜 쓰는가?
    //클래스의 같은 내용을 반복적으로 재사용하고 있다.
    //상속이라는 문법으로 공통적인 부분을 하나로 통합한다.

    /*
     * 플레이어가 몬스터 클래스로 모든 몬스터를 공격할수 있게 되었다.
     * 문제점 : slime도 몬스터라고 출력이 되고, Wolf도 몬스터라고 출력이 된다.
     */
    internal class Slime : Monster
    {

        // new 키워드를 사용한 트릭
        //부모의 함수와는 다른 완전 새로운 함수로 표현한다

        //public new void Attack(Player player) 
        //{
        //    Console.WriteLine("새로운 공격(슬라임)");
        //}
        

        //문법적으로 virtual 키워드를 수식받은 함수가 override 키워드를 수식받는 함수로 사용하라   
        public override void Attack(Player player)
        {
            base.Attack(player);
            Console.WriteLine("슬라임의 공격");
        }

        public override void BeAttacked(Player player)
        {
            base.BeAttacked(player);
            Console.WriteLine("플레이어가 몬스터를 공격함");

        }
        
        public void Divide()
        {
            Console.WriteLine("슬라임이 분열했다");
        }

    }   

    class Wolf : Monster
    {
        public override void Attack(Player player)
        {
            Console.WriteLine("늑대가 공격했다");
        }
        public override void BeAttacked(Player player)
        {
            Console.WriteLine("늑대가 공격받음");
        }
        public void Howling()
        {
            Console.WriteLine("늑대가 울부짖음");
        }
    }




}


