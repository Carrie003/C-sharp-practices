using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//build a simple calculator with + - * / operands



namespace Calculator
{
    public class Operation
    {
        private double num_1;
        private double num_2;

        public double num1
        {
            get { return num1; }
            set { num_1 = value; }
        }
        public double num2
        {
            get { return num_2; }
            set { num_2 = value; }
        }
        public virtual double getResult()
        {
            double result = 0;
            return result;
        }
    }
    public class Addition : Operation
    {
        public override double getResult()
        {
            return (double)(num1 + num2);
        }
    }
    public class Subtraction : Operation
    {
        public override double getResult()
        {
            return (double)(num1 - num2);
        }
    }
    public class Multiplication : Operation
    {
        public override double getResult()
        {
            return (double)(num1 * num2);
        }
    }
    public class Division : Operation
    {
        public override double getResult()
        {
            if (num2 != 0)
            {
                return (double)(num1 / num2);

            }
            return 0;

        }
    }
    // factory method pattern
    public class OperationFactory
    {
        public static Operation createOperation(string item)
        {
            Operation temp = null;
            switch (item)
            {
                case "+":
                    temp = new Addition();
                    break;
                case "-":
                    temp = new Subtraction();
                    break;
                case "*":
                    temp = new Multiplication();
                    break;
                case "/":
                    temp = new Division();
                    break;
            }
            return temp;
        }
    }
    
}