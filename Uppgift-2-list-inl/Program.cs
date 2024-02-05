using System;

namespace Uppgift_1_Listor_inl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> talen = new List<int>();

            while (true)
            {
                string tal = Console.ReadLine();

                if (String.IsNullOrEmpty(tal))
                {
                    break;
                }
                talen.Add(int.Parse(tal));
            }

            int störst = Max(talen);
            Console.WriteLine(störst);
        }
        static int Max(List<int> talen2)
        {
            talen2.Sort();
            return talen2[talen2.Count - 1];
            

        }
    }
}