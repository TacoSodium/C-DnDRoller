using System;
using System.Collections.Generic;

namespace DnDRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Alex", "Coryn");

            menu.Start();
        }
    }
}
