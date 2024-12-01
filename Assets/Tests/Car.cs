public static class Car
{
    private static int noOfDoors;

    public static int GetNoDoors
    {
        get { return noOfDoors; }
    }

    public static void SetNoDoors(int value)
    {
        noOfDoors = value;
    }
}