namespace Parameter
{
    internal class Program
    {
        //함수 C/C++
        //메소드 C# / Java
        static void Calculator(ref int x) //포인터 참조자
        {
            x -= 100;
        }
        // in : 참조형 매개변수, 상수화가 이루어진 변수
        static void Function(in int x)
        {
            Console.WriteLine("매개 변수 x의 값 : " + x);
        }
        // out : 참조형 매개변수, 출력용 매개변수
        static void RayCast(out int x)
        {
            // 외부 매개변수 초기화를 안해도 사용 가능
            x = 300;
            // 함수의 반환형
        }

        //가변길이 매개변수
        static void Information(params int[] list)
        {
            int result = 0;
            foreach(int element in list)
            {
                result += element;
                Console.WriteLine(element);
            }
            Console.WriteLine("result 값 : " + result);
        }


        static void Main(string[] args)
        {
            #region 매개변수 한정자
            int data = 1000;
            int data1 = 2000;
            int data2;

            Calculator(ref data);
            Console.WriteLine(data);

            Function(data1);

            RayCast(out data2);
            Console.WriteLine(data2);
            #endregion

            Information(10, 20);
            Information(10, 20, 35, 45);
            
        }
    }
}