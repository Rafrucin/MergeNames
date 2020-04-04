using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {

        List<string> output = new List<string>();
        foreach (string name in names1)
        {
            output.Add(name);
        }
        foreach (string name in names2)
        {
            output.Add(name);
        }

        List<string> noDuplicates = new List<string>();
        foreach (string name in output)
        {
            noDuplicates.Add(name);
            int i = 0;
            foreach (var name1 in noDuplicates)
            {

                if (name==name1)
                {
                    i++;
                    if (i == 2)
                    {
                        noDuplicates.Remove(name);                     
                        break;
                    }
                }
            }
        }
        return noDuplicates.ToArray();
    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Emma", "Olivia", "Emma" };
        string[] names2 = new string[] { "Olivia", "Emma", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2)));
        Console.ReadLine();// should print Ava, Emma, Olivia, Sophia
    }
}
