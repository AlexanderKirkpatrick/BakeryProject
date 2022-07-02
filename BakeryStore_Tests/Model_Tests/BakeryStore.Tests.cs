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

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastriesConstructor_CreatesInstanceOfPastries_PastriesObject()
    {
      Pastries testPastry = new Pastries(3);
      Assert.AreEqual(typeof(Pastries), testPastry.GetType());
    }

    [TestMethod]
    public void PastriesConstructor_CreatesInstanceOfPastriesWithPastryCount_Int()
    {
      Pastries testPastry = new Pastries(3);
      Assert.AreEqual(3, testPastry.PastryCount);
    }

    [TestMethod]
    public void Cost_ReturnsCostOfOrder_Int()
    {
      Pastries testPastry = new Pastries(7);
      Assert.AreEqual(12, testPastry.Cost());
    }

    [TestMethod]
    public void Cost_ReturnsCostOfOrderWithDiscount_Int()
    {
      Pastries testPastry = new Pastries(3);
      Assert.AreEqual(5, testPastry.Cost());
    }
  }
}
