using System;
using System.Collections.Generic;

namespace DelimitersMatch // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args){
                if(DelimitersMatch(arg))
                    Console.WriteLine(arg + " - Válido");
                else Console.WriteLine(arg + " - Não Válido");
            }
        }
        public static bool DelimitersMatch(string delimiters)
        {
            Dictionary<char,char> dictDelimiters =  generateDictionary();

            Stack<char> nextDelimiter = new Stack<char>();
            char[] tempArray = delimiters.ToCharArray();

            foreach (char delimiter in tempArray){
                if (dictDelimiters.ContainsKey(delimiter))
                    nextDelimiter.Push(dictDelimiters[delimiter]);

                else if (dictDelimiters.ContainsValue(delimiter))
                {
                    if(nextDelimiter.Count == 0)
                        return false;
                    else if (nextDelimiter.Peek() == delimiter)
                        nextDelimiter.Pop();
                    else return false;
                }
                // else throw new InvalidDataException();
            }
            if(nextDelimiter.Count == 0)
                return true;
            else return false;
        }
        public static Dictionary<char,char> generateDictionary()
        {
            Dictionary<char,char> dictionaryDelimiters =  new Dictionary<char, char>();
            dictionaryDelimiters.Add('(',')');
            dictionaryDelimiters.Add('[',']');
            dictionaryDelimiters.Add('{','}');
            
            return dictionaryDelimiters;        
        }
    }
}


