using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PigLatin Translator Tool!");

            string translateMore = "y";
            
            while (translateMore == "y")
            {
                Console.WriteLine(" Please enter a sentence that you'd like to have translated.");
                string response = "n";
                string userInput = Console.ReadLine();
                string pigLatin = PigLatinCon(userInput);
                Console.WriteLine(pigLatin);
                Console.WriteLine("Would you like to translate another sentence? (y/n) ");
                response = Convert.ToString(response != "n");
            
                translateMore = Console.ReadLine();
            }
        }

        static string PigLatinCon(string userInput)
        {
            string result = "";
                
                 
      
            userInput = userInput.ToLower();

            foreach (string word in userInput.Split())
            {

                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
                {
                    result = result + word + "way ";
                    continue;
                }
                else
                {
                    var count = 0;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] != 'a' && word[i] != 'e' && word[i] != 'i' && word[i] != 'o' && word[i] != 'u')
                        {
                            count++; 
                        }
                        else
                        {
                           result = result + word.Substring(count, word.Length - count) + word.Substring(0, count) + "ay ";
                           break;
                        }
                    }
                }
            }
            return result ;
        }
    }
}
