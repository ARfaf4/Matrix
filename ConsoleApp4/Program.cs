using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From what rank is the matrix: ");
            int rank = int.Parse(Console.ReadLine());
            List<double> matrix = new List<double>();
            List<double> vector = new List<double>();
            for (int i = 0; i < rank; i++)
            {
                Console.WriteLine("Enter row " + i + " :");
                var row = Console.ReadLine();
                var list = row.Split(' ').ToList();
                foreach (var item in list)
                {
                    double n = double.Parse(item);
                    matrix.Add(n);
                }              
            }
            Console.WriteLine("Enter vector:");
            var row1 = Console.ReadLine();
            var list1 = row1.Split(' ').ToList();
            foreach (var item in list1)
            {
                double n = double.Parse(item);
                vector.Add(n);
            }

            if (rank == 3)
            {
                var A = Matrix<double>.Build.DenseOfArray(new double[,]{
                 { matrix[0], matrix[1], matrix[2]},
                 { matrix[3] , matrix[4], matrix[5]},
                 { matrix[6], matrix[7], matrix[8]},
                  });
                var b = Vector<double>.Build.Dense(new double[]
                { vector[0] , vector[1] , vector[2] });
                var x = A.Solve(b);

                Console.WriteLine(x);
                Console.ReadKey();
            }
            else if (rank == 4 )
            {
                var A = Matrix<double>.Build.DenseOfArray(new double[,]{
                 { matrix[0], matrix[1], matrix[2], matrix[3]},
                 { matrix[4] , matrix[5], matrix[6], matrix[7]},
                 { matrix[8], matrix[9], matrix[10], matrix[11]},
                  });
                var b = Vector<double>.Build.Dense(new double[]
                { vector[0], vector[1] , vector[2] , vector[3]});
                var x = A.Solve(b);

                Console.WriteLine(x);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid matrix rank!!!");
            }
            
            
        }
    }
}
