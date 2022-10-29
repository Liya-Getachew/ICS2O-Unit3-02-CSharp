// Created by: liya getachew
// Created on: Oct 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double length;
        double width;
        double height;

        Console.WriteLine("This program calculates the volume of a pyramid (cm).");

        Console.WriteLine("Enter the dimensions of the pyramid here: ");
        Console.WriteLine("");

        Console.Write("Length of trapezoid (cm): ");
        length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Width of trapezoid (cm): ");
        width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Height of trapezoid (cm): ");
        height = Convert.ToDouble(Console.ReadLine());

        double volume = (length * width * height) / 3;

        Console.WriteLine("");
        Console.WriteLine("Volume = " + volume.ToString("0.00") + " cm³.");

        Console.WriteLine("\nDone.");
    }
}