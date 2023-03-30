using System.Collections;
using System.Collections.Generic;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Collection - Queue
            Queue queue = new Queue();

            // Enqueue : 데이터를 저장하는 멤버 함수

            queue.Enqueue(10);
            queue.Enqueue("GAME");

            //Dequeue : 데이터 pop
            Console.WriteLine(queue.Dequeue() + " " + queue.Count);
            Console.WriteLine(queue.Dequeue() + " " + queue.Count);
            #endregion

            #region Collection Generic - Queue
            Queue<int> genericQueue = new Queue<int>();

            genericQueue.Enqueue(99);
            //genericQueue.Enqueue("GAME");
            genericQueue.Enqueue(100);
            genericQueue.Enqueue(111);

            // peek : 맨 앞의 원소를 출력
            Console.WriteLine(genericQueue.Peek() + " " + genericQueue.Count);

            genericQueue.Clear();
            //genericQueue.Peek();

            #endregion

            #region Collection Generic - Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("Earth");
            stack.Push("Sun");
            stack.Push("Moon");

            Console.WriteLine(stack.Contains("Sun"));

            Console.WriteLine(stack.Pop() + " " + stack.Count);
            Console.WriteLine(stack.Pop() + " " + stack.Count);
            Console.WriteLine(stack.Contains("Sun"));
            Console.WriteLine(stack.Pop() + " " + stack.Count);

            #endregion

            #region Collection Generic - List
            List<float> list = new List<float>();

            list.Add(10.5f);
            list.Add(20.25f);
            list.Add(30.2f);
            list.Add(40.1f);

            list.Remove(20.25f);
            list.RemoveAt(2);

            list.Insert(1, 53.323f);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            #endregion

        }
    }
}