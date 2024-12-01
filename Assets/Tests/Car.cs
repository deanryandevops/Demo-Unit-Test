public static class Car
{
    private static int noOfDoors;

    // Static property to get the number of doors
    public static int GetNoDoors
    {
        get { return noOfDoors; }
    }

    // Static method to set the number of doors
    public static void SetNoDoors(int value)
    {
        noOfDoors = value;
    }
}