//OOP: opject oriented programming (everything is a class
//native types: int, float, string etc
//data structures: vectors, arrays, etc 



using System;

public class Program
{
    public static void Main(string[] args)
    {
        Vector v1 = new Vector(1.0, 2.0, 3.0);
        Vector v2 = new Vector(4, 5, 6);

//        Console.WriteLine(v1);

        double y = 6;

        Console.Write(sum(y));

    }

    public static double reduce(double x)
    {
        if (x > 2) {
            return reduce(x / 2);
        }
        return x;
    }

    public static double sum(double x)
    {
        if (x > 0)
        {
            return sum(x - 1) + x;
            
        }
        return x;
    } 
}

public class Vector
{

    public double x;
    public double y;
    public double z;

    public Vector(double i, double j, double k)
    {
        this.x = i;
        this.y = j;
        this.z = k;
    }

    public Vector add(Vector v)
    {
        this.x += v.x;
        this.y += v.y;
        this.z += v.z;
    
        return this;
    }

    public static Vector getAdd(Vector v, Vector v2)
    {
        return new Vector(v2.x + v.x, v2.y + v.y, v2.z + v.z);
    }

    public override string ToString()
    {
        return $"X: {x} Y: {y} Z: {z}";
    }
}
//real number 1,2, 3, ... n + 1


//f(x) = f(x -1) + x

//f(2) = f(1) + f(0) + 0 + 1 + 2