public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // To solve this,
        // I will create an empty <list> Array
        // next, I will loop my operation in accordance to the length provide as parament (arg2)
        // while creating an index variable to check and not overloop or underloop
        // for each index, i will add the result to the operation to the array initially created
        // I will return the list of array, now filled with data. 
        List<double> MultiplesOfArray = [];

        for (int index = 1; index <= length; index++)
        {
            MultiplesOfArray.Add(number * index);
        }

        return MultiplesOfArray.ToArray();
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // To solve this
        // First, I will find the position (index) where the rotation starts, and save it (startIndex)
        // next, I will select and save the items meant to be rotated from the startIndex to the end in a temporary list
        // I will remove those elements from the end of the original list
        // and I will insert them at the beginning of the original list

        // Find the position to start the rotation
        int startIndex = data.Count - amount;

        // get the range of items from the original data starting from the startIndex and the amount
        List<int> lastItems = data.GetRange(startIndex, amount);

        // Remove the range from the original data
        data.RemoveRange(startIndex, amount);

        // Insert into the original data in the beginning
        data.InsertRange(0, lastItems);

    }
}
