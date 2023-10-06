using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child
{
    abstract class Reading
    {
        public abstract void Read();
    }
    class Azbuka : Reading
    {
        public override void Read()
        {
            Console.WriteLine("ABC");
        }
    }
    class Writing : Reading
    {
        public override void Read()
        {
            Console.WriteLine("Пишу");
        }
    }
    class Child
    {
        public void Read(Reading reading)
        {
            reading.Read();
        }
    }

    class Program1
    {
        static void Main1(string[] args)
        {
            Azbuka azbuka = new Azbuka();
            azbuka.Read();
            Writing writing = new Writing();
            writing.Read();
            Console.WriteLine("------------");
            Child child = new Child();
            child.Read(azbuka);
            Console.ReadKey();
        }
    }
}
