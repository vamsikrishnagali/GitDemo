namespace GItDemo;
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }

        return (double)a / b;
    }

}


public class area
{
    public int Square(int l, int w)
    {
        return l * w;
    }
}
