using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryStore.Models;

namespace BakeryStore.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCOnstructor_CreatesInstanceOfBread_BreadObject()
    {
      Bread testBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadWithBreadCount_Int()
    {
      Bread testBread = new Bread(3);
      Assert.AreEqual(3, testBread.BreadCount);
    }

    [TestMethod]
    public void Cost_ReturnsCostOfOrder_Int()
    {
      Bread testBread = new Bread(1);
      Assert.AreEqual(5, testBread.Cost());
    }

    [TestMethod]
    public void Cost_ReturnsCostOfOrderWithDiscount_Int()
    {
      Bread testBread = new Bread(6);
      Assert.AreEqual(20, testBread.Cost());
    }
  }
}
