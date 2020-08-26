using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        //TODD 60/100 in judge 
        //sorting the wrong way
        var partyList = new SortedSet<string>();
        bool over = false;
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() != "party")
            {
                partyList.Add(input);
            }
            else if (input.ToLower() == "party")
            {
                while (true)
                {
                    input = Console.ReadLine();
                    partyList.Remove(input);
                    if (input.ToLower() == "end")
                    {
                        over = true;
                        break;
                    }
                }
            }
            if (over)
            {
                Console.WriteLine(partyList.Count);
                Console.WriteLine(string.Join(Environment.NewLine, partyList));
                break;
            }
        }
    }
}

