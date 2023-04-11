using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs23_collection
{
    class CustomEnumerator
    {
        int[] list = { 1, 3, 5, 7, 9 };

        public IEnumerator GetEnumerator()
        {
            yield return list[0];   // 메서드를 빠져나가지 않고 값만 돌려줌 
            yield return list[1];   // return과 달리 보내주고 멈춰있음
            yield return list[2];
            yield return list[3];
            yield break;
            yield return list[4];
        }

    }

    class MyArrayList : IEnumerator, IEnumerable
    {
        int[] arrray;
        int position = -1;

        public MyArrayList()
        {
            arrray = new int[3];  // 기본 크기 3으로 초기화 
        }

        // 인덱서 프로퍼티 
        public int this[int index]
        {
            get { return arrray[index]; }
            set
            {
                if (index >= arrray.Length)
                {
                    // 개발 도중에 보는 곳 
                    Array.Resize<int>(ref arrray, index + 1);
                    Console.WriteLine("MyArrayList Resize: {0}", arrray.Length);    // 개발 완료 후 주석 처리 하기 
                }

                arrray[index] = value;
            }
        }
        #region  <IEnumerable 인터페이스 구현>
        public IEnumerator GetEnumerator()
        {
            for (var i = 0; i < arrray.Length; i++)
            {
                yield return arrray[i];
            }
        }
        #endregion

        #region   <IEnumerator 인터페이스 구현>
        public object Current
        {
            get
            {
                return arrray[position];
            }
        }

        public bool MoveNext()
        {
            if (position == arrray.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < arrray.Length);
        }

        public void Reset()
        {
            position = -1;
        }
        #endregion
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new CustomEnumerator();

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            var myArrayList = new MyArrayList();
            for (var i = 0; i <= 5; i++)
            {
                // 인덱서 프로퍼티를 만들었기 때문에 
                myArrayList[i] = i;
            }

            foreach (var item in myArrayList)   // IEnumerable 인터페이스를 구현했기 때문에 가능 
            {
                Console.WriteLine(item);
            }
        }
    }
}