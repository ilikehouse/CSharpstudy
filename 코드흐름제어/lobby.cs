using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using 메이플스토리;


namespace 코드흐름제어
{

    static class lobby
    {
        public static void Restart()
        {
            while (true)
            {
                Console.WriteLine("다시 메뉴로 가려면 1번 게임을 다시 시작하려면 2번 종료하려면 3번을 눌러주세요");
                int userInput = int.Parse(Console.ReadLine());


                if (userInput == 1)
                {
                    showMeun();
                }
                else if (userInput == 2)
                {
                    Gamestart();
                }
                else if (userInput == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력값을 입력했습니다 다시 입력해주세요");
                }
            }
        }
        
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
        public static void Gamestart()
        {            
            메이플스토리.slime slime = new 메이플스토리.slime();
            slime.Name = "슬라임";
            slime.HP = 500;
            slime.AttackPower = 100;
            slime.MoveSpeed = 3.85f;

            메이플스토리.player player = new 메이플스토리.player();
            player.name = "ilikehouse";
            player.HP = 2000;
            player.lv = 20;
            player.AttackPower = 5;
            player.AttackSpeed = 10;
            player.MoveSpeed = 4;
            player.skilllv = 7;

            Console.WriteLine("게임을 시작했습니다");

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
                    Restart();
                    break;
                }

                if (player.HP <= 0)
                {
                    Console.WriteLine("플레이어가 사망했습니다. 게임에서 패배하셨습니다");
                    Restart();
                    break;
                }
            }
        }

        public static void Loadoption()
        {
            while (true)
            {
                Console.WriteLine("옵션창을 불러왔습니다");
                int a = int.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("옵션 창중");
                }
                else if (a == 1)
                {
                    Console.WriteLine("메뉴로 돌아갑니다");
                    showMeun();
                }
            }
        }
        public static void showMeun()
        {
            //콘솔을 깨끗하게 정리해주세요.
            Console.Clear();
            Console.WriteLine("=================게임 메뉴 출력===================");
            Console.WriteLine("1.게임 시작");
            Console.WriteLine("2.옵션");
            Console.WriteLine("3.게임 종료");

            //1.강의를 학습하고, 스스로 이 코드를 직접 만들수 있으면 성공적이다

            while (true)
            {

                Console.Write("입력을 기다리고 있습니다 : ");
                int userInput = int.Parse(Console.ReadLine());

                //1. if조건문 , switch문

                if (userInput == 1)
                {
                    //유니티에서 게임을 시작해주는 클래스와 메소드가 미리 구현이 되있습니다
                    Console.WriteLine("게임 시작!");
                    Gamestart();
                    break;
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("옵션!");
                    Loadoption();
                    break;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("게임 종료!");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요");
                }
            }
        }
            
        }
    }

