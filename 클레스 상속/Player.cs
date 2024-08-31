using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클레스_상속
{

    internal class Player
    { 

        /*클래스 : 플레이어와 몬스터 전투시스템
        플레이어, 몬스터*/

        /*기능 : 플레이어의 기능을 만든다.
        1. 공격한다.
        2.휴식한다.
        3.도망친다.*/

        public int HP;
        public int AttackPower;

        public void Attack(Monster monster)
        {
            monster.HP = monster.HP - AttackPower;
            Console.WriteLine("플레이어의 공격!");
            Console.WriteLine($"몬스터의 현재 체력 : {monster.HP}");
        }

        public void BeAttacked(Monster monster)
        {
            HP = HP - monster.AttackPower;
        }



    }
}
