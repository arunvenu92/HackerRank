using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_case=0;
            string input;
            List<string> HL = new List<string>();
            List<string> Input = new List<string>();
            HL.Add("C");
            HL.Add("CPP");
            HL.Add("JAVA");
            HL.Add("PYTHON");
            HL.Add("PERL");
            HL.Add("PHP");
            HL.Add("RUBY");
            HL.Add("CSHARP");
            HL.Add("HASKELL");
            HL.Add("CLOJURE");
            HL.Add("BASH");
            HL.Add("SCALA");
            HL.Add("ERLANG");
            HL.Add("CLISP");
            HL.Add("LUA");
            HL.Add("BRAINFUCK");
            HL.Add("JAVASCRIPT");
            HL.Add("GO");
            HL.Add("D");
            HL.Add("OCAML");
            HL.Add("R");
            HL.Add("PASCAL");
            HL.Add("SBCL");
            HL.Add("DART");
            HL.Add("GROOVY");
            HL.Add("OBJECTIVEC");
            test_case = Convert.ToInt32(Console.ReadLine());
            while (test_case > 0)
            {
                input = Console.ReadLine();
                Input.Add(input);
                test_case--;
            }
            foreach (var entity in Input)
            {
                int temp;
                //temp = entity.Length;

                if (HL.Contains(entity.Substring(6).Trim()))
                {
                    Console.WriteLine("VALID");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }
    }
}
