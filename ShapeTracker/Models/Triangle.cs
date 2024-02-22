using System.Collections.Generic;

namespace ShapeTracker.Models // name 'models' is standard name in C# to describe "businesse logic"
{
  public class Triangle
  // public: access modifier 
  // other access modifiers: internal (default), private
  // best practice for class fields is to set them to private: in order to alter obj fields without breaking the rule, 'getters' and 'setters' methods come in. convention for private fields, add an underscore. 
  // Abstraction - Polymorphism - Inheritance - Encapsulation (APIE)
  {
    // Code for Triangle business logic will go here.
    private int _side1;
    public int Side1
    // property: mechanism that we can add to our classes to read, write, and compute the value of class fields. (differs from JS properties)
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    public int Side2 { get; set; }
    // adding auto-implemented property 
    private int _side3;
    // 'field': variables declared within a C# class. also referred as 'members' of the Triangle class. 
    // keyword 'public': access level modifiers. can be accessed from anywhere in the app. 
    private static List<Triangle>_instances = new List<Triangle> {};

    public Triangle(int length1, int length2, int length3)
    // adding a Constructor 
    {
      _side1 = length1;
      Side2 = length2;
      _side3 = length3;
      _instances.Add(this);
    }

    public int GetSide3()
    {
      return _side3;
    }

    public void SetSide3(int newSide)
    {
      _side3 = newSide;
    }

    public string CheckType()
    // adding a method
    {
      // Updated fields within the CheckType() method:
      if ((_side1 > (Side2 + _side3)) || (Side2 > (_side1 + _side3)) || (_side3 > (_side1 + Side2)))
      {
        return "not a triangle";
      } 
      else if ((_side1 != Side2) && ((_side1 != _side3)) && ((Side2 != _side3))) 
      {
        return "scalene triangle";
      }  
      else if ((_side1 == Side2) && (_side1 == _side3)) 
      {
        return "equilateral triangle";
      } 
      else 
      {
        return "isosceles triangle";
      }
    }

    public static List<Triangle> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}