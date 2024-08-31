using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클레스_상속
{
    internal class Bear
    {
        public int HP;
        public int AttackPower;

        public void Attack(Player player)
        {
            player.HP = player.HP - AttackPower;
            Console.WriteLine("곰의 공격!");
            Console.WriteLine($"플레이어의 현재 체력 : {player.HP}");
        }

        public void BeAttacked(Player player)
        {

        }
    }
}
