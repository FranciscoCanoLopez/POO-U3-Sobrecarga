using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U3_Sobrecarga
{
    internal class Operation
    {
        // Method to add two numbers
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // Method to add three numbers
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to subtract two numbers
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method to subtract three numbers
        public int Subtract(int a, int b, int c)
        {
            return a - b - c;
        }
    }
}
