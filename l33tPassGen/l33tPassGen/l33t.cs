using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;

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

            string l33tWord = sWord.ToLower();

            // Morse finding were that the following letters are the more frequent used letters in English words
            
            l33tWord = l33tWord.Replace("e", "3"); // e is the most common used letter
            l33tWord = l33tWord.Replace("t", "+");
            l33tWord = l33tWord.Replace("a", "@");
            l33tWord = l33tWord.Replace("i", "1");
            l33tWord = l33tWord.Replace("n", "N");
            l33tWord = l33tWord.Replace("o", "0");
            l33tWord = l33tWord.Replace("s", "$");
            l33tWord = l33tWord.Replace("h", "H");
            l33tWord = l33tWord.Replace("r", "R");
            l33tWord = l33tWord.Replace("d", "D");
            l33tWord = l33tWord.Replace("l", "|");
            l33tWord = l33tWord.Replace("u", "U");
            l33tWord = l33tWord.Replace("m", "M");
            l33tWord = l33tWord.Replace("f", "pH");
            l33tWord = l33tWord.Replace("g", "6");
            l33tWord = l33tWord.Replace("p", "P");
            l33tWord = l33tWord.Replace("b", "8");  
            
            return l33tWord;

        }

    }
}
