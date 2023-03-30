namespace Constructor
{
    internal class Program
    {
        class Monster
        {
            private int health;          
            private float attack;

            public void DataSetting(int health, float attack)
            {
                this.health = health;
                this.attack = attack;
            }
            
            public Monster(int health, float attack) // 생성자
            {
                this.health = health;
                this.attack = attack;
                Console.WriteLine("Monster 생성 : 체력 {0}, 공격력 {1}", this.health, this.attack);
            }

            public Monster Clone()  //깊은 복사
            {
                Monster temp = new Monster(health, attack);
                return temp;
            }

            public void Information(string name)
            {
                Console.WriteLine("{0} 생성 : 체력 {1}, 공격력 {2}", name, this.health, this.attack);
            }

        }
        static void Main(string[] args)
        {
            #region 얕은복사
            Monster monster1 = new Monster(100, 100.333f); // 생성자가 없을 경우 기본 생성자

            Monster monster2 = monster1;    // 얕은 복사 (메모리 주소를 복사함)

            monster2.Information("monster2");
            monster1.DataSetting(20, 20);
            monster2.Information("monster2");
            monster2.DataSetting(200, 200);
            monster1.Information("monster1");
            #endregion
            #region 깊은복사
            Monster monster3 = monster1.Clone();
            
            monster3.DataSetting(500, 500);
            monster1.Information("monster1");
            monster3.Information("monster3");
            #endregion


        }
    }
}