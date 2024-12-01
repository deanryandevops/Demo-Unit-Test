using NUnit.Framework;

public class CarTest
{
    [SetUp]
    public void Setup()
    {
        // Reset the state before each test (if needed)
        Car.SetNoDoors(0);
    }

    [Test]
    public void GetNoDoors_Test()
    {
        // Set an initial value for validation
        Car.SetNoDoors(2);

        // Get the value and check it
        int j = Car.GetNoDoors;
        Assert.AreEqual(2, j, "The number of doors should be 2.");
    }

    [Test]
    public void SetNoDoors_Test()
    {
        // Set the number of doors and verify it
        Car.SetNoDoors(3);

        int j = Car.GetNoDoors;
        Assert.AreEqual(3, j, "The number of doors should be 3 after setting it.");
    }
}
