using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_002
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }
        public void Pause()
        {
            Console.WriteLine("Pause");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
