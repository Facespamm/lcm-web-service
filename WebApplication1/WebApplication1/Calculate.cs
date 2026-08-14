using System.Numerics;

namespace WebApplication1;

public class Calculate
{
    private BigInteger _x {get; set;}
    private BigInteger _y {get; set;}

    public Calculate(BigInteger x, BigInteger y)
    {
        _x = x;
        _y = y;
    }

    public BigInteger GetGCD(BigInteger x, BigInteger y)
    {
        while (y != 0)
        {
            var temp = y;
            y = x % y;
            x= temp;
        }

        return x;
    }
    
    public BigInteger GetLCM(BigInteger x, BigInteger y)
    {
        var result = GetGCD(x, y);
        return (x /result)*y;
    }
}