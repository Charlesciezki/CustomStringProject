using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    //Underlying structure: System.string
    //Piggyback off System.string's built-in functionality to implement ICustomString's 
    //functions
    class SystemString : ICustomString
    {
        public string baseString = "CharlesIsWeird";
        public void Insert(string stringToInsert, int index)
        {
            string newString = "";
            for (int i = 0; i < (baseString.Count()); i++)
            {
                if (i.Equals(index))
                {
                    newString += stringToInsert;
                    newString += baseString[i];
                } else
                {
                    newString += baseString[i];
                }

            }
                Console.WriteLine(newString);
                Console.ReadLine();
        }

        public int Length()
        {
            int counter = 0;
            foreach (char letter in collection)
            {

            }
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
