using System.Numerics;

namespace Fibonacci;

public class Fibonacci
{
    public static BigInteger Nth(int n, BigInteger? a = null, BigInteger? b = null)
    {
        return recur(n, a ?? 0, b ?? 1);
    }

    private static BigInteger recur(int n, BigInteger a, BigInteger b)
    {
        return n == 0 ? a : recur(n - 1, a + b, a);
    }
}