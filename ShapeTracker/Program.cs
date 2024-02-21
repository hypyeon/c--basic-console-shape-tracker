using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
// entry point of app: name for the app or company 
{
  class Program
  {
    static void Main()
    {
      // user interface code

      List<Triangle> allTriangles = Triangle.GetAll();

      Triangle testTriangle = new Triangle(3, 4, 5); 
      // invoking the constructor method.

      Triangle secondTriangle = new Triangle(32, 74, 75);

      //Triangle.ClearAll(); // to triger "There are no triangles!" in console.

      if (allTriangles.Count == 0) 
      {
        Console.WriteLine("There are no triangles!");
      }
      else 
      {
        Console.WriteLine("You have triangles!");
        Console.WriteLine("----------------------------------");
        foreach (Triangle tri in allTriangles)
        {
          Console.WriteLine($"Side one of the triangle: {tri.GetSide1()}");
          Console.WriteLine($"Side two of the triangle: {tri.GetSide2()}");
          Console.WriteLine($"Side three of the triangle: {tri.GetSide3()}");
          Console.WriteLine("----------------------------------");
        }
      }

      //Console.WriteLine(testTriangle.GetType());
      // removing ; will cause a compiler error

      //testTriangle.Side1 = 65;
      //testTriangle.Side3 = 88;
      /*
      Console.WriteLine($"Side one of the triangle: {testTriangle.GetSide1()}");
      Console.WriteLine($"Side two of the triangle: {testTriangle.GetSide2()}");
      Console.WriteLine($"Side three of the triangle: {testTriangle.GetSide3()}");

      // adding the next lines after adding a method in Triangle.cs
      Console.WriteLine("Want to know what type of triangle you have?");
      Console.WriteLine("Calculating...");
      Console.WriteLine($"Your triangle is: {testTriangle.CheckType()}.");

      // adding the next lines after adding setter mothods in Triangle.cs
      Console.WriteLine("Updating...");
      testTriangle.SetSide1(44);
      testTriangle.SetSide2(44);
      testTriangle.SetSide3(70);
      Console.WriteLine($"Actually, I've just changed the values of your triangle's sides to {testTriangle.GetSide1()}, {testTriangle.GetSide2()}, and {testTriangle.GetSide3()}.");
      Console.WriteLine($"Now your triangle is: {testTriangle.CheckType()}.");
      */
    }
  }
}