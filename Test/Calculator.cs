namespace MyMathOperations
{
    public class Calculator
    {
        /// <summary>
        /// Adds two double-precision floating-point numbers.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The sum of a and b.</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts the second double-precision floating-point number from the first.
        /// </summary>
        /// <param name="a">The minuend.</param>
        /// <param name="b">The subtrahend.</param>
        /// <returns>The result of subtracting b from a.</returns>
        public double Subtract(double a, double b)
        {
            return a - b;
        ;
        }

        /// <summary>
        /// Multiplies two double-precision floating-point numbers.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The product of a and b.</returns>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides the first double-precision floating-point number by the second.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <returns>The result of dividing a by b.</returns>
        /// <exception cref="System.ArgumentException">Thrown when the divisor (b) is zero.</exception>
        public double Divide(double a, double b)
        {
            if (b == 0.0)
            {
                throw new System.ArgumentException("Cannot divide by zero.", nameof(b));
            }
            return a / b;
        }
    }
}
