namespace StringBuilder
{
    struct DataTable
    {
        public int memory;
        public int[] array;
    }

    class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
    }

    class B
    {
        public B(string name)
        {
            Console.WriteLine(name);
        }
    }

    class Language<T> where T : new()
    {
        // where T : struct
        // null 허용 X

        // where T : class
        // 참조 형식

        // where T : new()
        // 매개 변수가 없는 public

        // where T : unmanaged
        // struct를 포함하지 않음
        // T는 null이 아닌 비관리형 형식
        // char, byte, bool, int , float, double, decimal

        // where T : <base class name>
        // 지정된 기본 클래스 이거나 이 클래스에서 파생된 클래스

        private T data; 

        public  T Data
        {
            get { return data; }
            set { data = value; }
        }
    }

    internal class Program
    { 
        static void Close()
        {
            Console.WriteLine("Function");
        }
        static void Open(int power)
        {
            Console.WriteLine("문을 여는 힘 : " + power);
        }

        static int score()
        {

            return 100;
        }
        static int Result(int value)
        {
            return value;
        }

        static void Main(string[] args)
        {
            #region Action
            Action action = Close;
            Action<int> intAction = Open;

            action();

            action = () => { Console.WriteLine("로그인 성공"); };
            action();

            intAction(100);

            intAction = (x) => { Console.WriteLine("로그인 시도 횟수 : " + x); };
            intAction(3);
            #endregion

            #region Func
            Func<int> func;
            // Func는 <반환형, 매개변수, ........>
            Func<int, int> intFunc;

            func = score;

            Console.WriteLine("Score " +  func());

            func = () => { return 999; };
            Console.WriteLine("Score " + func());

            intFunc = Result;

            Console.WriteLine("Result " + intFunc(1000));

            intFunc = (x) => { return x; };
            Console.WriteLine("Result " + intFunc(222));
            #endregion

            #region 제약 조건 (where)
            Language<int> language = new Language<int>();
            language.Data = 100;

            Console.WriteLine(language.Data);

            //Language<string> language1 = new Language<string>();
            //Language<B> language2 = new Language<B>();

            #endregion

        }
    }
}