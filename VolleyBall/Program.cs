using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall
{
    class Program
    {
        long[] arr = new long[55];
        const long modulo = 1000000007;
        public long InverseEuler(long a)
        {
            long x = 1, z = modulo - 2;
            while(z>0)
            {
                if (z % 2 == 1)
                    x = (x * a) % modulo;
                a = (a * a) % modulo;
                z /= 2;
            }
            return x;
        }
        public long modPow(long a, long exp)
        {
            long res = 1;
            while(exp > 0)
            {
                if (exp % 2 ==1)
                    res = (res * a) % modulo;
                a = (a * a) % modulo;
                exp >>= 1;
            }
            return res;
        }
        public long count (long a, long b)
        {
            if (a >= 25 || b >= 25)
            {
                arr[0] = arr[1] = 1;
                for (long i = 2; i <= 50; i++)
                {
                    arr[i] = ((long)i * arr[i - 1]) % modulo;
                }
                long min = Math.Min(a, b), max = Math.Max(a, b);
                long n = Math.Min(a + b - 1, 47), r = Math.Min(max - 1, 24);
                long res = (arr[n] * ((InverseEuler(arr[r]) * InverseEuler(arr[n - r])) % modulo)) % modulo;
                if ((a == 25 && b < 24) || (a < 24 && b == 25))
                    return res;
                else if (Math.Abs(a - b) != 2)
                    return 0;
                else
                    return (res * modPow(2, max - 25)) % modulo;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Program Volley = new Program();
            long a, b;
            a = Convert.ToInt64(Console.ReadLine());
            b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(Volley.count(a, b));
            Console.ReadLine();
        }
    }
}