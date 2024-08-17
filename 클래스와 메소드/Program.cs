using 메이플스토리;

namespace 클래스와_메소드
{
    internal class Program
    {
        static void PlayerTurn(player player, slime slime)
        {
            Console.WriteLine("1 . 공격한다");
            Console.WriteLine("2 . 휴식한다");
            Console.WriteLine("3 . 강한 공격을 한다");
            Console.WriteLine("유저의 행동을 입력해주세요");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                player.Attack(slime);
            }

            else if (userInput == 2)
            {
                player.Rest();
            }
            else if (userInput == 3)
            {
                player.reattack(slime);
            }
        }

        static void Main(string[] args)
        {
            네임스페이스 ns = new 네임스페이스();
            ns.show();


            /*
             *  클래스 사용하는 방법
             *  (이름 공간.slime) (클래스의 이름 변수) = new 메이플스토리.slime();
             */
            메이플스토리.slime slime = new 메이플스토리.slime();
            slime.Name = "슬라임";
            slime.HP = 500;
            slime.AttackPower = 100;
            slime.MoveSpeed = 3.85f;

            slime.show();

            메이플스토리.초록달팽이 초록달팽이 = new 메이플스토리.초록달팽이();
            초록달팽이.Name = "초록달팽이";
            초록달팽이.HP = 25;
            초록달팽이.AttackPower = 5;
            초록달팽이.MoveSpeed = 3f;


            초록달팽이.show();

            메이플스토리.player player = new 메이플스토리.player();
            player.name = "ilikehouse";
            player.HP = 2000;
            player.lv = 20;
            player.AttackPower = 5;
            player.AttackSpeed = 10;
            player.MoveSpeed = 4;
            player.skilllv = 7;

            //slime.Attack(player);                                                   //Attack() 메소드는 인자로 player 객체를 받는다. player 
            //slime.BeAttacked(player.AttackPower);                                   //BeAttacked() 메소드는 인자로 int 데이터를 받는다
            //slime.show();

            //player.show
            int day;
            day = 0;
            while (true) //무한 반복문
            {
                day = day + 1;
                
                PlayerTurn(player, slime); //함수로 코드를 정리해서, 코드의 쓰임새를 쉽게 정리할 수 있다


                if (day <= 5)
                {
                    slime.Attack(player);
                }
                else if (day >= 6) 
                {
                    slime.SpecialAttack(player);
                }
                
                
                player.show();
                slime.show();


                // EnemyTurn(player, slime);    //적이 플레이어를 대상으로 하는 행동 AI

                if (slime.HP <= 0)
                {
                    Console.WriteLine("슬라임을 처치했습니다. 게임에서 승리하셨습니다");
                    break;
                }

                if (player.HP <= 0)
                {
                    Console.WriteLine("플레이어가 사망했습니다. 게임에서 패배하셨습니다");
                    break;
                }
            }
        }
    }
}

//과제 : 하는 게임 플레이어또는 몬스터 수치 클래스로 만들어 오기