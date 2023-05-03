using Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoProjectArrays
{
    internal class Program
    {
        //static int red = 9; //if we declare any variable as static, the value of that variable is going to be updated
                            //inside the program and the last time the value that variable got or updated will be its final value. 
        static void Main(string[] args)
        {
            /*
             * operations on the Array
             

            //create an array
            const int size = 4; //when you use const keyword with any variable, is going to define that the variable
                                //is not going to be updated in the program. 
            
            /*int[] var = new int[size];
            Console.WriteLine("Before update the value of red: " + red);
            red = 25;
            Console.WriteLine("After update the value of red: " + red);
            */
            /*
            int[] var1 = new int[] { 1, 2, 3, 4, 5 };
            int[] var2 = new int[] { 1, 2, 3, 4 };
            int[] var3 = new int[size]; //this kind of array creation is done when we plan to initialize values in it in
                                        //the later part of the code

            for (int i = 0; i < size; i++)
                var3[i] = int.Parse(Console.ReadLine());

            //to print array values on the console, we need a loop which will iterate over the array, control each index
            //position one by one and will access that index values

            Console.Write("Array values are: ");
            for (int i = 0; i < size; i++)
                Console.Write(var3[i]+ ",");

            // another way of accessing the array elements: using foreach
            Console.WriteLine();
            foreach (int i in var3)
                Console.Write(i+", ");

            /*
             * Two dimensional array: is a table structure, that means it will have row and column in its data
             * 
             * We need to control iterator to access the elements of a 2D array. The outer control iterator works
             * as row controller, whether the inner control iterator works as a column controller
             * 
             * let's create a two dimensional array
             * 
             * 1 2 3
             * 4 5 6 
             * 7 8 9
             

            //int[rowsize,columnsize]
            int[,] array2d = new int[3, 3] { { 1, 2, 3 } ,{ 4,5,6},{ 7,8,9} };
            
            //to access the two dimensional array, we need a loop which will control the rows and another loop(inner loop)
            //which will control the values of each row, means will control the columns

            /*
            for (int row = 0;row < array2d.GetLength(0); row++) //getlength(0) will point to dimension one size
            {
                for (int col = 0; col < array2d.GetLength(1); col++) //getlength(1) will point to dimension two size
                {
                    Console.Write(array2d[row, col] + " ");
                }
                Console.WriteLine();
            }

            int[,] array2 = new int[4, 2] { { 1, 2}, {3, 4 }, { 5, 6 },{ 7,8} };

            int counter = 2; //because per row we'll have 2 values at most, this value can also start from 0
            foreach (int i in array2)
            { 
                Console.Write(i + ", ");
                counter++;
                if (counter % 2 == 0)  //value 2 is the column size of the array
                    Console.WriteLine();
            }

            **Jagged array
            *column and row size can be anything, not a structured row and col
            *
            *1 2 3 4
            *5 6
            *7 8 9
            

            int[][] jaggedArray = new int[3][] {new int[4] { 1, 2, 3, 4 }, 
                                                new int[2] { 5,6} , 
                                                new int[3] { 7,8,9} };

            for(int row=0; row < jaggedArray.Length; row++)            //outer loop
            {
                for(int col=0; col < jaggedArray[row].Length; col++)  //inner loop
                {
                    Console.Write(jaggedArray[row][col]+" ");
                }
                Console.WriteLine();
            }

            foreach (int[] outer in jaggedArray)  //because the foreach loop will consider the elements of jagged array
                                                  //which is a one-dimensional array
            {
                foreach(int i in outer)           //inner condition is going to print all the inner values
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Now an example with decimal values because we have at most 2 decimal points
            2.5 8.6 9.6 7.5
            2.1 5.8 8.6
            2.2 7.8 9.6 9.5 9.85
            2.2 3.5 4.7
            

            decimal[][] decimalArray = new decimal[4][] { new decimal[4] {2.5m,8.6m,9.6m,7.5m }, 
                                                new decimal[3]{2.1m,5.8m, 8.6m },
                                                new decimal[5]{ 2.2m,7.8m,9.6m,9.5m,9.85m},
                                                new decimal[3]{2.2m,3.5m,4.7m }};

            foreach (decimal[] outer in decimalArray)
            {
                foreach (decimal value in outer)           
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }

            for(int row=0; row < decimalArray.Length; row++)
            {
                for(int col=0; col < decimalArray[row].Length; col++)
                {
                    Console.Write((decimal)decimalArray[row][col]+ ", ");
                }
                Console.WriteLine();
            }

            **List Structure
            

            List<int> listVar1 = new List<int>();
            //to add any values to your list
            listVar1.Add(2); //index position 0
            listVar1.Add(3); //index position 1
            listVar1.Add(4); //index position 2

            //to add any specific position, let's say at pos 1 want to add 9
            listVar1.Insert(1, 9);

            foreach (int i in listVar1)
            {
                Console.Write(i + ", ");
            }
            
            */

            listWork lw = new listWork(); //creating the instance of the class
            lw.AddValue(2);
            lw.AddValue(3);
            lw.AddValue(4);
            lw.AddValuePosition(2, 3);

            foreach (int i in lw.getList())
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
