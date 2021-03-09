using System;
using System.Collections.Generic;
using HwQuickFS;
using Microsoft.FSharp.Collections;

namespace QuickCS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Mas = new List<int>() { 10, 5, 17, 8, 9, -5, 41 };

            FSharpList<int> FsList = ListModule.OfSeq(Mas);
            FSharpList<int> fs = ListModule.OfSeq(Mas);
            fs = Say.QuickSort(FsList);

            foreach(var item in fs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
