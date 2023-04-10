namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tryCatch
            int[] array = new int[3] { 1, 2, 3 };

            int data = 0;
            int value = 100;
            int result = 0;

            try // 에러가 날 만한 코드
            { 
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            catch (IndexOutOfRangeException error) // 에러 발생 시 실행하는 코드
            {
                Console.WriteLine(error.Message);
            }

            // result = value / 0;
            #endregion

            #region IEnumerator
            // Current 읽지 전용 프로퍼티로 현재 위치의 데이터를 object 타입으로 변환하는 함수
            // MoveNext 다음 위치로 이동하는데 데이터가 있으면 true를 아니면 false를 반환하는 함수
            // Reset 인덱스를 초기 상태로 돌려버리는 함수
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            foreach(var element in linkedList)
            {
                Console.WriteLine(element);
            }

            IEnumerator<int> iEnumerator = linkedList.GetEnumerator();

            Console.WriteLine(iEnumerator.Current);
            iEnumerator.MoveNext();
            Console.WriteLine(iEnumerator.Current);
            iEnumerator.MoveNext();
            Console.WriteLine(iEnumerator.Current);
            iEnumerator.MoveNext();
            Console.WriteLine(iEnumerator.Current);
            iEnumerator.MoveNext();
            Console.WriteLine(iEnumerator.Current);
            iEnumerator.MoveNext();

            #endregion
        }
    }
}