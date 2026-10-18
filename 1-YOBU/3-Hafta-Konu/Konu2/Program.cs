using System.Collections

using System.Runtime.CompilerServices;

namespace Uygulama2;

internal class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 3, 4, 5 };
        ArrayList arList = new ArrayList();
        arList.Add(5);
        arList.Add(6);
        arList.Add("emir");
        arList.AddRange(dizi);
        arList.Insert(1, "BAKIR");
        foreach (int item in arList)
        {
            Console.WriteLine(item);
        }
    }
}