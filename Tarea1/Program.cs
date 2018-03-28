//Joshua Crane (M00489477)
//Prof. Alberto Prado
//Comp 2900-10075
//Mar. 27, 2017

/*THis is just a simple programs storing 3 numbers into an array. The program then calculates the smallest number.
 Its an old project from class. A year ago*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
//----------------------------------------------------------------------------------------------------------------------------//
//----------------------------------------------------------------------------------------------------------------------------//
//----------------------------------------------------------------------------------------------------------------------------//
//----------------------------------------------------------------------------------------------------------------------------//
        static void Main()//Modulo 1
        {
            int x = 0;
            int z = 1;
            int d = 0;

            Console.Write("¿Cuántos números desea entrar?: ");
            x = Int32.Parse(Console.ReadLine());


            int[] storage = new int[x];
            for (int i = 0; i < storage.Length; i++)//
            {
                Console.Write("Entre el número " + z + ": ");//UI 
                storage[i] = Int32.Parse(Console.ReadLine());//Storing numbers into array
                z++;
            }//End for
            d = storage[0];//test for Modulo 2
            Process(storage, d);//Link to Modulo 2
            for (int i = 0; i < storage.Length; i++)//Loop for printing Array
            {
                Console.Write(storage[i] + " ");
            }//end for
            Console.WriteLine();//Space

            Console.ReadKey();//System Pause;
        }//End static Main()
 //----------------------------------------------------------------------------------------------------------------------------//
 //----------------------------------------------------------------------------------------------------------------------------//
 //----------------------------------------------------------------------------------------------------------------------------//
 //----------------------------------------------------------------------------------------------------------------------------//
        static void Process(int[] storage, int d)//Modulo 2
        {

                for (int i = 0; i < storage.Length; i++)//Calculator for Smallest #
                {
                    if (storage[i] < d)
                    {
                        d = storage[i];//Storage for Smallest #
                    }//end if

                }//end for
            Console.WriteLine("El número menor es " + d + " en el siguiente array");//Print Smallest #
        }//End static Process
//----------------------------------------------------------------------------------------------------------------------------//
//----------------------------------------------------------------------------------------------------------------------------//
//----------------------------------------------------------------------------------------------------------------------------//
//----------------------------------------------------------------------------------------------------------------------------//
    }//End class Program
}//End namespace Tarea1
