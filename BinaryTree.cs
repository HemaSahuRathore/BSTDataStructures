using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15BinaryTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public T nodeValue;
        public BinaryTree<T> leftTree;
        public BinaryTree<T> rightTree;

        public BinaryTree(T nodeValue) //constructor
        {
            this.nodeValue = nodeValue;
            this.leftTree = null;
            this.rightTree = null;
        }

        //method to insert element
        public void Insert(T value)
        {
            T currentNodeValue = nodeValue;
            if(currentNodeValue.CompareTo(value) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinaryTree<T>(value);
                else
                    this.leftTree.Insert(value);
            }
            else
            {
                if(this.rightTree == null)
                    this.rightTree = new BinaryTree<T>(value);
                else
                    this.rightTree.Insert(value);
            }

        }    
        
        //display
        public void Display()
        {  
            if(this.leftTree != null)
            {
                this.leftTree.Display();    
            }
            Console.WriteLine(this.nodeValue.ToString());
            if (this.rightTree != null)
            {
                this.rightTree.Display();   
            }
        }
    }
}
