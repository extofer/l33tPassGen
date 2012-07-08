using System;
using System.Text.RegularExpressions;

namespace l33tPassGen
{
    public class l33t
    {

        /*********************************************************
         * l33tPassGen: Generate Strong Passwords by translating frequently used letters to l33t
         * developed by: gabriel villa aka @extofer
         * www.extofer.com
         *
         */

        public string ReplaceWord(string sWord)
        {
            // Morse findings were that the following letters are the more frequent used letters in English words

            string l33TWord = sWord.ToLower();
            int count = 0;
            string[] substrings;

            l33TWord = l33TWord.Replace("e", "3"); // e is the most common used letter

            substrings = Regex.Split(l33TWord, "t");
            if (substrings.GetLength(0) > 1 )
            {
                l33TWord = l33TWord.Replace(substrings[0] + "t", substrings[0] + "+"); 
                count++;
            }

            
            substrings = Regex.Split(l33TWord, "a");
            if (substrings.GetLength(0) > 1)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "a", substrings[0] + "@");
                count++;
            }


            substrings = Regex.Split(l33TWord, "i");
            if (substrings.GetLength(0) > 1)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "i", substrings[0] + "1");
                count++;
            } 

            substrings = Regex.Split(l33TWord, "n");
            if (substrings.GetLength(0) > 1)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "n", substrings[0] + "N");
                count++;
            }

            substrings = Regex.Split(l33TWord, "o");
            if (substrings.GetLength(0) > 1)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "o", substrings[0] + "0");
                count++;
            }


            substrings = Regex.Split(l33TWord, "s");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "s", substrings[0] + "$");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }



            substrings = Regex.Split(l33TWord, "h");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "h", substrings[0] + "H");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }


            substrings = Regex.Split(l33TWord, "r");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "r", substrings[0] + "R");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }


            substrings = Regex.Split(l33TWord, "d");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "d", substrings[0] + "D");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }


            substrings = Regex.Split(l33TWord, "l");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "l", substrings[0] + "|");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }


            substrings = Regex.Split(l33TWord, "u");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "u", substrings[0] + "U");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }

            substrings = Regex.Split(l33TWord, "m");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "m", substrings[0] + "M");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }


            substrings = Regex.Split(l33TWord, "f");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "f", substrings[0] + "ph");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }



            substrings = Regex.Split(l33TWord, "g");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "g", substrings[0] + "6");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }


            substrings = Regex.Split(l33TWord, "p");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "p", substrings[0] + "P");
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }


            substrings = Regex.Split(l33TWord, "b");
            if (substrings.GetLength(0) > 1 && count < 3)
            {
                l33TWord = l33TWord.Replace(substrings[0] + "b", substrings[0] + "8"); 
                count++;
            }
            else
            {
                if (count >= 3)
                {
                    return l33TWord;
                }
            }


          

            return l33TWord;

        }

    }
}
