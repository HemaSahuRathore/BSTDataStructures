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

        int leftCount = 0, rightCount = 0;
        bool result = false;

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
                {
                    this.leftTree = new BinaryTree<T>(value);
                    this.leftCount++;
                }
                else
                {
                    this.leftTree.Insert(value);
                    this.leftCount++;
                }
            }
            else
            {
                if(this.rightTree == null)
                {
                    this.rightTree = new BinaryTree<T>(value);
                    this.rightCount++;
                }

                else
                {
                    this.rightTree.Insert(value);
                    this.rightCount++;
                }
                   
            }

        }    
        
        //display
        public void Display()
        {  
            if(this.leftTree != null)
            {
                
                this.leftTree.Display();    
            }
            Console.Write(this.nodeValue.ToString() + " ");
            if(this.rightTree != null)
            {
                this.rightTree.Display();   
            }
        }

        //size
        public void GetSize()
        {
            Console.WriteLine("\nSize : " + (this.leftCount + this.rightCount + 1));
        }

        //recursively search
        public bool IfExists(T element, BinaryTree<T> binaryTree)
        {
            if(binaryTree == null)
            {
                return false;
            }
            if (binaryTree.nodeValue.Equals(element))
            {
                Console.WriteLine("Element {0} found!", binaryTree.nodeValue);
                result = true;
            }
            if (element.CompareTo(binaryTree.nodeValue) < 0)
            {
                IfExists(element, binaryTree.leftTree);
            }
            if(element.CompareTo(binaryTree.nodeValue) > 0)
            {
                IfExists(element, binaryTree.rightTree);
            }
            
            return result;
        }
    }
}
