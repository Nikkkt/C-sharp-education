using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFCalculator
{
    public class CalculatorMath
    {
        public static double Factorial(double n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++) fact *= i;
            return fact;
        }
        public static double Divide(double n1, double n2)
        {
            if (n2 == 0) { MessageBox.Show("Division by 0 is not supported.", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error); return 0; }
            return n1 / n2;
        }
        public static double Add(double n1, double n2) { return n1 + n2; }
        public static double Subtract(double n1, double n2) { return n1 - n2; }
        public static double Multiply(double n1, double n2) { return n1 * n2; }
        public static double Power(double n1, double n2) { return Math.Pow(n1, n2); }
        public static double Sqrt(double n) { return Math.Sqrt(n); }
        public static double Log10(double n) { return Math.Log10(n); }
        public static double Ln(double n) { return Math.Log(n); }
        public static double Sin(double n) { return Math.Sin(n); }
        public static double Cos(double n) { return Math.Cos(n); }
        public static double Tan(double n) { return Math.Tan(n); }
    }
}
