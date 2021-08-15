using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IPlayable game = new Player();
            IRecordable record = new Player();
            bool Startgame = false;
        OneMoreTime:
            if (Startgame == false)
            {
                Console.WriteLine("GameMenu: 1. Start game 2. Pause game 3. Stop game");
            }
            else
            {
                Console.WriteLine("GameMenu: 2. Pause game 3. Stop game");
            }
            if (!byte.TryParse(Console.ReadLine(), out byte counter))
            {
                Console.WriteLine("Error! String value . Try again");
                goto OneMoreTime;
            }
            else
            {
                if (Startgame == false)
                {
                    if (counter <= 0 || counter > 4)
                    {
                        Console.WriteLine("Not corect value. Try again");
                        goto OneMoreTime;
                    }

                }
                else
                {
                    if (counter <= 1 || counter > 4)
                    {
                        Console.WriteLine("Not corect value. Try again");
                        goto OneMoreTime;
                    }
                }
            }
            


                switch (counter)
            {
                case 1:
                    {
                        game.Play();
                        record.Record();
                        Startgame = true;
                        goto OneMoreTime;
                        break;
                    }
                case 2:
                    {
                        game.Pause();
                        record.Pause();
                        goto OneMoreTime;
                        break;
                    }
                case 3:
                    {
                        record.Stop();
                        game.Stop();
                        break;
                    }
            }

        }
    }
}
