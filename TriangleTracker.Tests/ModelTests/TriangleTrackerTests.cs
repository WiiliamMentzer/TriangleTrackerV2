using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsTriangle_IsTriangle_True()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker(2, 2, 2);
      Assert.AreEqual(true, testTriangleTracker.IsTriangle());
    }
    [TestMethod]
    public void IsTriangle_IsTriangle_False()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker(2, 2, 8);
      Assert.AreEqual(false, testTriangleTracker.IsTriangle());
    }
    [TestMethod]
    public void TriangleType_IsEquliateral_EQUAL()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker(2, 2, 2);
      Assert.AreEqual("Equal", testTriangleTracker.TriangleType());
    }
    [TestMethod]
    public void TriangleType_IsIsosceles_Isosceles()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker(2, 2, 3);
      Assert.AreEqual("Isosceles", testTriangleTracker.TriangleType());
    }
    [TestMethod]
    public void TriangleType_IsScalene_Scalene()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker(2, 3, 4);
      Assert.AreEqual("Scalene", testTriangleTracker.TriangleType());
    }
  }
}