using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> text = new List<string>();

            while (true)
            {
                text = Console.ReadLine().Split(' ').ToList();
                if (text[0] == "print")
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", numbers));
                    Console.Write("]");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    if (text[0] == "addMany")
                    {
                        int index = int.Parse(text[1]);
                        if (index >= 0 && index <= numbers.Count)
                        {

                            for (int i = 2; i < text.Count; i++)
                            {
                                int num = int.Parse(text[i]);
                                numbers.Insert(index, num);
                                index++;
                            }
                        }
                    }

                    if (text[0] == "shift")
                    {
                        int index = int.Parse(text[1]);
                        for (int i = 0; i < index; i++)
                        {
                            int firstIndex = numbers[0];
                            numbers.Insert(numbers.Count, firstIndex);
                            numbers.RemoveAt(0);
                        }
                    }
                    if (text[0] == "sumPairs")
                    {
                        int cycles = numbers.Count / 2;
                        for (int i = 0; i < cycles; i++)
                        {
                            numbers[i] += numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                    }
                    if (text[0] == "add")
                    {
                        int index = int.Parse(text[1]);
                        if (index >= 0 && index <= numbers.Count)
                        {
                            numbers.Insert(index, int.Parse(text[2]));
                        }
                    }
                    if (text[0] == "remove")
                    {
                        int index = int.Parse(text[1]);
                        if (index >= 0 && index <= numbers.Count)
                        {
                            numbers.RemoveAt(index);
                        }
                    }
                    if (text[0] == "contains")
                    {
                        int index = int.Parse(text[1]);

                        if (!numbers.Contains(index))
                        {
                            Console.WriteLine("-1");
                        }
                        else
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (index == numbers[i])
                                {
                                    Console.WriteLine(i);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
