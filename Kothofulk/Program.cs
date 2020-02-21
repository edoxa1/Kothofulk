using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kothofulk
{
    interface ICar
    { 
        int speed { get; set; }
        int Move(int dist);
        
    }

    interface IVolk
    {
        string country { get; set; }
        int eat(int fuel);
    }

    class BMW : ICar, IVolk
    {
        public string country { get; set; }
        public int speed { get; set; }
        public int Move(int dist)
        {
            return dist / speed;
        }

        public string Model { get; set; }
        public void Info()
        {
            Console.WriteLine(Model);
        }

        public int eat(int fuel)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BMW beha = new BMW();
            beha.speed = 114;
            beha.Model = "punk";
            beha.country = "coronavirus";
            Console.WriteLine(beha.Move(8146) + " " + beha.country);

            Console.ReadKey();
        }
    }
}
