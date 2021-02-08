using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dersler = new MyDictionary<int, string>();
            dersler.Add(1, "Matematik");
            dersler.Add(2, "Türkçe");
            dersler.Add(3, "Fizik");

        }
    }
}
