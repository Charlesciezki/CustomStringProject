using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    //Underlying structure: System.Collections.Generic.LinkedList
    //Each node of the underlying C# LinkedList holds one character
    class SystemLinkedListString : ICustomString
    {
        public void Insert(string stringToInsert, int index)
        {
            throw new NotImplementedException();
        }

        public int Length()
        {
            throw new NotImplementedException();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
