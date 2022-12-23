using System;
using System.Text;
namespace HelloWorldGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введiть ваше iм'я\n>>>");
            String name = Console.ReadLine();
            Console.WriteLine("Привет " + name);

        }
    }
}
