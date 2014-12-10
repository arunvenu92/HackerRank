using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static int lonelyinteger(int[] a)
    {
        int result = 0;
        Dictionary<int, int> Numbers = new Dictionary<int, int>();
        for (int i = 0; i <= 100; i++)
        {
            Numbers.Add(i, 0);
        }
        foreach (var value in a)
        {
            foreach (var iter in Numbers)
            {
                if (value == iter.Key)
                {
                    Numbers[iter.Key]++;
                    break;
                }
            }
        }

        foreach (var res in Numbers)
        {
            if (res.Value == 1)
            {
                result = res.Key;
            }
        }


       return result;
    }
    static void Main(String[] args)
    {
        int res;
        int _a_size = Convert.ToInt32(Console.ReadLine());
        int[] _a = new int[_a_size];
        int _a_item;
        String move = Console.ReadLine();
        String[] move_split = move.Split(' ');
        for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
        {
            _a_item = Convert.ToInt32(move_split[_a_i]);
            _a[_a_i] = _a_item;
        }

        res = lonelyinteger(_a);
        Console.WriteLine(res);

    }
}
