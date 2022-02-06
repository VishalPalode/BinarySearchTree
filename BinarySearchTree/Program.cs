using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBinaryNode<int> bst = new MyBinaryNode<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            Console.WriteLine("Binary Search Tree ");
            bst.Display();
            Console.ReadLine();
       
        }
    }
}

