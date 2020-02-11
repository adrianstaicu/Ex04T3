using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            string value = "Curs de C#";
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
            
                char letter = array[i];
           
                Console.WriteLine(letter);
            }
        }
    }
}