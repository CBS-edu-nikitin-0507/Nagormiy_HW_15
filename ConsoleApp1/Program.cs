using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler xml = new XMLHandler();
            AbstractHandler txt = new TXTHandler();
            AbstractHandler doc = new DOCHandler();
            Console.WriteLine("Введите назваине файла");
            string name = Console.ReadLine();
            Console.WriteLine("Введите тип файла");
            string type = Console.ReadLine();
            Console.WriteLine($"{name}.{type}");
            switch (type)
            {
                case "txt":
                    {
                        txt.Create();
                        txt.Open();
                        txt.Chenge();
                        txt.Close();
                        break;
                    }
                case "xml":
                    {
                        xml.Create();
                        xml.Open();
                        xml.Chenge();
                        xml.Close();
                        break;
                    }
                case "doc":
                    {
                        doc.Create();
                        doc.Open();
                        doc.Chenge();
                        doc.Close();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Программа не поддреживает такой тип");
                        break;
                    }
            }

        }
    }

}