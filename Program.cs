using System;
using System.Text;

using System.IO;
namespace HelloWorldGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string text = "";

            if (new FileInfo("times.txt").Length == 0)

            {
                Console.WriteLine("File is empty");


            }
            else {

                StreamReader reader = new StreamReader("times.txt");
                
                while (reader.Peek() != -1)
                {

                    text = reader.ReadLine();

                }
                reader.Close();
                Console.WriteLine("Last date: " + text);
            }
             
            StreamWriter writer = new StreamWriter("times.txt", true);
            writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

            writer.Close();



        }
    }
}
