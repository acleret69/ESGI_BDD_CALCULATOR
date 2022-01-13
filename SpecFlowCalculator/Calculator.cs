using System;
using System.Collections.Generic;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public List<int> nombres = new List<int>();
        public List<string> operente = new List<string>();
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        
        public int result { get; set; }


        public int opérations()
        {
            result = nombres[0];
            try
            {
                for (int i = 0; i < operente.Count; i++)
                {
                    switch (operente[i])
                    { case "+":
                            result = result + nombres[i+1];
                            break;
                        case "-":
                            result = result - nombres[i+1];
                            break;
                        case "*":
                            result = result * nombres[i+1];
                            break;
                        case "/":
                            result = result / nombres[i+1];
                            break;
                    }
                }
                return result;
            }
            catch (DivideByZeroException)
            {
                throw new InvalidOperationException("error impossible divised with 0");
            }
        }
        public int Add()
        {
            for (int i = 0; i < nombres.Count; i++)
            {
                result = result + nombres[i];
            }
           return result;
        }
        
        public int soustract()
        {
            result = nombres[0];
            for (int i = 1; i < nombres.Count; i++)
            {
                result = result - nombres[i];
            }
            return result;
        }

        public int Multiplie()
        {
            result = nombres[0];
            for (int i = 1; i < nombres.Count; i++)
            {
                result = result * nombres[i];
            }
            return result;
        }
        
        public int Divise()
        {
            try
            {
                result = nombres[0];
                for (int i = 1; i < nombres.Count; i++)
                {
                    result = result / nombres[i];
                }
                return result;
            }
            catch (DivideByZeroException)
            {
                throw new InvalidOperationException("error impossible divised with 0");
            }
        }
    }
}