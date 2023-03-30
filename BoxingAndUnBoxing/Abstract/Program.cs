namespace Abstract
{

    // 추상 클래스
    abstract class Item
    {
        protected int price = 1000;


        // 추상 메서드의 접근 지정자는 강제해줘야한다.
        abstract public void Function(); // 하나 이상의 추상 메서드가 들어가야한다.

        abstract public void CoolTime();

        public void Information()
        {

            Console.WriteLine("Item의 가격 : " + price + " $");

        }


    }
    class Potion : Item
    {
        const string type = "포션류";
        public readonly int itemCode = 100;

        public Potion()
        {
            itemCode = 10546;
            Console.WriteLine("item Code : " + itemCode);

        }

        new public void Information()
        {
            base.Information(); // base - 부모 소환
            Console.WriteLine("포션 가격 : " + price + " $");
        }

        public override void Function()
        {
            Console.WriteLine("능력치 증가");
        }

        sealed override public void CoolTime()
        {
            Console.WriteLine("몇 초 대기");
        }
    }

    class HealthPotion : Potion
    {
        override public void Function()
        {
            Console.WriteLine("체력 회복 ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region 추상클래스
            // Item item = new Item(); // 추상 클래스는 인스턴스를 만들 수 없다.
            // Item item = new Potion();
            // item.Function();
            // item.Information();
            #endregion

            #region base 키워드
            Potion potion = new Potion();
            potion.Information();
            #endregion

            // 문자열 보간
            int year = 2023;
            var data = DateTime.Now; // var = C++의 auto와 같다

            Console.WriteLine("{0}년 {1:HH:mm}분", year, data);
        }
    }


}