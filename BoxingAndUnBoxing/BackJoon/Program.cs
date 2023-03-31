using System;

namespace BackJoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());
            byte count = 0;
            byte[] check = new byte[26];
            string []word = new string[N];
            
            for(byte i = 0; i < N; i++)
            {
                word[i] = Console.ReadLine();
            }
            
            for (byte i = 0; i < N; i++)
            {
                if (word[i].Length == 1)
                {
                    count++;
                    continue;
                }
                for (byte j = 0; j < 26; j++)
                {
                    check[j] = 0;
                }
                for (int k = 0; k < word[i].Length; k++)
                {
                    int index = word[i][k] - 'a';
                    if (check[index] == 0)
                    {
                        if (k < word[i].Length - 1)
                        {
                            if (word[i][k] != word[i][k + 1])
                                check[index] = 1;
                        }
                        else
                            check[index] = 1;
                    }
                    else
                    {
                        count--;
                        break;
                    }
                }
            
                count++;
            
            }
            
            Console.WriteLine(count);
            
            //for (int i = 0; i < word.Length; i++)
            //{
            //    for (int j = i; j < word.Length; j++)
            //    {
            //        if (j - i > 1)
            //        {
            //            if (word[i] == word[j])
            //            {
            //                Console.WriteLine(false);
            //            }
            //        }
            //        if (word[i] == word[j])
            //        {
            //            i += j - i;
            //        }
            //    }
            //}
            //Console.WriteLine(true);
            
        }
    }
}