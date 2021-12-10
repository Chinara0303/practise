using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = " The STRING WHERE the WORD THE PRESENT MORE THAN ONCE";

            int thecount = 0;
            for (int i = 0; i < sentence.Split().Length; i++)
            {
                if (sentence.Split()[i] == "The" || sentence.Split()[i] == "the" || sentence.Split()[i]=="THE" || sentence.Split()[i] == "THe" || sentence.Split()[i] == "ThE")
                {
                    thecount++;
                }
            }
            Console.WriteLine(thecount);
        }
    }
}
