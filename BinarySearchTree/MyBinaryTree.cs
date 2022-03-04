using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryNode<T> where T : IComparable
    {
<<<<<<< Updated upstream
            T nodedata;
            public MyBinaryNode<T> lefttree { get; set; }
            public MyBinaryNode<T> righttree { get; set; }
            bool result = false;

            public MyBinaryNode(T nodedata)
=======
        T nodedata;
        public MyBinaryNode<T> lefttree { get; set; }
        public MyBinaryNode<T> righttree { get; set; }
        bool result = false;
        static int leftcount = 0;
        static int rightcount = 0;
        static MyBinaryNode() {
            Console.WriteLine("static constructor");
      
        }
        public MyBinaryNode(T nodedata)
        {
            // this.nodedata = nodedata;
            Console.WriteLine("Instance constructor");
            this.nodedata = nodedata;
            this.lefttree = null;
            this.righttree = null;
        }
        public void Insert(T item)
        {
            T currentnodevalue = this.nodedata;
            if ((currentnodevalue.CompareTo(item)) > 0)
>>>>>>> Stashed changes
            {
                this.nodedata = nodedata;
                this.nodedata = nodedata;
                this.lefttree = null;
                this.righttree = null;
            }

            public void Insert(T item)
            {
                T currentnodevalue = this.nodedata;
                if ((currentnodevalue.CompareTo(item)) > 0)
                {
                    if (this.lefttree == null)
                        this.lefttree = new MyBinaryNode<T>(item);
                    else
                        this.lefttree.Insert(item);
                }
                else
<<<<<<< Updated upstream
                {
                    if (this.righttree == null)
                        this.righttree = new MyBinaryNode<T>(item);
                    else
                        this.righttree.Insert(item);
                }
=======
                    this.righttree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.lefttree != null)
            {
                leftcount++;
                this.lefttree.Display();
            }
            Console.WriteLine(this.nodedata.ToString());
            if (this.righttree != null)
            {
                rightcount++;
                this.righttree.Display();
>>>>>>> Stashed changes
            }
            public void Display()
            {
                if (this.lefttree != null)
                {
                    this.lefttree.Display();
                }
                Console.WriteLine(this.nodedata.ToString());
                if (this.righttree != null)
                {
                    this.righttree.Display();
                }
            }
        
    }
}
