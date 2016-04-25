using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class Program
    {
//        Create a custom string structure:
//    Create an ICustomString interface with the following custom functions:
//        string ToString()
//        void Insert(string stringToInsert)
//        void Remove(int startIndex, int numCharsToRemove)
//        int Length()
//    Inherit from the ICustomString interface to implement the following custom string subclasses:
//        SystemString
//            Underlying structure: System.string
//            Piggyback off System.string's built-in functionality to implement ICustomString's functions
//        SystemArrayString
//            Underlying structure: System.array
//            Each index of the underlying array holds one character
//        SystemLinkedListString
//            Underlying structure: System.Collections.Generic.LinkedList
//            Each node of the underlying C# LinkedList holds one character
//        CustomLinkedListString
//            Underlying structure: your own custom linked list
//            Each node of the underlying custom linked list structure holds one character
        static void Main(string[] args)
        {
            //SystemString systemstring = new SystemString();
            //systemstring.Insert("nt", 9);
            //systemstring.Length();
            //systemstring.Remove(7, 2);

            //SystemArrayString arrayString = new SystemArrayString();
            //arrayString.Insert("the", 0);
            //arrayString.Length();
            //arrayString.Remove(2, 3);

            SystemLinkedListString systemLinkedList = new SystemLinkedListString();
            Node<string> node = new Node<string>("ILoveThe");
            systemLinkedList.Insert(node.storage, 0);
            Console.ReadLine();
        }
    }
}
