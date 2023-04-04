using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs09_nullcondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo myfoo = null;

            //int? bar;
            //if (myfoo != null)
            //{
            //    bar = myfoo.member;
            //}
            //else
            //{
            //    bar = null;
            //}
            // 위의 아홉줄(주석부분)을 모두 축약시킴
            int? bar = myfoo?.member;    //  삼항연산자 보다 줄인 것

        }
    }

    class Foo
    {
        public int? member;
    }
}
