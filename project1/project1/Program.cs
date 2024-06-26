﻿//OOP: opject oriented programming (everything is a class
//native types: int, float, string etc
//data structures: vectors, arrays, etc 

using System.Collections.Generic;
using System.Timers;


using System;
using System.Runtime.CompilerServices;
using System.Threading;

public class Program
{
    

    public static void Main(string[] args)
    {
        //defining a vector INSTNACE
        Vector v1 = new Vector(1.0, 2.0, 3.0);
        Vector v2 = new Vector(4, 5, 6);


        Program program = new Program();

        Console.WriteLine(v1);
        System.Timers.Timer mytimer = new System.Timers.Timer(2000);

        // Attach the event handler
        mytimer.Elapsed += program.update;

        // Enable auto-reset
        mytimer.AutoReset = true;

        // Start the timer
        mytimer.Start();

        // Keep the program running
        Console.ReadLine();
    }
    LinkedList<Vector> body;
    int index = 0;

    Program() {
        Vector[] defaultValues = { new Vector(0, 0, 1), new Vector(0, 0, 0), new Vector(0, 0, 0), new Vector(0, 0, 0) };

        this.body = new LinkedList<Vector>(defaultValues);

    }

     void update(object sender, ElapsedEventArgs e)
    {
        var head = body.First;
        body.RemoveFirst();
        var tail = body.Last;
        body.AddLast(head);

        tail = body.Last;
        while (tail != null)
        {
            Console.Write(tail.Value + " ");

            tail = tail.Previous;
        }
        Console.WriteLine();

    }

    public static double reduce(double x)
    {
        
        if (x > 2) {
            //recursive call 
            return reduce(x / 2);
        }
        return x;
    }

    public static double sum(double x)
    {
        if (x > 0)
        {
            //recursive call 
            return sum(x - 1) + x;
            
        }
        return x;
    } 
}


//defining the Vector CLASS
public class Vector
{

    public double x; //attribute DECLARATION 
    public double y;
    public double z;

    public Vector(double i, double j, double k) //constructor
    {
        this.x = i; //attribute DEFINATIONS  
        this.y = j;
        this.z = k;
    }

    public Vector add(Vector v) //vector method add , returns the same vector but updated
    {
        //instance call: myVectorInstance.add()
        this.x += v.x;
        this.y += v.y;
        this.z += v.z;
    
        return this;
    }

    public static Vector getAdd(Vector v, Vector v2) //vector method getAdd, returns a new vector 
    {
        //static means it must be refrenced from the class and not the instance

        //class call: Vector.getAdd();

        return new Vector(v2.x + v.x, v2.y + v.y, v2.z + v.z);
    }

    public override string ToString()
    {
        //over riding the toString method, toString is a method in every class in c#
        return $"X: {x} Y: {y} Z: {z}";
    }
}
//real number 1,2, 3, ... n + 1


//f(x) = f(x -1) + x

//f(2) = f(1) + f(0) + 0 + 1 + 2


// [5] -> [4] -> [3]