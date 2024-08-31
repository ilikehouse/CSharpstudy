using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace 이터널리턴
{
    interface Iattack 
    {
        public void Attack(Player player);
    }
    class animal
    {
        public int HP;
        public int Damage;
        public int movespped;
        public int type; //1.일반 2.변

        public virtual void BeAttacked(Player player)
        {
            HP = HP - player.Damage;
            Console.WriteLine("플레이어가 야생동에게 공격당함");
        }
    }

    class 착한동물 : animal
    {

    }

    class Wildlife : animal, Iattack
    {
       
        public virtual void Attack(Player player)
        {
            player.HP = player.HP - Damage;
            Console.WriteLine("플레이어가 야생동물을 공격함");
        }
    }

    internal class Bear : Wildlife
    {
        public override void Attack(Player player)
        {
            base.Attack(player);
        }
        public override void BeAttacked(Player player)
        {
            base.BeAttacked(player);
        }
    }
    class Wolf : Wildlife
    {
        public override void Attack(Player player)
        {
            base.Attack(player);
        }
        public override void BeAttacked(Player player)
        {
            base.BeAttacked(player);
        }
    }
    class Bat : Wildlife
    {
        public override void Attack(Player player)
        {
            base.Attack(player);
        }
        public override void BeAttacked(Player player)
        {
            base.BeAttacked(player);
        }

    }
    class Chicken : Wildlife
    {
        public override void Attack(Player player)
        {
            base.Attack(player);
        }
        public override void BeAttacked(Player player)
        {
            base.BeAttacked(player);
        }

    }
    class Dog : Wildlife
    {
        public override void Attack(Player player)
        {
            base.Attack(player);
        }
        public override void BeAttacked(Player player)
        {
            base.BeAttacked(player);
        }

    }


}
