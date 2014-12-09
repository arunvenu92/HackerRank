using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            Boolean value;
            String input = Console.ReadLine();
            input=input.Replace(" ","");
            input=input.Trim();
            input=input.ToLower();
            value = Initialize(input);
            if (value)
            {
                Console.WriteLine("pangram");
            }
            else
            {
                Console.WriteLine("not pangram");
            }
    }
     private static bool Initialize(string input)
        {
            int counter = 0;
            String result ="";
            Dictionary<Char, int> ret_dictionary = new Dictionary<Char, int>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                ret_dictionary.Add(i,counter);
            }
            foreach (var x in input)
            {
                foreach (var iter in ret_dictionary)
                {
                    if (iter.Key.Equals(x))
                    {
                        ret_dictionary[iter.Key] = 1;
                        break;
                    }
                }
            }
            foreach (var value in ret_dictionary)
            {
                result += ret_dictionary[value.Key];
            }
              int result_value = Convert.ToInt32(result, 2);

              if (result_value == 67108863)
              {
                  return true;
              }

              return false;
        }
}
