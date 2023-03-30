using System.Collections;
using System.Net.NetworkInformation;

namespace HashTable
{
    class Car
    {
        private string[] name;
        private float speed;

        public Car(int size)
        {
            name = new string[size];
        }

        // 인덱서 선언
        // 접근 지정자 - 자료형 - this[int index]

        public string this[int index]
        {
            get
            {
                return name[index];
            }

            set
            {
                name[index] = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // List : Generic <T>
            // ArrayList : Object


            #region LinkedList
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(10); // [10]
            linkedList.AddFirst(5);  // [5] [10] 
            linkedList.AddLast(20);  // [5] [10] [20]
            linkedList.AddLast(30);  // [5] [10] [20] [30]

            linkedList.Remove(5); // [10] [20] [30] 

            foreach (var element in linkedList)
            {
                Console.WriteLine(element);
            }
            #endregion

            #region Dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Sword", 10000);
            dictionary.Add("Axe", 5000);
            dictionary.Add("Knife", 3000);

            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }
            if (dictionary.ContainsKey("Bow"))
            {
                Console.WriteLine(dictionary.ContainsKey("Bow"));
            }
            // TryGetValue( ) : 키를 통해 값을 반환하는 함수
            int name;
            //  KEY     VALUE

            if(dictionary.TryGetValue("Sword", out name))
            {
                Console.WriteLine("Sword의 가격 : " + name);
            }
            else
            {
                Console.WriteLine("KEY가 없습니다.");
            }
            #endregion

            #region Indexer 
            // 클래스의 멤버로 클래스의 값을 배열처럼 접근할 수 있도록 설정하는 문법

            Car car = new Car(3);
            car[0] = "BMW";
            Console.WriteLine("자동차의 이름 : " + car[0]);
            car[1] = "Jaguar";
            Console.WriteLine("자동차의 이름 : " + car[1]);
            Console.WriteLine("자동차의 이름 : " + car[0]);
            #endregion
        }
    }
}