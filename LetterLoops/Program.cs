using System;
using System.Text;
//using System.Reflection;

//docs state you can omit the Main method in C#9
namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a word or something...");
            string input = Console.ReadLine();
            //int inputPosition = 0;
            string output = String.Empty;
            //StringBuilder output = new StringBuilder();
            //check out Matthew's repo to see how he built this app

            //string repeat = new string(lowerChar, i);

            for (int i = 0; i < input.Length; i++)
            {
                output += char.ToUpper(input[i]);

                for (int j = 0; j < i; j++)
                {
                    output += $"{input[i]}";
                }
                if (i < input.Length - 1)
                {
                    output += '-';
                }
            }
            Console.WriteLine($"{output}");

            //int position = 0;
            //char current = '\u0000';
            //do
            //{
            //    if (output[position] != current)
            //    {
            //        current = output[position];
            //        output[position] = char.ToUpper(output[position]);
            //        position ++;

            //        if (position >= 1)
            //            output.Insert(position, "-");
            //            position++;
            //        // test case input: abcd outputs: A-B-bC-ccD-ddd
            //    }
            //    else
            //    {
            //        position++;
            //    }
            //} while (position < output.Length);

            //Console.WriteLine(output.ToString());
        }
    }
}
//reference link to stringbuilder docs
//https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-5.0

