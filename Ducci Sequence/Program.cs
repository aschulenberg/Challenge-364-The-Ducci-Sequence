using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input_1 = {1, 5, 7, 9, 9 };
            int[] input_2 = { 1, 2, 1, 2, 1, 0 };
            int[] input_3 = { 10, 12, 41, 62, 31, 50 };
            int[] input_4 = { 10, 12, 41, 62, 31 };




        }
        /// <summary>
        /// Takes a number sequence and ouputs all the steps involves in the Duccu sequence to an array;
        /// </summary>
        /// <param name="input_sequence">A sequence of numbers to pass through the Ducci Sequence</param>
        /// <returns>a 2D array of the resulting ducci sequence </returns>
        public int[][] DucciSequence(int[] input_sequence)
        {
            int[][] result = { };
            result[0,] = input_sequence; 
            int count = 1;
            for(int i = 0; i < input_sequence.Length;i++)
                {
                result[count][i] = input_sequence[i+1] - input_sequence[i];
               }

            return result;
        }
    }
}

