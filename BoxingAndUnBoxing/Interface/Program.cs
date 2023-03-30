namespace Interface
{
    interface IMouse
    {
        // 기본 접근 지정자(public)
        void Drag();
        // 인터페이스는 변수를 선언할 수 없음
    }
    interface Keyborad
    {
        void Typing();        
    }

    class Computer : IMouse, Keyborad
    {
        // 자동 구현 프로버티
        public float Signal
        {
            get;
            set;
        } = 16.5f;
        // 선택적 매개변수
        public void Power(string button, bool power = false)
        {
            Console.WriteLine("전원의 상태 :" + power);
        }
        // 명명된 매개변수
        public void Information(string name, int year)
        {
            Console.WriteLine(name + year);
        }
        public void Drag()
        {
            Console.WriteLine("Computer Mouse Drag");
        }
        public void Typing()
        {
            Console.WriteLine("Computer Keyborad Typing");
        }
    }
    class CellPhone : IMouse
    {
        public void Drag()
        {
            Console.WriteLine("CellPhone Touch Drag");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            Computer computer = new Computer();
            CellPhone cellphone = new CellPhone();

            IMouse mouse = computer;

            mouse = cellphone;
            mouse.Drag();

            computer.Typing();

            computer.Drag();
            cellphone.Drag();
            #endregion
            computer.Power("aa");
            computer.Power("bb", true);

            computer.Information("aa", 2020);
            computer.Information(name: "bb", year: 2023);
            Console.WriteLine(computer.Signal);
            computer.Signal = 100.0f;
            Console.WriteLine(computer.Signal);
        }
    }
}