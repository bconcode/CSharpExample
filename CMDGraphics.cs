using System;

namespace AllExamplesHere
{
    public class CMDGraphics
    {
        public void PrintStarTriangleReverse()
        {
            Console.WriteLine("Enter no.of triangle rows:");
            int rows = Int32.Parse(Console.ReadLine());
            for(int i=0; i<rows; i++)
            {
                for(int j=rows-i; j>0; j--)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }

        public void PrintStarTriangle()
        {
            Console.WriteLine("Enter no.of triangle rows:");
            int rows = Int32.Parse(Console.ReadLine());
            for(int i=1; i<=rows; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }

        public void PrintStarTrianglePyramid()
        {
            Console.WriteLine("Enter no.of triangle rows:");
            int rows = Int32.Parse(Console.ReadLine());
            for(int i=0; i<rows; i++)
            {   

                for(int j=rows-i; j>0; j--)
                {
                    for(int k=rows-j; k<rows;k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }

}