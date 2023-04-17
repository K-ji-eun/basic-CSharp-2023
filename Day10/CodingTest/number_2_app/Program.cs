using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_app
{
    internal class Boiler
    {
        public string Brand
        {
            get; set;
        }
        private byte voltage;

        public byte Voltage
        {
            get { return this.voltage; }
            set
            {
                
                if (value == 110 || value == 220)
                {
                    voltage = value;
                }
                else
                {
                    Console.WriteLine("110 또는 220으로 하세요");
                }
            }
        }
        private int temperature;
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
               
                if (value <= 5)
                {
                    this.temperature = 5;
                }
                else if (value >= 70)
                {
                    temperature = 70;
                }
                else
                {
                    this.temperature = value;
                }
            }
        }
        public void PrintAll()
        {
            Console.WriteLine($"Brand : {Brand} Voltage : {Voltage}  Temperature : {Temperature}");
        }
        static void Main(string[] args)
        {
            Boiler Kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 480 };
            Kitturami.PrintAll();


        }
    }
}