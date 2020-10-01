using System;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcatEdgeLetters concatEdgeLetters = new ConcatEdgeLetters();

            concatEdgeLetters.Move(new string[] { "I", "have", "a", "nice", "surprise" });

            Console.ReadLine();
        }
    }
}
