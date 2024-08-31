namespace 클레스_상속
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클래스 상속");

            Player player = new Player();
            player.HP = 100;
            player.AttackPower = 10;

            Slime slime = new Slime();
            slime.HP = 50;
            slime.AttackPower = 5;

            Wolf wolf = new Wolf();
            wolf.HP = 70;
            wolf.AttackPower = 10;

            slime.Attack(player);

            wolf.Attack(player);

            slime.BeAttacked(player);

            wolf.BeAttacked(player);

            slime.SpecialAttack(); //슬라임이 분열했다
            wolf.SpecialAttack(); //늑대가 울부짖음

            Parent parent = new Child(2 , 3);
            parent.ShowInfo();



        }
    }
}
