namespace Anonymous
{
    class Vector<T>
    {
        private T[] element = new T[10];

        public Vector()
        {
            for(int i = 0; i < element.Length; i++)
            {
                Console.WriteLine(element[i]);
            }
        }

        public T Index(int index)
        {
            return element[index];
        }
    }
    internal class Program
    {
        delegate int Calculator(int x, int y);

        // <T> 형식 - 컴파일러는 메서드의 나머지 부분에 대해서도 T를 형식 매개 변수 값으로 치환
        static void Resolution<T>(T x, T y) // Object를 사용하게되면 Boxing/UnBoxing 문제 발생
        {
            Console.WriteLine("x : " + x + "\ny : " + y);
        }
        static void Main(string[] args)
        {
            #region Anonymous
            // 무명 형식 - 선언과 동시에 인스턴스 생성, 값 변경 불가
            var instance = new { name = "James", age = 19 };

            Console.WriteLine(instance.name);
            Console.WriteLine(instance.age);
            #endregion

            #region 무명 메소드
            Calculator calculator;

            calculator = delegate (int x, int y)
            {
                return x + y;
            };
            // 무명 메소드도 delegate와 자료형이 일치해야함
            calculator = delegate (int x, int y)
            {
                return x - y;
            };
            Console.WriteLine(calculator(1, 2));

            // 람다식
            calculator = (x, y) => x * y;
            Console.WriteLine(calculator(1, 2));
            #endregion

            // 일반화 프로그래밍 - 제네릭
            // 데이터 형식 사용 X 특수한 형식을 사용하는 코드의 데이터 형식 일반화
            // 모든 형식 지원
            Resolution<int>(10, 20);
            // 자동으로 맞춰짐
            Resolution(10.2f, 20.5f);

            Vector<int> vector = new Vector<int>();
            Console.WriteLine(vector.Index(0));


        }
    }
}