﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace number_1_app
{
    public class Boiler
    {

        public string Brand;
        public int Voltage;
        public int Temperature;
        public void PrintAll()
        {
            Console.WriteLine($"Brand : {Brand} Voltage : {Voltage} Temperature : {Temperature}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler
            {
                Brand = "귀뚜라미",
                Voltage = 220,
                Temperature = 45
            };

            kitturami.PrintAll();
        }
    }
}



