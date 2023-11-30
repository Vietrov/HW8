using System;
using System.Text;
using System.Xml.Linq;

namespace Lesson
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

             List<string> tasks = new List<string>();

            tasks.Add("Встать в 8 утра");
            tasks.Add("позавтракать");
            tasks.Add("пойти на работу");

            tasks.Insert(1,"почистить зубы");

            tasks.RemoveAt(3);
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }

            Console.ReadLine();






        }
    }
}