using System.Collections.Generic;

namespace ReplaceString
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Replacable.Replace(null, 'a', 'b', 1));          //myIllegalParamException
            //Console.WriteLine(Replacable.Replace("apple", 'a', 'b', -1));      //myNegativeParamException
            //Console.WriteLine(Replacable.Replace("apple", 'p', 'b', 1));       //change the first occurrence
            //Console.WriteLine(Replacable.Replace("appppple", 'p', 'b', 2));    //change the second occurrence

        }

        public class Replacable
        {

            //just to reach the class when calling in the constructor 
            string word = null;

            public Replacable(string word)
            {
                this.word = word;
            }


            //make sure to add 'static' in Replace method to have output in the main method
            public string Replace(string word, char replace, char replaceWith, int occurrence)
            {

                if (word == null)
                {
                    throw new myIllegalParamException();
                }
                else if (occurrence < 0)
                {
                    throw new myNegativeParamException();
                }
                else
                {

                    char[] eachChar = word.ToCharArray();               //convert the word to char to deal with each one alone
                    List<int> indexOfOccurrence = new List<int>();      //storing the index of each matched char  


                    //add all the occurrence to a list to know their index
                    for (int i = 0; i < eachChar.Length; i++)
                    {
                        if (eachChar[i] == replace)
                        {
                            indexOfOccurrence.Add(i);
                        }
                    }


                    for (int i = 0; i < indexOfOccurrence.Count; i++)
                    {   //to count their occurrence
                        if ((i + 1) % occurrence == 0)  
                        {
                            if (eachChar[indexOfOccurrence[i]] == replace)
                            {
                                eachChar[indexOfOccurrence[i]] = replaceWith;
                            }
                        }

                    }
                    return new string(eachChar);
                }
            }
        }
        

    }
}
