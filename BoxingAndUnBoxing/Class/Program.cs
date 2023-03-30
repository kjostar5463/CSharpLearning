namespace Class
{
    internal class Program
    {
        class Dog
        {
            //접근 지정자
            //public, protected, private
            //internal 같은 어셈블리에서만 public으로 접근이 가능

            private int age;
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value > 19)
                    {
                        value = 18;
                    }
                    age = value;
                }
            }

            protected char grade;

            private float health;

            public void Sound()
            {
                Console.WriteLine("멍 멍 !");
            }

        }

        class Maltese : Dog
        {
            public void Information()
            {
                grade = 'A';
                Console.WriteLine("등급 : " + grade + "  나이 : " + Age);
            }
        }

        static void Main(string[] args)
        {
            #region 클래스
            //Dog dog = new Dog();
            //dog.Sound();
            //
            //dog.Age = 100;
            //
            //Console.WriteLine("dog.age의 값 : " + dog.Age);
            //Maltese mal = new Maltese();
            //mal.Age = 60;
            //mal.Information();
            #endregion
        }
    }
}