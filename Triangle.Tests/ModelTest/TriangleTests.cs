using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_CanInputThreeSides_True()
    {
      Triangle testTriangle = new Triangle(3, 4, 5);
      Assert.AreEqual(true, Triangle.SideOne == 3);
    }
  }
}
