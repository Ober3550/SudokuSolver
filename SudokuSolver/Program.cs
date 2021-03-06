using System;

namespace SudokuSolver
{
    class Program
    {
        static int[,] puzzle1 =
        {
            { 5,3,0,0,7,0,0,0,0 },
            { 6,0,0,1,9,5,0,0,0 },
            { 0,9,8,0,0,0,0,6,0 },
            { 8,0,0,0,6,0,0,0,3 },
            { 4,0,0,8,0,3,0,0,1 },
            { 7,0,0,0,2,0,0,0,6 },
            { 0,6,0,0,0,0,2,8,0 },
            { 0,0,0,4,1,9,0,0,5 },
            { 0,0,0,0,8,0,0,7,9 },
        };
        static void printSudoku(int[,] puzzle)
        {

        }
        static bool possible(int[,] puzzle,int x, int y, int n)
        {
            return false;
        }
        static int[,] solver(int[,] puzzle)
        {
            return puzzle;
        }
        static void Main(string[] args)
        {
            printSudoku(puzzle1);
            // Print solved when done
            printSudoku(solver(puzzle1));
            Console.Read();
        }
    }
}
