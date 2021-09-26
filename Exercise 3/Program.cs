using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
namespace ListAllFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ListAllFileInYourMyDocuments(@"C:\Users\MyPC\Documents");
            Console.WriteLine("Press Enter to continute...");
            Console.ReadLine();
        }
        static void ListAllFileInYourMyDocuments(string WorkingMyDocuments)
        {
            string[] Filess = Directory.GetFiles(WorkingMyDocuments);

            foreach (string Files in Filess)
            {
                Console.WriteLine(Files);
            }
        }
        /*static void Main(string[] args)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"E:\Documents\text.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Input 1 content:  ");
            string str = Console.ReadLine();

            sw.WriteLine(str);

            sw.Flush();
            sw.Close();
            fs.Close();
            Console.WriteLine();

        }*/
    }
}