using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_5_app
{
    public interface IAnimal
    {
        int Age { get; set; }
        String Name { get; set; }
        void Sound();
    }

    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public void Sound()
        {

            Console.WriteLine($"{this.Name}가 짖습니다 멍멍 !!!");
        }

        public class Cat : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public void Sound()
            {
                Console.WriteLine($"{this.Name}가 웁니다 야옹 ~~");
            }
        }

        public class Horse : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public void Sound()
            {
                Console.WriteLine($"{this.Name}이 웁니다 이힝 ~! ");
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Dog dog = new Dog { Name = "강아지", Age = 5 };
                dog.Sound();


                Cat cat = new Cat { Name = "고양이", Age = 7 };
                cat.Sound();


                Horse horse = new Horse { Name = "말", Age = 1 };
                horse.Sound();
            }
        }
    }
}