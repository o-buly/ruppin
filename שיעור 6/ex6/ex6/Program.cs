using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        ///* סעיף 1 !! */
        //static void Main(string[] args)
        //{
        //    string sentence = "nathaniel";
        //    char letter = 'a';
        //    int counter;
        //   counter= Count_letter(sentence, letter);
        //    Console.WriteLine(counter);
        //}

        //static int Count_letter(string sentence, char letter)
        //{
        //    int count=0;
        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        if (sentence[i] == letter)
        //            count++;
        //    }
        //    return count;
        //}


        /* סעיף 2 !!! */
        //static void Main(string[] args)
        //{
        //    bool flag;
        //    string DNA = "AGYRDCKAFRSEVXO";
        //    string DNA_KIND = "VXO";
        //    flag = Find_sub_sequence(DNA, DNA_KIND);
        //    Console.WriteLine(flag);
        //}

        //static bool Find_sub_sequence(string sequence, string sub)   /** שיטה 1 !!!! **/
        //{
        //    return sequence.IndexOf(sub) != -1;
        //}

        //static bool Find_sub_sequence(string sequence, string sub) /**   שיטה 2 !!!!  **/
        //{
        //    for (int i = 0; i <= sequence.Length - sub.Length; i++)
        //    {
        //        if (sequence.Substring(i, sub.Length) == sub)
        //            return true;
        //    }
        //    return false;
        //}

        //static bool Find_sub_sequence(string sequence, string sub) /**   שיטה 3 !!!!  **/
        //{
        //    for (int i = 0; i <= sequence.Length - sub.Length; i++)
        //    {
        //        int j = 0;
        //        for (; j < sub.Length; j++)
        //        {
        //            if (sequence[i + j] != sub[j])
        //                break;
        //        }
        //        if (j == sub.Length)
        //            return true;
        //    }
        //    return false;
        //}



        ///* סעיף 3 !!! */
        //static void Main(string[] args)
        //{
        //    string sentence = "rifo olleh";
        //    sentence = Reverse(sentence);
        //    Console.WriteLine(sentence);
        //}

        //static string Reverse(string word) /** שיטה 1 !!! **/
        //{
        //    string revers_string = new string(word.Reverse().ToArray());
        //    return revers_string;
        //}

        //static string Reverse(string word)  /** שיטה 2 !!! **/
        //{
        //    string rev_sentence = "";
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        rev_sentence += word[i];
        //    }
        //    return rev_sentence;
        //}

        ///* סעיף 4 !!! */
        static void Main(string[] args)
        {
            string name = "rotor";
            bool flag = isPalindrom(name);
            Console.WriteLine(flag);
        }

        static bool isPalindrom(string word)
        {
            string rev_string = new string(word.Reverse().ToArray());
           return word == rev_string ? true : false;
        }
    }

}
