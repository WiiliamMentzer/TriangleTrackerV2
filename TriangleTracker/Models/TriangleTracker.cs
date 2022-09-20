using System;

namespace TriangleTracker
{
  public class TriangleTracker
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }
    
    public TriangleTracker(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public bool IsTriangle()
    {
      if ((Side1 + Side2) <= Side3 || (Side1 + Side3) <= Side2 || (Side2 + Side3) <= Side1)
      {
        return false;
      } else {
        return true;
      }
    }

    public string TriangleType()
    {
      if (Side1 == Side2 && Side2 == Side3)
      {
        return "Equal";
      } else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3) {
        return "Isosceles";
      } else if (Side1 != Side2 && Side1 != Side3 && Side2 != Side3) {
        return "Scalene";
      } else {
        return "End";
      }
    }

    public static void Main()
    {
      Console.WriteLine("Enter Side 1:");
      int side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Side 2:");
      int side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Side 3:");
      int side3 = int.Parse(Console.ReadLine());

      TriangleTracker myTriangleTracker = new TriangleTracker(side1, side2, side3);

      if (myTriangleTracker.IsTriangle() == true)
      {
        Console.WriteLine(myTriangleTracker.TriangleType());
      } else {
        Console.WriteLine("Not a triangle!");
      }
    }
  //     if (sideOne === sideTwo && sideTwo === sideThree) {
  //   console.log("EQUAL");
  // } else if (sideOne === sideTwo || sideTwo === sideThree || sideOne === sideThree) {
  //   console.log("ISOSCELES");
  // // } else if ((sideOne + sideTwo) <= sideThree || (sideOne + sideThree) <= sideTwo || (sideTwo + sideThree) <= sideOne) {
  // //   console.log("NOT a triangle");
  // } else if (sideOne != sideTwo && sideOne != sideThree && sideTwo != sideThree) {
  //   console.log("SCALENE");
  // }

  }
}