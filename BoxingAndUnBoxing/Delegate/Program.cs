namespace Delegate
{
    delegate void Delegate();

    class Player
    {
        public void Damage(Enemy enemy)
        {
            Delegate callback = State;
            enemy.Attack(callback);
        }
        public void State()
        {
            Console.WriteLine("공격당함");
        }
    }

    class Enemy
    {
        public void Attack(Delegate callback)
        {
            Console.WriteLine("공격");
            callback();
        }
    }

    internal class Program
    {
        // delegate는 메소드와 보관하는 메소드의 반환형, 매개변수가 일치해야함
        delegate void Function (int x, int y);
        static void Plus(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Minus(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Main(string[] args)
        {

            #region delegate
            //Function function;
            //
            //function = Plus;
            //function(10, 20);
            //Plus(10, 20);
            //Minus(10, 25);

            //function = Minus;
            //function(10, 25);
            #endregion

            #region delegate chain
            // 여러 개 쌓기 가능
            // 먼저 메소드 등록 후 추가
            //Function function;
            //function = Plus;
            //function += Minus;
            //
            //function(10, 35);
            //function -= Minus;
            //function(10, 34);



            #endregion

            #region 
            Player player = new Player();
            Enemy enemy = new Enemy();
            player.Damage(enemy);
            #endregion

        }
    }
}