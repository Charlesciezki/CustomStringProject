using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    //Underlying structure: your own custom linked list
    //Each node of the underlying custom linked list structure holds one character
    public class CustomLinkedListString : ICustomString
    {
        public List<char> myList = new List<char>() { 'r', 'a', 'p', 't', 'u', 'r', 'e' };
        public LinkedList<char> myLinkedList;
        public CustomLinkedListString()
        {
            myLinkedList = new LinkedList<char>(myList);
        }
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
