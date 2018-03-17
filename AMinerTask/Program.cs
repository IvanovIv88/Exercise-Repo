using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> Miner = new Dictionary<string, long>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    foreach (var resources in Miner)
                    {
                        Console.WriteLine($"{resources.Key} -> {resources.Value}");
                    }
                    break;
                }

                else
                {
                    string quantity = Console.ReadLine();
                    if (quantity == "stop")
                    {
                        foreach (var resources in Miner)
                        {
                            Console.WriteLine($"{resources.Key} -> {resources.Value}");
                        }
                        break;
                    }
                    else
                    {
                        if (!Miner.ContainsKey(resource))
                        {
                            Miner[resource] = long.Parse(quantity);
                        }
                        else
                        {
                            Miner[resource] += long.Parse(quantity);
                        }
                    }
                }
            }
        }
    }
}

