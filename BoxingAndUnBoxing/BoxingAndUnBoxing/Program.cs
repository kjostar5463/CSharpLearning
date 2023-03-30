namespace BoxingAndUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 박싱(Boxing)
            /*
            // 값 형식을 참조 형식으로 변환해주는 과정입니다.
            int data = 100;

            // Boxing 과정은 암묵적 형 변환이 발생합니다.
            object obj = data;

            // MSDN
            // 값 형식 -> 참조 형식
            // Boxing 과정은 참조에 할당하는 것보다 20배 까지
            // 시간이 소요됩니다.

            // UnBoxing은 메모리 할당에 4배 정도 소요됩니다.

            // 참조 형식 -> 값 형식
            Console.WriteLine(obj);
            /
            #endregion

            #region 언박싱(UnBoxing)
            // 박싱되어 있는 참조 형식을 값 형식으로 변환해주는 과정입니다.

            // float > int

            // float result = (int)obj;

            // UnBoxing 과정은 명시적 형 변환이 발생합니다.
            // Console.WriteLine(result);
            #endregion

            // ArrayList
            /
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);      // 값 타입
            arrayList.Add(3.56);     // 값 타입
            arrayList.Add('T');      // 값 타입 
            arrayList.Add("string"); // 참조 타입
            arrayList.Add("string"); // 참조 타입
            arrayList.Add("string"); // 참조 타입
            arrayList.Add("string"); // 참조 타입

            Console.WriteLine(arrayList.Capacity);

            for(int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            /

            // string
            /
            string name = "Kim";

            Console.WriteLine(name);

            name = "James";

            Console.WriteLine(name);
            */

            // 입력
            string input = Console.ReadLine();

            int index = int.Parse(Console.ReadLine());

            // [0][1][2][3][4]
            //  C  o  u  n  t 
            //           4

            Console.WriteLine(input[index - 1]);
            #endregion
            
        }
    }
}