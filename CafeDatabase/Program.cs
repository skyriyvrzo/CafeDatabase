using System;
using CSharp.Lang;

namespace CafeDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Start();
            Console.WriteLine("eiei");
        }
    }

    class Test : Thread
    {
        public override void Run()
        {
            Database database = new Database();
            database.Connect_DB();
        }
    }
}
