using System;

namespace lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 4: Scrieti un program care va determina daca un numar este sau nu
                palindrom
             */

            Console.WriteLine("Introduceti numarul:");
            int num = int.Parse(Console.ReadLine());

            int duplicateNum = num;
            int reverseNum = 0;

            
            while (duplicateNum > 0)
            {
                // inversul numarului = invers * 10 + ultima cifra din numar
                reverseNum = (reverseNum * 10) + (duplicateNum % 10);
                //scoatem ultima cifra din numar
                duplicateNum = duplicateNum / 10;
            }

            if (reverseNum != num)
            {
                Console.WriteLine("Numarul " + num + " nu este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul " + num + " este palindrom");
            }
        }
    }
}
