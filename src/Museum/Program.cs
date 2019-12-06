using System;

namespace Museum
{
    class Program : Menu
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var Museum = new Building();
            var Menu = new Menu();
            Menu.startMenu();

            
        }
    }
}
