public static class Car
{
    private static int noOfDoors = 1;  // Default value

    public static int GetNoDoors
    {
        get { return noOfDoors; }
    }

    public static void SetNoDoors(int doors)
    {
        if (noOfDoors < 1 || noOfDoors > 5)
        {
            noOfDoors = 1;
        }
        else
        {
            Car.noOfDoors = doors;
        }
    }
}
