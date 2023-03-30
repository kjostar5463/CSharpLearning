namespace Override
{
    class Weapon
    {
        private string name;

        public enum itemType
        {
            Sword,
            Gun,
            Arrow
        }

        public Weapon()
        {
            Console.WriteLine("매개 변수가 없는 생성자 호출");
        }

        public Weapon(string name)
        {
            this.name = name;
            Console.WriteLine("매개 변수가 있는 생성자 호출");
        }

        public void Select(itemType item)
        {
            switch(item)
            {
                case itemType.Sword: 
                    Console.WriteLine("Sword");
                    break;
                case itemType.Gun:
                    Console.WriteLine("Gun");
                    break;
                case itemType.Arrow:
                    Console.WriteLine("Arrow");
                    break;
            }
        }

        // 함수의 오버로딩:overloading
        public void Attack(int damage)
        {
            Console.WriteLine("int Damage :" + damage);
        }
    
        // 함수의 오버로딩은 매개 변수 타입과 갯수에 따라서 함수를 여러 개 생성 가능
        public void Attack(float damage)
        {
            Console.WriteLine("float Damage :" + damage);
        }

        public void Attack(int damage, int x)
        {
            Console.WriteLine("float Damage :" + damage);
        }
    }

    class Monster
    {
        virtual public void Attack()
        {
            Console.WriteLine("Monster 공격");
        }
    }

    class Goblin:Monster
    {
        override public void Attack()           //override, virtual 사용으로 동적 바인딩
        {
            Console.WriteLine("고블린 공격");
        }
    }

internal class Program
    {
        static void Main(string[] args)
        {
            #region Overloading
            Weapon weapon = new Weapon();
            weapon.Attack(100);
            weapon.Attack(50.5f);
            weapon.Attack(20, 10);
            Weapon weapon1 = new Weapon("new");
            #endregion

            #region enum
            weapon.Select(Weapon.itemType.Arrow);
            weapon.Select(Weapon.itemType.Gun);
            weapon.Select(Weapon.itemType.Sword);
            #endregion

            #region Override
            Monster moster = new Monster();
            Monster goblin = new Goblin(); // Upcasting 부모클래스를 변수로 자식클래스를 생성
            moster.Attack();
            goblin.Attack();



            #endregion
        }
    }
}