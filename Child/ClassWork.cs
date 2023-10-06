using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child
{
    abstract class ClassWork
    {
        public abstract void Work();
    }
    class ReadingTask : ClassWork
    {
        public override void Work()
        {
            Console.WriteLine("Читаю задание.");
        }
    }
    class RewritingTask : ClassWork
    {
        public override void Work()
        {
            Console.WriteLine("Переписываю задание.");
        }
    }
    class ThinkingTask : ClassWork
    {
        public override void Work()
        {
            Console.WriteLine("Думаю над заданием.");
        }
    }
    class SolvingTask : ClassWork
    {
        public override void Work()
        {
            Console.WriteLine("Решаю задание.");
        }
    }
    class Student
    {
        public void Work(ReadingTask readingTask)
        {
            readingTask.Work();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadingTask readingTask = new ReadingTask();
            readingTask.Work();
            RewritingTask rewritingTask = new RewritingTask();
            rewritingTask.Work();
            ThinkingTask thinkingTask = new ThinkingTask();
            thinkingTask.Work();
            SolvingTask solvingTask = new SolvingTask();
            solvingTask.Work();
            Console.WriteLine("------------");
            Student student = new Student();
            student.Work(readingTask);
            Console.ReadKey();
        }
    }
}
