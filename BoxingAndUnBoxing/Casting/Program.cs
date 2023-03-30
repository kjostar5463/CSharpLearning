namespace Casting
{
    class Unit
    {
        protected int health = 100;
        protected int attack = 10;
        public void Skill()
        {
            Console.WriteLine("Unit 스킬");
        }
        virtual public int AttackDamage()
        {
            return attack;
        }
        public void Recovery(Unit obj)
        {
            obj.health += 100;
        }
        public void Damage(Unit obj)
        {
            obj.health -= obj.AttackDamage();
        }
    }
    class Marine : Unit
    {
        public Marine()
        {
            health = 50;
            attack = 5;
        }
        override public int AttackDamage()
        {
            Console.WriteLine("Marine attack");
            return attack;
        }
        // 메소드 숨기기 new 사용
        new public void Skill()
        {
            Console.WriteLine("Steam Pack");
        }
    }

    class Ghost : Unit
    {
        public Ghost()
        {
            health = 75;
            attack = 15;
        }
        override public int AttackDamage()
        {
            Console.WriteLine("Ghost attack");
            return attack;
        }
        new public void Skill()
        {
            Console.WriteLine("Lock Down");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Marine marine = new Marine();
            Ghost ghost = new Ghost();
            marine.Skill();
            ghost.Skill();

            Unit unit = new Marine();
            unit.Skill();

            unit.Recovery(marine);
            unit.Recovery(ghost);

            unit.Damage(marine);
            unit.Damage(ghost);
        }
    }
}