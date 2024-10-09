namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTest
{
    [TestMethod]
    public void ShouldConvertDecimalToCents()
    {
        var value = 13.5M;
        var cents = value.ToCents();
        
        Assert.AreEqual(1350, cents);
    }
}