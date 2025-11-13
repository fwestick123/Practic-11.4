using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Andrey = new Player(5, 100);
            Andrey.TakeDamage(30);
            Andrey.TakeDamage(20);
            Andrey.TakeDamage(40);
            Andrey.TakeDamage(10);
        }
    }
}
