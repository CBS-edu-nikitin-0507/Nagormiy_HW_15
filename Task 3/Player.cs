using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Player : IPlayable, IRecordable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Game is started");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Game is paused");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Game is stoped");
            Environment.Exit(0);
        }

        void IRecordable.Record()
        {
            Console.WriteLine("Record is started");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Record is paused");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Record is stoped");
        }
    }
}
