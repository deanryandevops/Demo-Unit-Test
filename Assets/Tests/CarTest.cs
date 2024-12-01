using NUnit.Framework;

public class CarTest
{
    [Test]
    public void GetNoDoors_Test()
    {
        // Assuming GetNoDoors is a static property
        int j = Car.GetNoDoors;

        // Correct assertion to compare integers
        Assert.AreEqual(2, j);
    }

    [Test]
    public void SetNoDoors_Test()
    {
        // Assuming SetNoDoors is a static method that sets the number of doors
        Car.SetNoDoors(2);

        // Check if the number of doors was correctly set
        int j = Car.GetNoDoors;
        Assert.AreEqual(2, j);
    }
}