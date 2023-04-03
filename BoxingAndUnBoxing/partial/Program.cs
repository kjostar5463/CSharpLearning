using KGS;
using Microsoft.VisualBasic;
using System.Buffers.Text;






public class Base
{
    int itemNumber;

    public void Construct()
    {
        Console.WriteLine("건물 지었습니다.");
    }

    public class Village
    {
        Base aclass = new Base();
        int bNumber;

        public void Information()
        {
            bNumber = aclass.itemNumber;
        }
    }
}


namespace KGS
{
    class Function
    {
        public Function()
        {
            Console.WriteLine("xxx 시스템 개발");
        }
    }
}

namespace SJH
{
    class Function
    {
        public Function()
        {
            Console.WriteLine("***s 시스템 개발");
        }
    }

}


internal class Program
{
    static void Main(string[] args)
    {
        #region Partial
            //Player player = new Player();
            //player.Talk();
            //player.MoveMent();
            //player.Attack();
            #endregion

        #region nestedClass
        Base aClass = new Base();

        Base.Village nestedClass = new Base.Village();
        nestedClass.Information();
        #endregion

        //nameSpace 이름을 넣어서 구분
        KGS.Function kgs = new KGS.Function();
        SJH.Function shj = new SJH.Function();

    }
}
