using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class XMLHandler : AbstractHandler
    {
        public override void Save()
        {
            Console.WriteLine("Файл сохранён");
        }
        public override void Open()
        {
            Console.WriteLine("Файл открыт");
        }
        public override void Create()
        {
            Console.WriteLine("Файл создан в формате xml");
        }
        public override void Chenge()
        {
            Console.WriteLine("Файл изменён");
        }
        public override void Close()
        {
            Console.WriteLine("Файл закрыт");
        }
    }
}
