using Characters;
using Characters.MainChar;
using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP2019_2020_Project
{
    public class EntryPoint
    {
        static void Main()
        {
            Gladiator one = new Gladiator();

            while(!one.IsAlive)
            {
                Console.WriteLine("Hit");
            }


            Console.ReadLine();
        }
    }
}
