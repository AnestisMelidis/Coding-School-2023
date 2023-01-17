using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class UppercaseTheLongestString {

        public void UpperCaseLongest() {

            Console.WriteLine("Enter a string with multiple words if you like");
            string input = Console.ReadLine();

            if (input.Contains(" ")) {
                string[] words = input.Split(' ');
                string longestWord = "";
                int maxLength = 0;

                foreach (string word in words) {
                    if (word.Length > maxLength) {
                        maxLength = word.Length;
                        longestWord = word;
                    }
                }
                Console.WriteLine("Longest word: " + longestWord.ToUpper());
                
            }
            else {
                Console.WriteLine("The input does not contain multiple words so :" + input.ToUpper());
                
            }
        }
    }
}
