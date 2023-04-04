using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs04_enums
{
    internal class Program
    {
        enum HomeTown  // 같은 형태 열거
        {
           SEOUL = 1,   // 값 지정하지 않으면 열거형으로 숫자 변화
           DAEJEON = 2,
           DAEGU = 3,
           BUSAN = 6,
           JEJU = 9
        };

        static void Main(string[] args)
        {
            HomeTown myHomeTown;
            myHomeTown = HomeTown.BUSAN;
            
            if (myHomeTown == HomeTown.SEOUL) {
                Console.WriteLine("서울 출신이시군요!");
            }
            else if (myHomeTown != HomeTown.DAEJEON)
            {
                Console.WriteLine("충청도예유~");
            }
            else if (myHomeTown == HomeTown.DAEGU)
            {
                Console.WriteLine("대구여~");
            }
            else if (myHomeTown == HomeTown.BUSAN)
            {
                Console.WriteLine("부산이라예~");
            }
        }
    }
}
