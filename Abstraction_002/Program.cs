using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Record(1) or Play(2)?");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                IRecodable recodable = player;
                recodable.Record();
            }
            else if (choice == 2)
            {
                IPlayable playable = player;
                playable.Play();
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            player.Pause();
            player.Stop();
            Console.ReadKey();
        }
    }
}
