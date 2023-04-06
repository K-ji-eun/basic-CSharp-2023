using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cs15_accessmodifier
{
    class WaterHeater   // class에 거는 접근 한정자 internal
    {
        protected int temp; // public을 쓰면 get, setTemp쓸 필요 X

        public void SetTemp(int temp)
        {
            if( temp < -5 || temp > 40) 
            {
                Console.WriteLine("범위 이탈");
                return;
            }
            this.temp = temp;
        }

        public int GetTemp() 
        { 
            return temp; 
        }

        internal void TrunOnHeater()
        {
            Console.WriteLine("보일러 켭니다 : {0}", temp);    
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterHeater boiler = new WaterHeater();
            boiler.SetTemp(30);
            Console.WriteLine(boiler.GetTemp());
            boiler.TrunOnHeater();
        }
    }
}
