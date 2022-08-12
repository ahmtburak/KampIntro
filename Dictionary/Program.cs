using System;
using System.Collections.Generic;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> sozluk1 = new Dictionary<int,string>();
            //sozluk1.Add(1, "Ahmet");
            //int degersayisi = sozluk1.Count;
            //Console.WriteLine(degersayisi);

            MyDictionary<int,string> sozluk2 = new MyDictionary<int,string>();
            sozluk2.Add(2, "Betül");
            int degetsayisi2 = sozluk2.Count;
            Console.WriteLine(degetsayisi2);
        }
    }
}
