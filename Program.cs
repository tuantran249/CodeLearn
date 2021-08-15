using System;
using System.Collections.Generic;
using Graph;

namespace CodeLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://codelearn.io/learning/thuat-toan-can-ban/3795
            bool[,] adjacencyMatrix =
            new bool[,] {
                { false, true, false, true },
                { true, false, false, false },
                { false, false, false, false },
                { true, false, false, false }
            };
            GraphTheory.CountConnectedComponents(adjacencyMatrix,4);
        }

        
    }
}
