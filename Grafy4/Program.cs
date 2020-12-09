using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy4
{
    class Program
    {
        static int compare(string test, int i, int k, int orgI, int result) //k = aktualny sprawdzany znak i = znak poprzedni
        {
            if (i == test.Length) return result;
            if (test[k] == test[i])
            {
                if (k + 1 == orgI) return result+1;
                else return compare(test, i + 1, k + 1, orgI, result+1);

            }
            else return 0;
        }
        static void Main(string[] args)
        {


            int maxLenght = 0;

            
                //string test = "abcdabcdab";
                //string test = File.ReadAllText(".\\" + args[0]); //Pobierz plik
                string test = Console.ReadLine();

                List<char> prefix = new List<char>();

                for (int i = 0; i < test.Length - 1; i++) //miejsce w stringu
                {

                    int k;
                    //k Sprawdza wszystkie możliwe kombinacje
                    //if (i > test.Length / 2) k = i - (test.Length - i);
                    //else k = 0;

                    //k sprawdza tylko 'p' w tył
                    int p = 3000;
                    if (i > p) k = i - p;
                    else k = 0;

                    for(; k<i; k++)
                    {
                   
                        int temp = compare(test, i, k, i, 0);
                        if (temp > maxLenght) maxLenght = temp;
                    }
                }
            
            
           
            /* if (args.Count() == 1 && File.Exists(".\\" + args[0]))
            {
                SuffixTree.Create(File.ReadAllText(".\\" + args[0]));

            }
            else Console.WriteLine("Nie ma takiego pliku!"); */
        }

        

    }
}