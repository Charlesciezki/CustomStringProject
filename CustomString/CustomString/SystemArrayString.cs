using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    //Underlying structure: System.array
    //Each index of the underlying array holds one character
    class SystemArrayString : ICustomString
    {
        public char[] charArray = new char [] {'r', 'a', 'p', 't', 'u', 'r', 'e' };
        public void Insert(string stringToInsert, int index)
        {
            char[] newArray = new char[charArray.Length + stringToInsert.Count()];
            int j = 0;
            int k = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if ( i >= index && i < (stringToInsert.Count() + index))
                {
                    newArray[i] += stringToInsert[j];
                    j++;
                } else
                {
                    newArray[i] = charArray[k];
                    k++;
                }

            }
                foreach (char letter in newArray)
                {
                    Console.Write(letter);
                }
            Console.ReadLine();
        }

        public int Length()
        {
            int count = 0;
            foreach (char letter in charArray)
            {
                count++; 
            }
            Console.WriteLine(count);
            return count;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            char[] newArray = new char[charArray.Length - numCharsToRemove];
            int j = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i >= startIndex && i < (startIndex + numCharsToRemove))
                {
                }
                else
                {
                    newArray[j] += charArray[i];
                    j++;
                }
            }
            foreach (char letter in newArray)
            {
                Console.Write(letter);
            }
            Console.ReadLine();
        }
    }
}
