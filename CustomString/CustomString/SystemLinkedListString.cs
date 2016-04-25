using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    //Underlying structure: System.Collections.Generic.LinkedList
    //Each node of the underlying C# LinkedList holds one character
    public class SystemLinkedListString : ICustomString
    {
        public List<char> myList = new List<char>(){ 'r', 'a', 'p', 't', 'u', 'r', 'e'};
        public LinkedList<char> myLinkedList;
        public Node<string> node;
        public SystemLinkedListString()
        {
            myLinkedList = new LinkedList<char>(myList);
        }
        public void Insert(string stringToInsert, int index)
        {
            node = new Node<string>(stringToInsert);
            myLinkedList.AddAfter(,);
        }

        public int Length()
        {
            int counter = 0;
            foreach (char letter in myLinkedList)
            {
                counter++;
            }
            Console.WriteLine(counter);
            return counter;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
