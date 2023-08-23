namespace PaymentApplication.Tests;

public class CategoryServiceTest
{
    [Fact]
    public void TestSum()
    {
        int x = 10;
        int y = 20;
        
        Assert.Equal(30,(x+y));
    }
    [Fact]
    public void TestsSubtract()
    {
        int x = 10;
        int y = 20;
        
        Assert.Equal(-10,(x-y));
    }
    
    [Fact]
    public void TestsMultiply()
    {
        int x = 10;
        int y = 20;
        
        Assert.Equal(200,(x*y));
    }
    
    [Fact]
    public void TestsDivide()
    {
        int x = 10;
        int y = 20;
        
        Assert.Equal(2,(y/x));
    }
}