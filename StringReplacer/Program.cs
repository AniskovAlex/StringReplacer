using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine().ToLower();
            string newLine = line;
            HashSet<char> removed = new HashSet<char>();
            foreach (char x in line)
            {
                if (removed.Contains(x)) continue;
                bool flag = true;
                try
                {
                    line.Single(j => j == x);
                }
                catch (Exception NotOne)
                {
                    flag = false;
                }
                string bufLine;
                if (flag)
                    bufLine = line.Replace(x, '(');
                else
                    bufLine = line.Replace(x, ')');
                for (int i = 0; i < newLine.Length; i++)
                    if (newLine[i] != bufLine[i] && bufLine[i] != line[i])
                    {
                        newLine = newLine.Remove(i, 1);
                        newLine = newLine.Insert(i, bufLine[i].ToString());
                    }
                removed.Add(x);
            }
            Console.WriteLine(newLine);
            Console.ReadKey();
        }
    }
}
