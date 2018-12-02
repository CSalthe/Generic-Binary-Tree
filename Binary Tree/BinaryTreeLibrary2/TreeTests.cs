// Program 5
// 12/4/2018
// CIS 200-01
// D7090
// This class creates three arrays of differing types of test data to be input into the generic tree class created within this file, this demonstrates the dynamic nature of generic classes within .net
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace BinaryTreeLibrary2
{
    class TreeTests
    {
      
        //Precondition: None
        //Postcondition: order traversals of tree data structures of types: int, double and string are output to the console
        static void Main()
        {

            int[] intArray = { 9, 5, 3, 2, 12, 53, 1, 6, 14, 8 }; // Array of integers test data 
            double[] doubleArray = { 1.4, 6.5, 3.4, 7.8, 2.5, 4.5, 6.3, 3.5, 2.7, 9.1 }; // Array of doubles test data
            string[] stringArray = { "four", "five", "six", "seven", "Eight", "nine", "ten", "One", "two", "Eleven" }; // Array of strings test data
            
            // Int Tree object
            Tree<int> intTree = new Tree<int>();

            //populates int tree with node values 
            foreach (var nums in intArray)
            {
                intTree.InsertNode(nums);
            }

            //Double Tree Object
            Tree<double> doubleTree = new Tree<double>();

            //populates double tree with node values
            foreach(double nums in doubleArray)
            {
                doubleTree.InsertNode(nums);
            }

            //string Tree Object
            Tree<string> stringTree = new Tree<string>();

            //populates double tree with node values
            foreach (string words in stringArray)
            {
                stringTree.InsertNode(words);
            }

            //Output Section

            intTree.InorderTraversal(); //Int tree in order traversal

            WriteLine();// Spaces out output
            ReadLine(); // pause for user input before revealing next tree 
            WriteLine();// Spaces out output

            doubleTree.InorderTraversal(); //double tree in order traversal

            WriteLine();// Spaces out output
            ReadLine(); // pause for user input before revealing next tree 
            WriteLine();// Spaces out output

            stringTree.InorderTraversal(); //string tree in order traversal

            WriteLine();// Spaces out output
            WriteLine();// Spaces out output
            WriteLine();// Spaces out output
        }

    }
}
