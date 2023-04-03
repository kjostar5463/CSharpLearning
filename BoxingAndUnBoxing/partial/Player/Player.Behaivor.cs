using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    // partial 클래스로 선언한 클래스는 접근 지정자가 다 같아야 한다.
    internal partial class Player
    {
        public void MoveMent()
        {
            Console.WriteLine("플레이어 이동");
        }

        public void Attack()
        {
            Console.WriteLine("플레이어 공격");
        }
    }
}
