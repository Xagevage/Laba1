using System;

namespace MathUtils
{
    public class Rational
    {
        public int Num { get; }
        public int Denom { get; }

        public Rational(int num, int denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            int gcd = ComputeGCD(Math.Abs(num), Math.Abs(denom));
            num /= gcd;
            denom /= gcd;

            if (denom < 0)
            {
                num = -num;
                denom = -denom;
            }

            Num = num;
            Denom = denom;
        }

        private static int ComputeGCD(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }

        public override string ToString()
        {
            return Denom == 1 ? $"{Num}" : $"{Num}/{Denom}";
        }

        public static Rational operator +(Rational left, Rational right)
        {
            int num = left.Num * right.Denom + right.Num * left.Denom;
            int denom = left.Denom * right.Denom;
            return new Rational(num, denom);
        }

        public static Rational operator -(Rational left, Rational right)
        {
            int num = left.Num * right.Denom - right.Num * left.Denom;
            int denom = left.Denom * right.Denom;
            return new Rational(num, denom);
        }

        public static Rational operator *(Rational left, Rational right)
        {
            return new Rational(left.Num * right.Num, left.Denom * right.Denom);
        }

        public static Rational operator /(Rational left, Rational right)
        {
            if (right.Num == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return new Rational(left.Num * right.Denom, left.Denom * right.Num);
        }

        public static Rational operator -(Rational fraction)
        {
            return new Rational(-fraction.Num, fraction.Denom);
        }

        public static bool operator ==(Rational left, Rational right)
        {
            return left.Num == right.Num && left.Denom == right.Denom;
        }

        public static bool operator !=(Rational left, Rational right)
        {
            return !(left == right);
        }

        public static bool operator <(Rational left, Rational right)
        {
            return left.Num * right.Denom < right.Num * left.Denom;
        }

        public static bool operator >(Rational left, Rational right)
        {
            return left.Num * right.Denom > right.Num * left.Denom;
        }

        public static bool operator <=(Rational left, Rational right)
        {
            return left < right || left == right;
        }

        public static bool operator >=(Rational left, Rational right)
        {
            return left > right || left == right;
        }
    }
}